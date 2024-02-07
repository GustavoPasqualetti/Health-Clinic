using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_cd.Domains
{
    [Table(nameof(Prontuario))]
    public class Prontuario
    {
        [Key]
        public Guid IdProntuario { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage ="Consulta obrigatoria")]
        public Guid IdConsulta { get; set; }

        [ForeignKey(nameof(IdConsulta))]
        public Consulta? Consulta { get; set; }

        [Column(TypeName = "VARCHAR(256)")]
        [Required(ErrorMessage ="Descricao obrigatoria")]
        public string DescricaoProntuario { get; set; }
    }
}
