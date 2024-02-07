using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_cd.Domains
{
    [Table(nameof(Paciente))]
    [Index(nameof(Cpf), IsUnique = true)]
    public class Paciente
    {
        [Key]
        public Guid IdPaciente { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Usuario obrigatorio")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        [Required(ErrorMessage = "Nome obrigatorio")]
        public string Nome { get; set; } 

        [Column(TypeName = "CHAR(11)")]
        [Required(ErrorMessage = "CPF obrigatorio")]
        public string Cpf { get; set; } 

    }
}
