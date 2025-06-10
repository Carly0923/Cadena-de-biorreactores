using Dominio_Fermentación.Entities;
using Dominio_Fermentación.Persistence.FluentConfigurations.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dominio_Fermentación.Persistence.FluentConfigurations
{
    internal class AutomationDeviceEntityTypeConfiguration
        : EntityTypeConfigurationBase<AutomationDevice>
    {
        public override void Configure(EntityTypeBuilder<AutomationDevice> builder)
        {
            base.Configure(builder);
            builder.ToTable("AutomationDevices");
            builder.OwnsOne(x => x.Address);
        }
    }
}