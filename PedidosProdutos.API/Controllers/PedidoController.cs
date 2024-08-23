using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PedidosProdutos.Dominio.Dtos.Requests;
using PedidosProdutos.Dominio.Dtos.Responses;
using PedidosProdutos.Dominio.Entidades;
using PedidosProdutos.Dominio.Interfaces;

namespace PedidosProdutos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController(IPedidoRepositorio pedidoRepositorio, IMapper mapper) : ControllerBase
    {

        private readonly IPedidoRepositorio pedidoRepositorio = pedidoRepositorio;
        private readonly IMapper mapper = mapper;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var pedidos = await pedidoRepositorio.GetAllAsync();

            var result = mapper.Map<List<PedidoResponse>>(pedidos);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var pedido = await pedidoRepositorio.GetByIdAsync(id);
            if (pedido == null)
                return NotFound();
            var result = mapper.Map<PedidoResponse>(pedido);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PedidoRequest pedidoRequest)
        {
            var pedido = mapper.Map<Pedido>(pedidoRequest);

            await pedidoRepositorio.AddAsync(pedido);

            var responseDto = mapper.Map<PedidoResponse>(pedido);
            return Ok(responseDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Pedido pedido)
        {
            if (id != pedido.Id)
                return BadRequest();

            await pedidoRepositorio.UpdateAsync(pedido);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await pedidoRepositorio.DeleteAsync(id);
            return NoContent();
        }
    }
}
