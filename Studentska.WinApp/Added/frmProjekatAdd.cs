using Studentska.Data.Added;
using Studentska.Servis.Added;
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
    public partial class frmProjekatAdd : Form
    {
        ProjektiServis pServis = new ProjektiServis();
        public frmProjekatAdd()
        {
            InitializeComponent();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var naziv = txtNaziv.Text;
                var napomena = txtNapomena.Text;
                var rokZavrsetka = dtpRokZavrsetka.Value;
                var maxbr = int.Parse(txtMaxBroj.Text);
                var aktivan = cbAktivan.Checked;
                var slika = ImageHelper.ImageToByte(pbLogo.Image);

                var noviProjekat = new Projekti
                {
                    Naziv = naziv,
                    Napomena = napomena,
                    RokZavrsetka = rokZavrsetka,
                    MaxBrojStudenata = maxbr,
                    Aktivan = aktivan,
                    Slika = slika
                };
                pServis.Add(noviProjekat);
                MessageBox.Show("Novi projekat uspjesno dodan");
                Close();
            }
        }

        private bool ValidanUnos()
        {
            if (!Validator.ValidanUnos(txtNaziv, err, "Obavezan unos") ||
                !Validator.ValidanUnos(txtMaxBroj, err, "Obavezan unos") ||
                !Validator.ValidanUnos(pbLogo, err, "Obavezan unos"))
                return false;

            var naziv = txtNaziv.Text;
            bool duplikat = pServis.GetDuplikat(naziv);
            if (duplikat)
            {
                MessageBox.Show("Projekat sa istim nazivom je vec dodan", "Greska",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var rokZavrsetka = dtpRokZavrsetka.Value.Date;
            var danas = DateTime.Now.Date;
            if (rokZavrsetka < danas)
            {
                MessageBox.Show("Rok zavrsetka nije validan", "Greska",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var maxbr = int.Parse(txtMaxBroj.Text);
            if (maxbr <= 0)
            {
                MessageBox.Show("Broj studenata mora biti veci od 0", "Greska",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
