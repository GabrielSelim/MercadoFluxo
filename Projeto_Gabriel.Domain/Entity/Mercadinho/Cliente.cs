using Projeto_Gabriel.Domain.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Projeto_Gabriel.Domain.Entity.Mercadinho
{
    [Table("clientes")]
    public class Cliente : BaseEntity
    {
        [Column("nome")]
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Column("cpf")]
        [StringLength(14)]
        public string? Cpf { get; set; }

        [Column("telefone")]
        [StringLength(20)]
        public string? Telefone { get; set; }

        [Column("data_cadastro")]
        public DateTime DataCadastro { get; set; }

        // Navegação: Um cliente pode ter várias vendas
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}