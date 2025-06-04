﻿using Dominio_Fermentación.Application.Common;
using Dominio_Fermentación.Entities;
using Dominio_Fermentación.ValueObjects;
using FluentResults;

namespace EquipmentMonitoring.Application.Commands.Units.CreateUnit
{
    public class CreateUnitCommandHandler
        : ICommandHandler<CreateUnitCommand>
    {
        private readonly IAppRepositoryManager _repositoryManager;

        public CreateUnitCommandHandler(
            IAppRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<Result> Handle(
            CreateUnitCommand request, 
            CancellationToken cancellationToken)
        {
            var codeResult = UnitIdentificationCode.Create(request.Code);
            if (codeResult.IsFailed)
                return codeResult.ToResult();

            Unit unit = new Unit(
                Guid.NewGuid(),
                request.Name,
                codeResult.Value);

            await _repositoryManager.Unit.AddAsync(unit);
            await _repositoryManager.UnitOfWork
                .SaveChangesAsync(cancellationToken);

            return Result.Ok();
        }
    }
}
