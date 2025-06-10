using Dominio_Fermentación.Entities;

namespace Dominio_Fermentación.Contracts.Repositories
{
    /// <summary>
    /// Define las funcionalidades de un repositorio de unidades.
    /// </summary>
    public interface IUnitRepository
    {
        /// <summary>
        /// Añade una unidad a base de datos.
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        Task AddAsync(Unidad unit);
        /// <summary>
        /// Obtiene un unidad a partir de su Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Unidad> GetByIdAsync(Guid id);
        /// <summary>
        /// Obtiene todas las unidades.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Unidad>> GetUnitsAsync();
        /// <summary>
        /// Actualiza la información de una unidad.
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        void Update(Unidad unit);
        /// <summary>
        /// Elimina una unidad a partir de su Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void DeleteById(Guid id);
    }
}