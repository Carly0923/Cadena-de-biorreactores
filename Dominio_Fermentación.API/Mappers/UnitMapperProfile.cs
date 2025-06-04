using Dominio_Fermentación.GrpcProtos;

namespace Dominio_Fermentación.API.Mappers
{
    public static class UnitMapperProfile
    {
        // Conversión de Unit a UnitDTO
        public static UnitDTO Map(this Dominio_Fermentación.Entities.Fermentador unit) 
        {
            return new UnitDTO()
            {
                Id = unit.ID_Fermentador.ToString(),
                Name = unit.Volumen,
                Code = unit.Etapa_Fermentador,
            };
        }

        public static UnitsDTO Map(this IEnumerable<Dominio_Fermentación.Entities.Fermentador> list)
        {
            var dto = new UnitsDTO();
            dto.Items.AddRange(list.Select(u => u.Map()));
            return dto;
        }
    }
}
