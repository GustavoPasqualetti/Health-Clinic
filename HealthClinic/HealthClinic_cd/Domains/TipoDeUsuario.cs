using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_cd.Domains
{
    [Table(nameof(TipoDeUsuario))]
    public class TipoDeUsuario
    {
        [Key]
        public Guid IdTipoDeUsuario { get; set; } = Guid.NewGuid();


        [Column(TypeName= "VARCHAR(30)")]
        [Required(ErrorMessage ="Titulo do tipo de usuario obriatorio")]
        public string? Titulo { get; set; } 
    }
}
