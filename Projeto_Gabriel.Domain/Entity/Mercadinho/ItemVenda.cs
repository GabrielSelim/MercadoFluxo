using Projeto_Gabriel.Domain.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Projeto_Gabriel.Domain.Entity.Mercadinho
{
    [Table("itens_venda")]
    public class ItemVenda : BaseEntity
    {
        [Column("quantidade")]
        [Required]
        public int Quantidade { get; set; }

        [Column("preco_unitario_momento", TypeName = "decimal(10, 2)")]
        [Required]
        public decimal PrecoUnitarioMomento { get; set; }

        [Column("subtotal", TypeName = "decimal(10, 2)")]
        public decimal Subtotal { get; set; }

        // Chaves Estrangeiras
        [Column("id_venda")]
        public long IdVenda { get; set; }

        [Column("id_produto")]
        public long IdProduto { get; set; }

        // Propriedades de Navegação
        [ForeignKey("IdVenda")]
        public virtual Venda Venda { get; set; }

        [ForeignKey("IdProduto")]
        public virtual Produto Produto { get; set; }
    }
}