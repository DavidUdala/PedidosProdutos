using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PedidosProdutos.Dominio.Entidades
{
    public class Pedido(bool pago, string nomeCliente, string emailCliente)
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(60)")]
        public string NomeCliente { get; set; } = nomeCliente;
        [Column(TypeName = "varchar(60)")]
        public string EmailCliente { get; set; } = emailCliente;
        [Column(TypeName = "datetime")]
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public bool Pago { get; set; } = pago;
        [JsonIgnore]
        public virtual ICollection<ItensPedido>? ItensPedidos { get; set; }

    }
}
