using Dominio_Fermentación.Persistence.Context;
using Dominio_Fermentación.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio_Fermentación.Contracts.Repositories;

namespace Dominio_Fermentación.Persistence.Repositories
{
    public class UnitRepository
        : IUnitRepository
    {
        private readonly AppDbContext _context;

        public UnitRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Unidad unidad)
        {
            await _context.Unidades.AddAsync(unidad);
        }

        public async void DeleteById(Guid id)
        {
            var unidad = await _context.Unidades.FindAsync(id);
            if (unidad is null)
                return;
            _context.Unidades.Remove(unidad);
        }

        public async Task<Unidad> GetByIdAsync(Guid id)
        {
            return await _context.Unidades.FindAsync(id);
        }

        public Task<IEnumerable<Unidad>> GetUnitsAsync()
        {
            return Task.FromResult<IEnumerable<Unidad>>(_context.Unidades.ToList());
        }

        public void Update(Unidad unidad)
        {
            _context.Unidades.Update(unidad);
        }

    }
}