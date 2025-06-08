﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio_Fermentación.Entities;

namespace Dominio_Fermentación.Contracts.Repositories
{
    public interface IOperationRepository
    {
        /// <summary>
        /// Añade una operación a base de datos.
        /// </summary>
        Task AddAsync(Operation operation);
        /// <summary>
        /// Obtiene una operación a partir de su Id.
        /// </summary>
        Task<Operation> GetByIdAsync(Guid id);
        /// <summary>
        /// Obtiene todas las operaciones a partir de la unidad a la que pertenecen.
        /// </summary>
        Task<IEnumerable<Operation>> GetOperationsByUnitAsync(Guid unitId);
        /// <summary>
        /// Actualiza la información de una operación.
        /// </summary>
        void Update(Operation operation);
        /// <summary>
        /// Elimina una operación a partir de su Id.
        /// </summary>
        void DeleteById(Guid id);
    }
}