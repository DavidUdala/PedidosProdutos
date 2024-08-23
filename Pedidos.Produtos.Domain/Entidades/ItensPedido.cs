using System.Text.Json.Serialization;

namespace PedidosProdutos.Dominio.Entidades
{
    public class ItensPedido
    {
        public ItensPedido()
        {
            
        }

        public int Id { get; set; }
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        [JsonIgnore]
        public virtual Pedido? Pedido { get; set; }
        [JsonIgnore]
        public virtual Produto? Produto { get; set; }
    }
}
