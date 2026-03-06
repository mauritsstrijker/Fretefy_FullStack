using System;
using System.Collections.Generic;

namespace Fretefy.Test.Application.Dtos
{
    public class RegiaoDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }
        public IEnumerable<CidadeDto> Cidades { get; set; }
    }
}
