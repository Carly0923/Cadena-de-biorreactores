using Dominio_Fermentación.Entities;
using Dominio_Fermentación.Persistence.FluentConfigurations.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Fermentación.Persistence.FluentConfigurations
{
    internal class OperationEntityTypeConfiguration
        : EntityTypeConfigurationBase<Operation>
    {
        public override void Configure(EntityTypeBuilder<Operation> builder)
        {
            base.Configure(builder);
            builder.ToTable("Operations");
        }
    }
}