using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_cd.Domains
{
    [Table(nameof(Comentario))]
    public class Comentario
    {
        [Key]
        public Guid IdComentario { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage ="Consulta obrigatoria")]
        public Guid IdConsulta { get; set; } 

        [ForeignKey(nameof(IdConsulta))]
        public Consulta? Consulta { get; set; }

        [Column(TypeName = "VARCHAR(256)")]
        [Required(ErrorMessage ="Comentario obrigatorio")]
        public string Comentarios { get; set; }
    }
}
