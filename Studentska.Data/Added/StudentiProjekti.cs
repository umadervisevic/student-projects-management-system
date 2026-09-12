using Studentska.Data.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Studentska.Data.Added
{
    public class StudentiProjekti
    {
        public int Id { get; set; }
		public int StudentId {get; set;}
		public Student Student { get; set;}
		public int ProjekatId {get; set;}
		public Projekti Projekat { get; set;}
		public DateTime DatumPrijave {get; set;}
		public string Status {get; set;}
		public DateTime? DatumPromjeneStatusa {get; set;}
		public bool Arhivirana {get; set;}
        public string IndeksImePrezime => Student.IndeksImePrezime;
        public string Naziv => Projekat.Naziv;
        public string Stanje => Arhivirana ? "Arhivirana" : "Aktivna";
        public string RokZavrsetka => Projekat.RokZavrsetka.ToString();
    }
}
