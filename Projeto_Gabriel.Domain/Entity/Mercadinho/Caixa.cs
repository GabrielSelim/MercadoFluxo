using Projeto_Gabriel.Domain.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Projeto_Gabriel.Domain.Entity.Mercadinho
{
    [Table("caixas")]
    public class Caixa : BaseEntity
    {
        [Column("numero")]
        [Required]
        public int Numero { get; set; }

        [Column("descricao")]
        [Required]
        [StringLength(100)]
        public string Descricao { get; set; }

        // Navegação: Um caixa tem várias movimentações e vendas
        public virtual ICollection<MovimentacaoCaixa> Movimentacoes { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}