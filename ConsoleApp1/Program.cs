using Dominio_Fermentación.Entities;
using Dominio_Fermentación.Types;
using Dominio_Fermentación.ValueObjects;
using Dominio_Fermentación.Persistence.Context;
using Dominio_Fermentación.Persistence.Repositories.Managers;
using Microsoft.EntityFrameworkCore;

namespace Dominio_Fermentación.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext appDbContext = new AppDbContext(
                "User ID =postgres;Password=qwerty;Server=localhost;Port=5432;" +
                "Database=Dominio_Fermentación;Include Error Detail=true;");
            

            AppRepositoryManager repositoryManager = new AppRepositoryManager(appDbContext);

            var unit = new Unidad(Guid.NewGuid(), "Unidad1", UnitIdentificationCode.Create("uni-123").Value!);
            var task = repositoryManager.Unit.AddAsync(unit);
            task.Wait();

            var variableId = Guid.NewGuid();
            task = repositoryManager.Variable.AddAsync(
                new Variable(
                    variableId,
                    unit.Id,
                    "Variable1",
                    new Unidad_de_medida(Variable_medida.temperature, unidades_medida_mostradas.grados_Celsius),
                    new Nodo_Comunicación(1, 2)));
            task.Wait();

            task = repositoryManager.UnitOfWork.SaveChangesAsync(new CancellationToken());

            task.Wait();

            task = repositoryManager.Variable.GetByIdAsync(variableId);

            task.Wait();
        }
    }
}