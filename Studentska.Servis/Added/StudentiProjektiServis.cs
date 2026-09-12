using Microsoft.EntityFrameworkCore;
using Studentska.Data.Added;
using Studentska.Servis.Servisi;

namespace Studentska.Servis.Added
{
    public class StudentiProjektiServis : BaseServis<StudentiProjekti>
    {
        public List<StudentiProjekti> FiltrirajPodatke(string tekst, string? status, string stanje)
        {
            return _dbContext.StudentiProjekti.AsNoTracking().Include(s => s.Student)
                                                      .Include(s => s.Projekat)
                                                      .Where(s => (string.IsNullOrEmpty(tekst)
                                                      || s.Student.Ime.ToLower().Contains(tekst)
                                                      || s.Student.Prezime.ToLower().Contains(tekst)
                                                      || s.Projekat.Naziv.ToLower().Contains(tekst))
                                                      && (s.Status == status || status == "Sve")
                                                      && (stanje == "Sve"
                                                      || (stanje == "Aktivna" && !s.Arhivirana)
                                                      || (stanje == "Arhivirana" && s.Arhivirana))).ToList();
        }

        public int GetBrojPrihvacenih(int projekatId, int? id2)
        {
            return _dbContext.StudentiProjekti.Count(p => p.ProjekatId == projekatId && p.Status == "PRIHVACENA"
                                                                && (id2 == null || p.Id != id2));
        }

        public bool ImaVecAktivnuPrijavu(int studentId, int projekatId, int? id3)
        {
            return _dbContext.StudentiProjekti.Any(s => s.StudentId == studentId
                                                              && s.ProjekatId == projekatId
                                                              && !s.Arhivirana
                                                              && (id3 == null || s.Id != id3));
        }

        public bool ImaVecPrihvacenu(int studentId, int? id2)
        {
            return _dbContext.StudentiProjekti.Any(s => s.StudentId == studentId
                                                              && s.Status == "PRIHVACENA"
                                                              && (id2 == null || s.Id != id2));
        }

        public List<Projekti> NemaAktivnuPrijavu(int studentId)
        {
            var gdjeIma = _dbContext.StudentiProjekti.Where(p => p.StudentId == studentId && p.Arhivirana == false)
                                                              .Select(p => p.ProjekatId)
                                                              .Distinct();

            return _dbContext.Projekti.Where(x => !gdjeIma.Contains(x.Id)
                                                           && x.Aktivan == true
                                                           && x.RokZavrsetka.Date >= DateTime.Now.Date).ToList();
        }

        public void Update(StudentiProjekti zapis)
        {
            var entity = _dbContext.StudentiProjekti.Find(zapis.Id);
            if (entity == null) return;

            entity.ProjekatId = zapis.ProjekatId;
            entity.DatumPrijave = zapis.DatumPrijave;
            entity.DatumPromjeneStatusa = zapis.DatumPromjeneStatusa;
            entity.Status = zapis.Status;
            entity.Arhivirana = zapis.Arhivirana;

            _dbContext.SaveChanges();
            _dbContext.ChangeTracker.Clear();
        }
    }
}
