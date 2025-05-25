using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio_Fermentación.Entities;
using Dominio_Fermentación.Persistence.FluentConfigurations.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dominio_Fermentación.Persistence.FluentConfigurations
{
    internal class Programmable_Logic_ControllerEntityTypeConfiguration
        : EntityTypeConfigurationBase<Programmable_Logic_Controller>
    {
        public override void Configure(EntityTypeBuilder<Programmable_Logic_Controller> builder)
        {
            base.Configure(builder);
            builder.ToTable("Programmable_Logic_Controller");
            builder.OwnsOne(x => x.IP_Address);
        }
    }
}
