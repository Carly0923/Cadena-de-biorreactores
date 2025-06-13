using Dominio_Fermentación.Entities;
using Dominio_Fermentación.Records;
using Dominio_Fermentación.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace Dominio_Fermentación.Persistence.Context
{
    public class AppDbContext
        : DbContext
    {
        #region Tablas
        public DbSet<Variable> Variables => Set<Variable>();
        public DbSet<Batch> Batchs => Set<Batch>();
        public DbSet<EquipmentStateChangeRecords> EquipmentStateChangeRecords => Set<EquipmentStateChangeRecords>();
        public DbSet<Unidad> Unidades => Set<Unidad>();
        public DbSet<AutomationDevice> AutomationDevices => Set<AutomationDevice>();
        public DbSet<Operation> Operations => Set<Operation>();



        #endregion

        /// <summary>
        /// Requerido por EntityFrameworkCore para migraciones.
        /// </summary>
        public AppDbContext()
        {
        }

        /// <summary>
        /// Inicializa un objeto <see cref="ApplicationContext"/>.
        /// </summary>
        /// <param name="connectionString">
        /// Cadena de conexión.
        /// </param>
        public AppDbContext(string connectionString)
            : base(GetOptions(connectionString))
        {
        }

        /// <summary>
        /// Inicializa un objeto <see cref="ApplicationContext"/>.
        /// </summary>
        /// <param name="options">
        /// Opciones del contexto.
        /// </param>
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }

        #region Helpers

        private static DbContextOptions GetOptions(string connectionString)
        {
            return NpgsqlDbContextOptionsBuilderExtensions.UseNpgsql(new DbContextOptionsBuilder(), connectionString).Options;
        }

        #endregion
    }
}