using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmprestimoLivros.API.Models
{
    [Table("LivroClienteEmprestimo")]
    public class LivroClienteEmprestimo
    {

        [Key]
        [Column("LceId")]
        public int LceId { get; set; }   
        public int LceIdCliente { get; set; }
        public int LceIdLivro { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LceDataEmprestimo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LceDataEntrega { get; set; }

        [ForeignKey(nameof(LceIdCliente))]
        [InverseProperty(nameof(Cliente.LivrosClientesEmprestimos))]

        public virtual Cliente LceIdClienteEmprestimo { get; set; }
        [ForeignKey(nameof(LceIdLivro))]
        [InverseProperty(nameof(Livro.LivroClienteEmprestimos))]

        public virtual Livro LceIdLivroNavigation { get; set; }
    }
}
