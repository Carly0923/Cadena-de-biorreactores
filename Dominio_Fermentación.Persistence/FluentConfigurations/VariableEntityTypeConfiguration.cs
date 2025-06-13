using Dominio_Fermentación.Entities;
using Dominio_Fermentación.Persistence.FluentConfigurations.Common;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Dominio_Fermentación.Persistence.FluentConfigurations
{
    internal class VariableEntityTypeConfiguration 
        : EntityTypeConfigurationBase<Variable>
    {
        public override void Configure(EntityTypeBuilder<Variable> builder)
        {
            base.Configure(builder);
            builder.ToTable("Variables");
            builder.OwnsOne(x => x.Unidad); 
            builder.OwnsOne(x => x.Node); 
        }
    }
}
