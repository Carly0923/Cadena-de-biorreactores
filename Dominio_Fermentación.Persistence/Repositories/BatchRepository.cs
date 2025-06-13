using Dominio_Fermentación.Contracts.Repositories;
using Dominio_Fermentación.Entities;
using Dominio_Fermentación.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Dominio_Fermentación.Persistence.Repositories
{
    public class BatchRepository
        :IBatchRepository
    {
        private readonly AppDbContext _context;
        public BatchRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Batch batch)
        {
            await _context.Batchs.AddAsync(batch);
        }
        public async void DeleteById(Guid id)
        {
            var batch = await _context.Batchs.FindAsync(id);
            if (batch is null)
                return;
            _context.Batchs.Remove(batch);
        }
        public async Task<Batch> GetByIdAsync(Guid id)
        {
            return await _context.Batchs.FindAsync(id);
        }

        public async Task<IEnumerable<Batch>> GetBatchAsync()
        {

            return await Task.FromResult<IEnumerable<Batch>>(_context.Batchs.ToList());
        }
        
        public void Update(Batch batch)
        {
            _context.Batchs.Update(batch);
        }

    }
}




