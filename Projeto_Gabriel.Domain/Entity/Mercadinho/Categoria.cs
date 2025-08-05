using Projeto_Gabriel.Domain.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Projeto_Gabriel.Domain.Entity.Mercadinho
{
    [Table("categorias")]
    public class Categoria : BaseEntity
    {
        [Column("nome")]
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        // Navegação: Uma categoria pode ter vários produtos
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}