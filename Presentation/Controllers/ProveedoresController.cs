using Application.Dtos;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedoresController : ControllerBase
    {
        private readonly ProveedorService _proveedorService;

        public ProveedoresController(ProveedorService proveedorService)
        {
            _proveedorService = proveedorService;
        }

        [HttpGet]
        public async Task<ActionResult> ListarProveedor()
        {
            var oProveedor = await _proveedorService.ListarProveedor();
            return Ok(oProveedor);
        }

        [HttpPost]
        public async Task<ActionResult> NuevoProveedor([FromBody]ProveedorDto oproveedorDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(oproveedorDto);
            }
            
            await _proveedorService.NuevoProveedor(oproveedorDto);
            return Ok();
            
        }

        [HttpPut]
        public async Task<ActionResult> EditarProveedor([FromBody]ProveedorDto proveedorDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(proveedorDto);
            }
            await _proveedorService.EditarProveedor(proveedorDto);
            return Ok();
        }

    }
}
