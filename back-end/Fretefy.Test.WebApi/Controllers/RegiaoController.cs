using Fretefy.Test.Application.Dtos;
using Fretefy.Test.Application.Interfaces;
using Fretefy.Test.WebApi.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/regiao")]
    [ApiController]
    [Authorize]
    public class RegiaoController : ControllerBase
    {
        private readonly IRegiaoService _regiaoService;
        private readonly IRegiaoExportService _regiaoExportService;

        public RegiaoController(IRegiaoService regiaoService, IRegiaoExportService regiaoExportService)
        {
            _regiaoService = regiaoService;
            _regiaoExportService = regiaoExportService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegiaoDto>>> List()
        {
            var regioes = await _regiaoService.ListAsync();
            return Ok(regioes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RegiaoDto>> Get(Guid id)
        {
            var regiao = await _regiaoService.GetByIdAsync(id);
            if (regiao == null)
                return NotFound();

            return Ok(regiao);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateRegiaoRequest request)
        {
            var regiao = await _regiaoService.CreateAsync(request.Name, request.CityIds);
            return StatusCode(201, new { regiao.Id });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateRegiaoRequest request)
        {
            await _regiaoService.UpdateAsync(id, request.Name, request.CityIds);
            return Ok();
        }

        [HttpPut("{id}/activate")]
        public async Task<IActionResult> Activate(Guid id)
        {
            await _regiaoService.ActivateAsync(id);
            return Ok();
        }

        [HttpPut("{id}/deactivate")]
        public async Task<IActionResult> Deactivate(Guid id)
        {
            await _regiaoService.DeactivateAsync(id);
            return Ok();
        }

        [HttpGet("exists-by-name")]
        public async Task<IActionResult> ExistsByName([FromQuery] string name)
        {
            var exists = await _regiaoService.ExistsByNameAsync(name);
            return Ok(new { exists });
        }

        [HttpGet("export")]
        public async Task<IActionResult> Export()
        {
            var bytes = await _regiaoExportService.ExportAsync();
            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "regioes.xlsx");
        }
    }
}