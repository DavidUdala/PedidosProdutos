using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PedidosProdutos.Dominio.Entidades
{
    public class Produto(string nomeProduto, decimal valor)
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string NomeProduto { get; set; } = nomeProduto;
        [Column(TypeName = "decimal(10,2)")]
        public decimal Valor { get; set; } = valor;
        [JsonIgnore]
        public virtual ICollection<ItensPedido>? ItensPedidos { get; set; }
    }
}
