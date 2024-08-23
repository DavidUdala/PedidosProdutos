﻿namespace PedidosProdutos.Dominio.Dtos.Responses
{
    public record PedidoResponse()
    {
        public int? Id { get; set; }
        public string? NomeCliente { get; set; }
        public string? EmailCliente { get; set; }
        public bool? Pago { get; set; }
        public decimal? ValorTotal { get; set; }
        public List<ItemPedidoResponse>? ItensPedido { get; set; }
    }
}
