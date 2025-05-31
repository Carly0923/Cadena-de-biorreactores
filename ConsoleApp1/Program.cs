﻿using Dominio_Fermentación.Entities;
using Dominio_Fermentación.Types;
using Dominio_Fermentación.ValueObjects;
using Dominio_Fermentación.Persistence.Context;
//using Dominio_Fermentación.Persistence.Repositories.Managers;
using Microsoft.EntityFrameworkCore;

namespace Dominio_Fermentación.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext appDbContext = new AppDbContext(
                "User ID =postgres;Password=qwerty;Server=localhost;Port=5432;" +
                "Database=EquipmentMonitoringDB;Include Error Detail=true;");

            //AppRepositoryManager repositoryManager = new AppRepositoryManager(appDbContext);

            //var unit = new Unit(Guid.NewGuid(), "Unidad1", UnitIdentificationCode.Create("uni-123").Value!);
            //var task = repositoryManager.Unit.AddAsync(unit);
            //task.Wait();

            //var variableId = Guid.NewGuid();
            //task = repositoryManager.Variable.AddAsync(
            //    new Variable(
            //        variableId,
            //        unit.Id,
            //        "Variable1",
            //        new MeasurementUnit(PhysicalMagnitude.Temperature, "°C"),
            //        new CommunicationNode(1, 2)));
            //task.Wait();

            //task = repositoryManager.UnitOfWork.SaveChangesAsync(new CancellationToken());

            //task.Wait();

            //task = repositoryManager.Variable.GetByIdAsync(variableId);

            //task.Wait();
        }
    }
}