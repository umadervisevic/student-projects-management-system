using Studentska.Data.Added;
using Studentska.Data.Entiteti;
using Studentska.Servis.Added;
using Studentska.Servis.Servisi;
using Studentska.WinApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentska.WinApp.Added
{
    public partial class frmPrijavaAddEdit : Form
    {
        private StudentiProjekti prijavaEdit;
        ProjektiServis pServis = new ProjektiServis();
        StudentiProjektiServis spServis = new StudentiProjektiServis();
        StudentServis sServis = new StudentServis();

        public frmPrijavaAddEdit(StudentiProjekti? prijava = null)
        {
            InitializeComponent();
            prijavaEdit = prijava;
        }

        private void frmPrijavaAddEdit_Load(object sender, EventArgs e)
        {
            UcitajStudente();
            UcitajProjekte();
            cmbStatus.SelectedIndex = 0;
            if (prijavaEdit == null)
                DodajPrijavu();
            else
                EditujPrijavu();
        }

        private void EditujPrijavu()
        {
            Text = "Editovanje prijave na projekat";
            cmbStudenti.Enabled = false;
            cmbStatus.SelectedItem = prijavaEdit.Status;
            if (cmbStatus.SelectedItem.ToString() != "PODNESENA")
            {
                cmbProjekti.Enabled = false;
            }
            cmbStudenti.SelectedValue = prijavaEdit.StudentId;
            cmbProjekti.SelectedValue = prijavaEdit.ProjekatId;
            dtpDatumPrijave.Value = prijavaEdit.DatumPrijave;
        }

        private void DodajPrijavu()
        {
            Text = "Nova prijava na projekat";
            cmbStatus.Enabled = false;
        }

        private void UcitajProjekte()
        {
            cmbProjekti.UcitajPodatke(pServis.GetAktivne());
        }

        private void UcitajStudente()
        {
            cmbStudenti.UcitajPodatke(sServis.GetAll());
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var student = cmbStudenti.SelectedItem as Student;
                var projekat = cmbProjekti.SelectedItem as Projekti;
                var datumPrijave = dtpDatumPrijave.Value.Date;
                var status = cmbStatus.SelectedItem.ToString();

                if (prijavaEdit == null)
                {
                    var novaPrijava = new StudentiProjekti
                    {
                        StudentId = student.Id,
                        ProjekatId = projekat.Id,
                        DatumPrijave = datumPrijave,
                        Status = status,
                        DatumPromjeneStatusa = null,
                        Arhivirana = false
                    };
                    spServis.Add(novaPrijava);
                    MessageBox.Show("Nova prijava uspjesno dodana");
                    Close();
                }
                else
                {
                    if (prijavaEdit.Status != status)
                    {
                        prijavaEdit.DatumPromjeneStatusa = DateTime.Now.Date;
                    }
                    prijavaEdit.ProjekatId = projekat.Id;
                    prijavaEdit.Status = status;
                    prijavaEdit.DatumPrijave = datumPrijave;
                    if (status == "ZAVRSENA")
                    {
                        prijavaEdit.Arhivirana = true;
                    }
                    spServis.Update(prijavaEdit);
                    MessageBox.Show("Promjene uspjesno spasene");
                    Close();
                }
            }
        }

        private bool ValidanUnos()
        {
            if (cmbStudenti.SelectedItem == null ||
                cmbProjekti.SelectedItem == null ||
                cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Sva polja su obavezna");
                return false;
            }

            var status = cmbStatus.SelectedItem.ToString();
            if (prijavaEdit != null && status == "PODNESENA" && prijavaEdit.Status != "PODNESENA")
            {
                MessageBox.Show("Status projekta se ne moze vratiti na \"PODNESENA\"", "Greska",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var projekat = cmbProjekti.SelectedItem as Projekti;
            if (!projekat.Aktivan)
            {
                MessageBox.Show("Projekat nije aktivan, ne moze biti dodan", "Greska",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var datumPrijave = dtpDatumPrijave.Value.Date;
            var rokZavrsetka = projekat.RokZavrsetka.Date;

            if (datumPrijave > rokZavrsetka)
            {
                MessageBox.Show("Datum prijave nije validan, projekat je vec zavrsio", "Greska",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var student = cmbStudenti.SelectedItem as Student;
            bool vecAktivnaPrijava = spServis.ImaVecAktivnuPrijavu(student.Id, projekat.Id, prijavaEdit?.Id);
            if (vecAktivnaPrijava)
            {
                MessageBox.Show("Student ima vec aktivnu prijavu na odabrani projekat", "Greska",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool vecPrihvacenaPrijava = spServis.ImaVecPrihvacenu(student.Id, prijavaEdit?.Id);
            if (vecPrihvacenaPrijava)
            {
                MessageBox.Show("Student ima vec prihvacenu prijavu", "Greska",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int brojPrihvacenih = spServis.GetBrojPrihvacenih(projekat.Id, prijavaEdit?.Id);
            if (brojPrihvacenih >= projekat.MaxBrojStudenata)
            {
                MessageBox.Show("Popunjen je maksimalni broj prijava, nova mjesta se otvaraju nakon zavrsenih projekata", "Greska",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnGenerisiPrijave_Click(object sender, EventArgs e)
        {
            var student = cmbStudenti.SelectedItem as Student;
            if (student == null)
                return;

            txtInfo.Clear();
            var thread = new Thread(() => GenerisiPrijave(student));
            thread.Start();
        }

        private void GenerisiPrijave(Student student)
        {
            var prijave = spServis.NemaAktivnuPrijavu(student.Id);
            if (prijave.Count == 0)
            {
                BeginInvoke(new Action(() =>
                {
                    MessageBox.Show("Ne postoji nijedan projekat za koji se moze generisati prijava.",
                        "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
                return;
            }

            for (int i = 0; i < prijave.Count; i++)
            {
                var prijava = prijave[i];

                var novaPrijava = new StudentiProjekti
                {
                    StudentId = student.Id,
                    ProjekatId = prijava.Id,
                    DatumPrijave = DateTime.Now.Date,
                    Status = "PODNESENA",
                    DatumPromjeneStatusa = DateTime.Now.Date,
                    Arhivirana = false
                };
                spServis.Add(novaPrijava);

                BeginInvoke(new Action(() =>
                {
                    txtInfo.Text += $"Dodana prijava na projekat \"{prijava.Naziv}\" - studentu {student.IndeksImePrezime}."
                    + Environment.NewLine;

                    txtInfo.SelectionStart = txtInfo.Text.Length;
                    txtInfo.ScrollToCaret();
                }));
                Thread.Sleep(300);
            }
            BeginInvoke(new Action(() =>
            {
                MessageBox.Show("Nove prijave uspjesno generisane", "Poruka",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));
        }
    }
}
