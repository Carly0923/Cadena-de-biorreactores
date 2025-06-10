using Dominio_Fermentación.Records;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dominio_Fermentación.Persistence.FluentConfigurations
{
    internal class EquipmentStateChangedRecordsEntityTypeConfiguration
        : IEntityTypeConfiguration<EquipmentStateChangeRecords>
    {
        public void Configure(EntityTypeBuilder<EquipmentStateChangeRecords> builder)
        {
            builder.ToTable("StateChangeRecords");
            builder.HasKey(x => new { x.EquipmentId, x.OccurringTime });
        }
    }
}