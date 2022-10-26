using Microsoft.AspNetCore.Mvc;
using Minicurso_venda.API.Models;

namespace Minicurso_venda.API.Controllers
{
    //herança POO
    public class Venda_controller : ControllerBase
    {
        [HttpPost("incluir")]
       public IActionResult incluir(venda venda)
        {
            return Ok();
        }
        [HttpPatch("cancelar_venda")]
        public IActionResult cancelar_venda(venda venda)
        {
            return Ok();

        }
        [HttpGet("Buscar_vendas")]
        public IActionResult Buscar_vendas(venda venda)
        {
            return Ok();

        }
    }
}
