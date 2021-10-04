using ClinicAPI.Data;
using ClinicAPI.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAPI.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<Doctor> _doctors;
        private IGenericRepository<Patient> _patients;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }
        public IGenericRepository<Doctor> Doctors => _doctors ??= new GenericRepository<Doctor>(_context);

        public IGenericRepository<Patient> Patients => _patients ??= new GenericRepository<Patient>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
