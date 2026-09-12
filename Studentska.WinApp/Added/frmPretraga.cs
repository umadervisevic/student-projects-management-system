using Studentska.Data.Added;
using Studentska.Servis.Added;
using Studentska.WinApp.Izvjestaji;
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
    public partial class frmPretraga : Form
    {
        ProjektiServis pServis = new ProjektiServis();
        StudentiProjektiServis spServis = new StudentiProjektiServis();
        List<StudentiProjekti> PrijavePodaci = new List<StudentiProjekti>();
        public frmPretraga()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
            dgvPretraga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            cmbStanje.SelectedIndex = 0;
            UcitajDGV();
        }

        private void UcitajDGV()
        {
            var tekst = txtPretraga.Text.Trim().ToLower();
            var status = cmbStatus.SelectedItem.ToString();
            var stanje = cmbStanje.SelectedItem?.ToString() ?? "Sve";

            PrijavePodaci = spServis.FiltrirajPodatke(tekst, status, stanje);
            dgvPretraga.DataSource = null;
            dgvPretraga.DataSource = PrijavePodaci;
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            UcitajDGV();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajDGV();
        }

        private void cmbStanje_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajDGV();
        }

        private void dgvPretraga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var zapis = PrijavePodaci[e.RowIndex];
            if (zapis == null) return;

            if (e.ColumnIndex == 7)
            {
                if (zapis.Arhivirana == true)
                {
                    MessageBox.Show("Odabrani zapis je vec arhiviran");
                    return;
                }
                zapis.Arhivirana = true;
                spServis.Update(zapis);
                UcitajDGV();
            }
        }

        private void dgvPretraga_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var prijavaEdit = PrijavePodaci[e.RowIndex];
            var forma = new frmPrijavaAddEdit(prijavaEdit);
            forma.ShowDialog();
            UcitajDGV();
        }

        private void btnNovaPrijava_Click(object sender, EventArgs e)
        {
            var forma = new frmPrijavaAddEdit();
            forma.ShowDialog();
            UcitajDGV();
        }

        private void btnNoviProjekat_Click(object sender, EventArgs e)
        {
            var forma = new frmProjekatAdd();
            forma.ShowDialog();
        }

        public class dtoPrijavePrint
        {
            public List<StudentiProjekti> Prijave { get; set; }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            var dto = new dtoPrijavePrint
            {
                Prijave = PrijavePodaci
            };

            var forma = new frmIzvjestaji(dto);
            forma.ShowDialog();
        }
    }
}
