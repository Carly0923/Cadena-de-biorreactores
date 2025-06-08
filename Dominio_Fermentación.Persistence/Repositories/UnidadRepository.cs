using Dominio_Fermentación.Contracts.Repositories;
using Dominio_Fermentación.Persistence.Context;
using Dominio_Fermentación.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Fermentación.Persistence.Repositories
{
    public class UnidadRepository
        : IUnidadRepository
    {
        private readonly AppDbContext _context;

        public UnidadRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Unidad unit)
        {
            await _context.Unidads.AddAsync(unit);
        }

        public async void DeleteById(Guid id)
        {
            var unit = await _context.Unidads.FindAsync(id);
            if (unit is null)
                return;
            _context.Unidads.Remove(unit);
        }

        public async Task<Unidad> GetByIdAsync(Guid id)
        {
            return await _context.Unidads.FindAsync(id);
        }

        public Task<IEnumerable<Unidad>> GetUnitsAsync()
        {
            return Task.FromResult<IEnumerable<Unidad>>(_context.Unidads.ToList());
        }

        public void Update(Unidad unit)
        {
            _context.Unidads.Update(unit);
        }

    }
}