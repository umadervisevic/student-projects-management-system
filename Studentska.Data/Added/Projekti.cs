using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Studentska.Data.Added
{
    public class Projekti
    {
        public int Id { get; set; }
		public string Naziv {get; set;}
		public byte[] Slika {get; set;}
		public DateTime RokZavrsetka {get; set;}
		public int MaxBrojStudenata {get; set;}
		public bool Aktivan {get; set;}
		public string? Napomena {get; set;}
        public override string ToString()
        {
            return Naziv;
        }
    }
}
