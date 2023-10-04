using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_cd.Domains
{
    [Table("Clinica")]
    [Index(nameof(CNPJ), IsUnique = true)]
    public class Clinica
    {
        [Key]
        public Guid IdClinica { get; set; } = Guid.NewGuid();

        [Column(TypeName ="VARCHAR(256)")]
        [Required(ErrorMessage ="Descricao obrigatoria")]
        public string? Endereco { get; set; }
        
        [Column(TypeName ="TIME")]
        [Required(ErrorMessage ="Horario de funcionamento obrigatoria")]
        public TimeSpan HoraFuncionamento  { get; set; }
        
        [Column(TypeName ="TIME")]
        [Required(ErrorMessage ="Horario de fechamento obrigatoria")]
        public TimeSpan HoraFechamento { get; set; }

        [Column(TypeName = "CHAR(14)")]
        [Required(ErrorMessage = "CNPJ obrigatorio")]
        public string? CNPJ { get; set; }
        
        [Column(TypeName = "VARCHAR(30)")]
        [Required(ErrorMessage = "Nome Fantasia obrigatorio")]
        public string? NomeFantasia { get; set; }
        
        [Column(TypeName = "VARCHAR(40)")]
        [Required(ErrorMessage = "Razao Social obrigatorio")]
        public string? RazaoSocial { get; set; }


    }
}
