using HealthClinic_cd.Domains;
using Microsoft.EntityFrameworkCore;

namespace HealthClinic_cd.Context
{
    public class HealthClinicContext : DbContext
    {
        public DbSet<Clinica> Clinica { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<Especialidade> Especialidade { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Prontuario> Prontuario { get; set; }
        public DbSet<TipoDeUsuario> TipoDeUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= NOTE02-S14; Database= HealthClinic_cd; User Id=sa; pwd=Senai@134 ; TrustServerCertificate=True;" );
            base.OnConfiguring(optionsBuilder);
        }
    }
}
