using Projeto_Gabriel.Domain.Entity.Base;
using Projeto_Gabriel.Domain.Entity.Enum.Mercadinho;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Projeto_Gabriel.Domain.Entity.Mercadinho
{
    [Table("vendas")]
    public class Venda : BaseEntity
    {
        [Column("data_hora")]
        [Required]
        public DateTime DataHora { get; set; }

        [Column("valor_total", TypeName = "decimal(10, 2)")]
        public decimal ValorTotal { get; set; }

        [Column("desconto", TypeName = "decimal(10, 2)")]
        public decimal Desconto { get; set; }

        [Column("valor_final", TypeName = "decimal(10, 2)")]
        public decimal ValorFinal { get; set; }

        [Column("status")]
        public EStatusVenda Status { get; set; }

        // Chaves Estrangeiras
        [Column("id_usuario")]
        public long IdUsuario { get; set; }

        [Column("id_cliente")]
        public long? IdCliente { get; set; } // Pode ser nulo para venda anônima

        [Column("id_caixa")]
        public long IdCaixa { get; set; }

        // Propriedades de Navegação
        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        [ForeignKey("IdCliente")]
        public virtual Cliente? Cliente { get; set; }

        [ForeignKey("IdCaixa")]
        public virtual Caixa Caixa { get; set; }

        public virtual ICollection<ItemVenda> ItensVenda { get; set; }
    }
}