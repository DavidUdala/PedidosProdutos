namespace PedidosProdutos.Dominio.Dtos.Requests
{
    public record PedidoRequest()
    {
        public string? NomeCliente { get; set; }
        public string? EmailCliente { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public bool Pago { get; set; }
        public List<ItemPedidoRequest>? ItensPedidos { get; set; }
    };
}
