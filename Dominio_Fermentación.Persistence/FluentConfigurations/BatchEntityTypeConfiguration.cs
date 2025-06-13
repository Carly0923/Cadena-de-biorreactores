using Dominio_Fermentación.Entities;
using Dominio_Fermentación.Persistence.FluentConfigurations.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dominio_Fermentación.Persistence.FluentConfigurations
{
    internal class BatchEntityTypeConfiguration
        : EntityTypeConfigurationBase<Batch>
    {
        public override void Configure(EntityTypeBuilder<Batch> builder)
        {
            base.Configure(builder);
            builder.ToTable("Batch");
            builder.OwnsOne(batch => batch.Codelote);
            builder.HasKey(x => new { x.Initial_Date, x.Final_Date });

        }
    }
}
