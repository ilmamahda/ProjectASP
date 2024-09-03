using ProjectASP.Data;
using ProjectASP.Models;

namespace ProjectASP.Repositories
{
    public class IPenggajianRepostory
    {
        private readonly ApplicationDbContext _context;

        public IPenggajianRepostory(ApplicationDbContext context)
        {
            _context = context;
        }

        public Penggajian Tambah(Penggajian Penggajian)
        {
            _context.Penggajians.Add(Penggajian);
            _context.SaveChanges();
            return Penggajian;
        }

        public Penggajian Update(Penggajian update)
        {
            var Penggajian = _context.Penggajians.Attach(update);
            Penggajian.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return update;
        }

        public Penggajian Delete(Guid Id)
        {
            var Penggajian = _context.Penggajians.Find(Id);
            if (Penggajian != null)
            {
                _context.Penggajians.Remove(Penggajian);
                _context.SaveChanges();
            }
            return Penggajian;
        }
    }
}
