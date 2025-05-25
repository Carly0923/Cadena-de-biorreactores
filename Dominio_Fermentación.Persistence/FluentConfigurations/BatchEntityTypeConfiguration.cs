using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            builder.OwnsOne(x => x.Id_Batch);
            builder.OwnsOne(x => x.Initial_Date);
            builder.OwnsOne(x => x.Final_Date);
            
        }
    }
}
