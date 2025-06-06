﻿using Dominio_Fermentación.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentResults;

namespace Dominio_Fermentación.Entities.Abstract
{
    public interface IStatefulEquipment
    {
        Estado_equipo Estado { get; }
        /// <summary>
        /// Reemplazo de void por Result
        /// </summary>
        /// <returns></returns>
        Result GetintoFault();
        /// <summary>
        /// Result se utiliza para el Patrón Resulatdo
        /// </summary>
        /// <returns></returns>
        Result GetoutFault();

    }
}