using HealthClinic_cd.Context;
using HealthClinic_cd.Domains;
using HealthClinic_cd.Interfaces;

namespace HealthClinic_cd.Repositores
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly HealthClinicContext _healthClinicContext;

        public PacienteRepository()
        {
            _healthClinicContext = new HealthClinicContext();
        }

        public Paciente BuscarPorId(Guid id)
        {
            return _healthClinicContext.Paciente.FirstOrDefault(p => p.IdPaciente == id);
        }

        public void Cadastrar(Paciente paciente)
        {
            _healthClinicContext.Paciente.Add(paciente);
            _healthClinicContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Paciente buscado = _healthClinicContext.Paciente.FirstOrDefault(p => p.IdPaciente == id);
            _healthClinicContext.Remove(buscado);
            _healthClinicContext.SaveChanges();
        }

        public List<Paciente> Listar()
        {
            return _healthClinicContext.Paciente.ToList();
        }
    }
}
