using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros.API.Context
{
    public class ControleEmprestimoLivroContext : DbContext
    {
        public ControleEmprestimoLivroContext(DbContextOptions<ControleEmprestimoLivroContext> options) 
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<LivroClienteEmprestimo> LivrosClientesEmprestimos { get; set; }
        public DbSet<VwLivroClienteEmprestimo> VwLivrosClientesEmprestimos { get; set; }

    }
}
