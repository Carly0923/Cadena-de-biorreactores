using Dominio_Fermentación.Persistence.FluentConfigurations.Common;
using Dominio_Fermentación.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_Fermentación.Persistence.FluentConfigurations
{
    internal class Unidad_de_medidaEntityTypeConfiguration
        : EntityTypeConfigurationBase<Unidad_de_medida>
    {
        public override void Configure(EntityTypeBuilder<Unidad_de_medida> builder)
        {
            base.Configure(builder);
            builder.ToTable("Unidad_de_medida");
            builder.OwnsOne(x => x.IP_Address);//
        }
    }
}
