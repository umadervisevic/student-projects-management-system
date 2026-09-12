using Microsoft.Reporting.WinForms;
using Studentska.WinApp.Added;
using System.Data;

namespace Studentska.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private frmPretraga.dtoPrijavePrint dto;

        public frmIzvjestaji()
        {
            InitializeComponent();
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "Studentska.WinApp.Izvjestaji.rptStudentiUplate.rdlc";
        }

        public frmIzvjestaji(frmPretraga.dtoPrijavePrint dto) : this()
        {
            this.dto = dto;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var tabela = new dsIzvjestaji.ProjektiDataTable();
            int ukupnoDana = 0;

            for (int i = 0; i < dto.Prijave.Count; i++)
            {
                var stavka = dto.Prijave[i];
                var red = tabela.NewProjektiRow();
                var razlikaDana = (stavka.Projekat.RokZavrsetka.Date - DateTime.Now.Date).Days;
                if (razlikaDana < 0) razlikaDana = 0;
                ukupnoDana += razlikaDana;

                red.Rb = (i + 1).ToString();
                red.Student = stavka.Student.IndeksImePrezime;
                red.Projekat = stavka.Projekat.Naziv;
                red.Stanje = stavka.Arhivirana ? "Arhiviran" : "Aktivan";
                red.RokZavrsetka = stavka.Projekat.RokZavrsetka.Date.ToString("dd.MM.yyyy");
                red.BrojDana = razlikaDana.ToString();

                tabela.AddProjektiRow(red);
            }

            double prosjek = dto.Prijave.Count > 0 ? (double)ukupnoDana / dto.Prijave.Count : 0;

            var parametri = new ReportParameterCollection();
            parametri.Add(new ReportParameter("pProsjekDana", prosjek.ToString("0.00")));

            var ds = new ReportDataSource("DataSet1", (DataTable)tabela);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.SetParameters(parametri);
            reportViewer1.RefreshReport();
        }
    }
}
