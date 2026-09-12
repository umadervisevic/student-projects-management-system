using Studentska.Data.Added;
using Studentska.Servis.Servisi;

namespace Studentska.Servis.Added
{
    public class ProjektiServis : BaseServis<Projekti>
    {
        public List<Projekti> GetAktivne()
        {
            return _dbContext.Projekti.Where(p => p.Aktivan == true).ToList();
        }

        public bool GetDuplikat(string naziv)
        {
            return _dbContext.Projekti.Any(p => p.Naziv == naziv);
        }
    }
}
