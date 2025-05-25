using Dominio_Fermentación.Common;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Dominio_Fermentación.Persistence.FluentConfigurations.Common
{
    /// <summary>
    /// Necesario para trabajar con los Entity creados en el Domain
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class EntityTypeConfigurationBase<T>
        : IEntityTypeConfiguration<T>
        where T : Entity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
        }
    }
}