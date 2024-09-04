using Microsoft.EntityFrameworkCore;
using ProjectASP.Data;
using ProjectASP.Models;

namespace ProjectASP.Repositories
{
    public class IKaryawanRepository
    {
        private readonly ApplicationDbContext _context;

        public IKaryawanRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Karyawan Tambah(Karyawan karyawan)
        {
            _context.Karyawans.Add(karyawan);
            _context.SaveChanges();
            return karyawan;        
        }

        public Karyawan Update(Karyawan update)
        {
            var Karyawan = _context.Karyawans.Attach(update);
            Karyawan.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return update;
        }

        public Karyawan Delete(Guid Id)
        {
            var Karyawan = _context.Karyawans.Find(Id);
            if (Karyawan != null)
            {
                _context.Karyawans.Remove(Karyawan);
                _context.SaveChanges();
            }
            return Karyawan;
        }

        public IEnumerable<Karyawan> GetAllKaryawan() {
            return _context.Karyawans.AsNoTracking();
        }
    }
}
