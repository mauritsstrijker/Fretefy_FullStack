using Fretefy.Test.Application.Dtos;
using Fretefy.Test.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/cidade")]
    [ApiController]
    [Authorize]
    public class CidadeController : ControllerBase
    {
        private readonly ICidadeService _cidadeService;

        public CidadeController(ICidadeService cidadeService)
        {
            _cidadeService = cidadeService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CidadeDto>>> List([FromQuery] string uf, [FromQuery] string terms)
        {
            IEnumerable<CidadeDto> cidades;

            if (!string.IsNullOrEmpty(terms))
                cidades = await _cidadeService.QueryAsync(terms);
            else if (!string.IsNullOrEmpty(uf))
                cidades = await _cidadeService.ListByUfAsync(uf);
            else
                cidades = await _cidadeService.ListAsync();

            return Ok(cidades);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CidadeDto>> Get(Guid id)
        {
            var cidade = await _cidadeService.GetAsync(id);
            return Ok(cidade);
        }
    }
}
