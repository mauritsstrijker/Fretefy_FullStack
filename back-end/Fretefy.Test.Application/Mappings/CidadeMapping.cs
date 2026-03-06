using Fretefy.Test.Application.Dtos;
using Fretefy.Test.Domain.Entities;

namespace Fretefy.Test.Application.Mappings
{
    public static class CidadeMapping
    {
        public static CidadeDto ToDto(this Cidade cidade) => new CidadeDto
        {
            Id = cidade.Id,
            Nome = cidade.Nome,
            UF = cidade.UF,
            Latitude = cidade.Latitude,
            Longitude = cidade.Longitude
        };
    }
}
