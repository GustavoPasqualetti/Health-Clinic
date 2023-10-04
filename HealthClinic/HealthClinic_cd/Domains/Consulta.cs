using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_cd.Domains
{
    [Table(nameof(Consulta))]
    public class Consulta
    {
        [Key]
        public Guid IdConsulta { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage ="Medico obrigatorio")]
        public Guid IdMedico { get; set; } 

        [ForeignKey(nameof(IdMedico))]
        public Medico? Medico { get; set; }
        
        [Required(ErrorMessage ="Paciente obrigatorio")]
        public Guid IdPaciente { get; set; } 

        [ForeignKey(nameof(IdPaciente))]
        public Paciente? Paciente { get; set; }


        [Column(TypeName ="DATE")]
        [Required(ErrorMessage ="Data da consulta obrigatoria")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataConsulta { get; set; }

        [Column(TypeName ="TIME")]
        [Required(ErrorMessage ="Horario da consulta obrigatorio")]
        public TimeSpan HorarioConsulta { get; set; }

        [Column(TypeName ="VARCHAR(50)")]
        [Required(ErrorMessage ="Descricao obrigatoria")]
        public string Descricao { get; set; } 
    }
}
