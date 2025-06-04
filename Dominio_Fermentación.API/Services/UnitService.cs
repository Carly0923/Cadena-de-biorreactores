using Dominio_Fermentación.API.Mappers;
using Dominio_Fermentación.Application.Commands.Units.CreateUnit;
using Dominio_Fermentación.Application.Queries;
using Dominio_Fermentación.GrpcProtos;
using FluentResults;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Dominio_Fermentación.API.Services
{
    public class UnitService : GrpcProtos.Unit.UnitBase
    {
        private IMediator _mediator;

        public UnitService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public override async Task<Empty> CreateUnit(UnitCreationDTO request, ServerCallContext context)
        {
            var command = new CreateUnitCommand(
                request.Name,request.Code);

            var result = await _mediator.Send(command);

            if (result.IsFailed)
                throw new RpcException(
                    new Status(StatusCode.InvalidArgument,
                    result.Errors.First().Message));

            return new Empty();
        }

        public override Task<Empty> UpdateUnit(UnitDTO request, ServerCallContext context)
        {
            return base.UpdateUnit(request, context);
        }

        public override async Task<UnitsDTO> GetAllUnits(GetRequestDTO request, ServerCallContext context)
        {
            var query = new GetAllUnitsQuery();

            var result = await _mediator.Send(query);

            if (result.IsFailed)
                throw new RpcException(
                    new Status(StatusCode.InvalidArgument,
                    result.Errors.First().Message));

            return result.Value.Map();
        }

        public override Task<Empty> AddAutomationDeviceToUnit(AutomationDeviceUnitRelationDTO request, ServerCallContext context)
        {
            return base.AddAutomationDeviceToUnit(request, context);
        }

        public override Task<Empty> RemoveAutomationDeviceFromUnit(AutomationDeviceUnitRelationDTO request, ServerCallContext context)
        {
            return base.RemoveAutomationDeviceFromUnit(request, context);
        }

        public override Task<Empty> DeleteUnit(DeleteRequestDTO request, ServerCallContext context)
        {
            return base.DeleteUnit(request, context);
        }
    }
}
