using Projeto_Gabriel.Domain.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Projeto_Gabriel.Domain.Entity.Mercadinho
{
    [Table("fornecedores")]
    public class Fornecedor : BaseEntity
    {
        [Column("nome_fantasia")]
        [Required]
        [StringLength(100)]
        public string NomeFantasia { get; set; }

        [Column("razao_social")]
        [StringLength(100)]
        public string? RazaoSocial { get; set; }

        [Column("cnpj")]
        [StringLength(18)]
        public string? Cnpj { get; set; }

        [Column("telefone")]
        [StringLength(20)]
        public string? Telefone { get; set; }

        [Column("email")]
        [StringLength(100)]
        public string? Email { get; set; }

        // Navegação: Um fornecedor pode fornecer vários produtos
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}