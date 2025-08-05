using Projeto_Gabriel.Domain.Entity.Base;
using Projeto_Gabriel.Domain.Entity.Enum.Mercadinho;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Projeto_Gabriel.Domain.Entity.Mercadinho
{
    [Table("produtos")]
    public class Produto : BaseEntity
    {
        [Column("nome")]
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Column("descricao")]
        [StringLength(255)]
        public string? Descricao { get; set; }

        [Column("codigo_barras")]
        [Required]
        [StringLength(50)]
        public string CodigoBarras { get; set; }

        [Column("preco_custo", TypeName = "decimal(10, 2)")]
        public decimal PrecoCusto { get; set; }

        [Column("preco_venda", TypeName = "decimal(10, 2)")]
        [Required]
        public decimal PrecoVenda { get; set; }

        [Column("unidade_medida")]
        [Required]
        public EUnidadeMedida UnidadeMedida { get; set; }

        [Column("quantidade_estoque")]
        public int QuantidadeEstoque { get; set; }

        [Column("estoque_minimo")]
        public int EstoqueMinimo { get; set; }

        [Column("data_validade")]
        public DateTime? DataValidade { get; set; }

        [Column("ativo")]
        public bool Ativo { get; set; } = true;

        // Chaves Estrangeiras
        [Column("id_categoria")]
        public long IdCategoria { get; set; }

        [Column("id_fornecedor")]
        public long IdFornecedor { get; set; }

        // Propriedades de Navegação (para o EF Core)
        [ForeignKey("IdCategoria")]
        public virtual Categoria Categoria { get; set; }

        [ForeignKey("IdFornecedor")]
        public virtual Fornecedor Fornecedor { get; set; }
    }
}