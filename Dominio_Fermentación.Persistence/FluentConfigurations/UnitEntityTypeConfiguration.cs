using Dominio_Fermentación.Persistence.FluentConfigurations.Common;
using Dominio_Fermentación.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dominio_Fermentación.Persistence.FluentConfigurations
{
    internal class UnitEntityTypeConfiguration
        : EntityTypeConfigurationBase<Unidad>
    {

        public override void Configure(EntityTypeBuilder<Unidad> builder)
        {
            base.Configure(builder);
            builder.ToTable("Unitdades");
            builder.OwnsOne(unit => unit.Code);
            builder.HasMany(u => u.Variables).WithOne().HasForeignKey(x => x.UnitId);
            builder.HasMany(u => u.Operations).WithOne().HasForeignKey(x => x.UnitId);
            builder.Navigation(u => u.ActiveOperation);
            builder.HasMany(u => u.AutomationDevices).WithMany(a => a.Unidades);
        }
    }
}