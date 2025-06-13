using Dominio_Fermentación.Entities;

namespace Dominio_Fermentación.Contracts.Repositories
{
    public interface IBatchRepository
    {
        Task AddAsync(Batch batch);
        /// <summary>
        /// Obtiene un batch a partir de su Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Batch> GetByIdAsync(Guid id);
        /// <summary>
        /// Obtiene todas las batches.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Batch>> GetBatchAsync();
        /// <summary>
        /// Actualiza la información de una batch.
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        void Update(Batch batch);
        /// <summary>
        /// Elimina un batch a partir de su Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void DeleteById(Guid id);
    }
}
