using Fretefy.Test.Application.Dtos;
using Fretefy.Test.Domain.Entities;
using System.Linq;

namespace Fretefy.Test.Application.Mappings
{
    public static class RegiaoMapping
    {
        public static RegiaoDto ToDto(this Regiao regiao) => new RegiaoDto
        {
            Id = regiao.Id,
            Nome = regiao.Nome,
            Status = regiao.Status.ToString(),
            Cidades = regiao.Cidades.Select(c => c.ToDto())
        };
    }
}
