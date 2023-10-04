using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_cd.Domains
{
    [Table(nameof(Medico))]
    [Index(nameof(Crm), IsUnique = true)]
    public class Medico
    {
        [Key]
        public Guid IdMedico { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Clinica obrigatorio")]
        public Guid IdClinica { get; set; } 

        [ForeignKey(nameof(IdClinica))]
        public Clinica? Clinica { get; set; }

        [Required(ErrorMessage = "Especialidade obrigatorio")]
        public Guid IdEspecialidade { get; set; } 

        [ForeignKey(nameof(IdEspecialidade))]
        public Especialidade? Especialidade { get; set; }

        [Required(ErrorMessage = "Usuario obrigatorio")]
        public Guid IdUsuario { get; set; } 

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        [Required(ErrorMessage = "Nome obrigatorio")]
        public string Nome { get; set; } 

        [Column(TypeName = "CHAR(8)")]
        [Required(ErrorMessage = "CRM obrigatorio")]
        public string Crm { get; set; } 
    }
}
