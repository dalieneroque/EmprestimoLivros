using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmprestimoLivros.API.Models
{
    public class Livro
    {
        public Livro() => LivroClienteEmprestimos = new HashSet<LivroClienteEmprestimo>();

        [Key]
        [Column("livroId")]
        public int LivroId { get; set; }

        [Required]
        [Column("livroNome")]
        [StringLength(50)]
        public string LivroNome { get; set; }

        [Required]
        [Column("livroAutor")]
        [StringLength(200)]
        public int LivroAutor { get; set; }

        [Required]
        [Column("livroEditora")]
        [StringLength(100)]
        public string LivroEditora { get; set; }

        [Column("livroAnoPublicacao", TypeName = "datetime")]
        public DateTime LivroAnoPublicacao { get; set; }

        [Required]
        [Column("livroEdicao")]
        [StringLength(50)]
        public int LivroEdicao { get; set; }

        [InverseProperty("LceIdLivroNavigation")]
        public ICollection<LivroClienteEmprestimo> LivroClienteEmprestimos { get; set; }




    }
}
