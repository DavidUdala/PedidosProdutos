using Microsoft.AspNetCore.Mvc;

namespace PedidosProdutos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Listar() { 
            return Ok();    
        }
    }
}
