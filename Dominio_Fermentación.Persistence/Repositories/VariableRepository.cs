﻿using Dominio_Fermentación.Contracts.Repositories;
using Dominio_Fermentación.Entities;
using Dominio_Fermentación.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Dominio_Fermentación.Persistence.Repositories
{
    public class VariableRepository
        : IVariableRepository
    {

        private readonly AppDbContext _context;

        public VariableRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Variable variable)
        {
            await _context.Variables.AddAsync(variable);
        }

        public async void DeleteById(Guid id)
        {
            var variable = await _context.Variables.FindAsync(id);
            if (variable is null)
                return;
            _context.Variables.Remove(variable);
        }

        public async Task<Variable?> GetByIdAsync(Guid id)
        {
            return await _context.Variables.FindAsync(id);
        }

        public async Task<IEnumerable<Variable>> GetVariablesByUnitAsync(Guid unitId)
        {
            
            var unit = await _context.Unidades
                .Include(u => u.Variables)
                .FirstAsync(u => u.Id == unitId);
            return unit.Variables;
        }

     

        public void Update(Variable variable)
        {
            _context.Variables.Update(variable);
        }
    }
}