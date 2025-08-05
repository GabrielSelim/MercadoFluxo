using Projeto_Gabriel.Domain.Entity.Base;
using Projeto_Gabriel.Domain.Entity.Enum.Mercadinho;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Projeto_Gabriel.Domain.Entity.Mercadinho
{
    [Table("movimentacoes_caixa")]
    public class MovimentacaoCaixa : BaseEntity
    {
        [Column("data_hora")]
        [Required]
        public DateTime DataHora { get; set; }

        [Column("tipo")]
        [Required]
        public ETipoMovimentacaoCaixa Tipo { get; set; }

        [Column("valor", TypeName = "decimal(10, 2)")]
        [Required]
        public decimal Valor { get; set; }

        [Column("observacao")]
        [StringLength(255)]
        public string? Observacao { get; set; }

        // Chaves Estrangeiras
        [Column("id_caixa")]
        public long IdCaixa { get; set; }

        [Column("id_usuario")]
        public long IdUsuario { get; set; }

        // Propriedades de Navegação
        [ForeignKey("IdCaixa")]
        public virtual Caixa Caixa { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }
    }
}