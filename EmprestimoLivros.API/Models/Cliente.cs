using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmprestimoLivros.API.Models
{
    public class Cliente
    {
        [Key]
        [Column("cliente_id")]
        public int ClienteId { get; set; }

        [Required]
        [Column("clienteCPF")]
        [StringLength(14)]
        public string ClienteCPF { get; set; }

        [Required]
        [Column("clienteNome")]
        [StringLength(200)]
        public string ClienteNome { get; set; }

        [Required]
        [Column("clienteEndereco")]
        [StringLength(200)]
        public string ClienteEndereco { get; set; }

        [Required]
        [Column("clienteCidade")]
        [StringLength(100)]
        public string ClienteCidade { get; set; }

        [Required]
        [Column("clienteBairro")]
        [StringLength(100)]
        public string ClienteBairro { get; set; }

        [Required]
        [Column("clienteNumero")]
        public int ClienteNumero { get; set; }

        [Required]
        [Column("clienteTelefoneCelular")]
        [StringLength(14)]
        public string ClienteTelefoneCelular { get; set; }

        [Required]
        [Column("clienteTelefoneFixo")]
        [StringLength(14)]
        public string ClienteTelefoneFixo { get; set; }

        [InverseProperty("LceIdClienteEmprestimo")]
        public ICollection<LivroClienteEmprestimo> LivrosClientesEmprestimos { get; set; }

    }
}
