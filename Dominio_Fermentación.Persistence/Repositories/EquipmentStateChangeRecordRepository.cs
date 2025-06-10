using Dominio_Fermentación.Contracts.Repositories;
using Dominio_Fermentación.Persistence.Context;
using Dominio_Fermentación.Records;
using Microsoft.EntityFrameworkCore;

namespace Dominio_Fermentación.Persistence.Repositories
{
    public class EquipmentStateChangeRecordRepository
        : IEquipmentStateChangeRecordRepository
    {

        private readonly AppDbContext _context;

        public EquipmentStateChangeRecordRepository(
            AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(EquipmentStateChangeRecords record)
        {
            await _context.EquipmentStateChangeRecords.AddAsync(record);
        }

        public async Task<IEnumerable<EquipmentStateChangeRecords>> GetEquipmentStateChangeRecords(DateTime start, DateTime end)
        {
            return await _context.EquipmentStateChangeRecords
                .Where(x => x.OccurringTime >= start && x.OccurringTime <= end)
                .ToListAsync();
        }
    }
}