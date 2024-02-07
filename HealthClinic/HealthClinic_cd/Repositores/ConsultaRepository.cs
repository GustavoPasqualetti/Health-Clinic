using HealthClinic_cd.Context;
using HealthClinic_cd.Domains;
using HealthClinic_cd.Interfaces;

namespace HealthClinic_cd.Repositores
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly HealthClinicContext _healthClinicContext;

        public ConsultaRepository()
        {
            _healthClinicContext = new HealthClinicContext();
        }

        public void Atualizar(Consulta consulta, Guid id)
        {
            Consulta consultaBuscada = _healthClinicContext.Consulta.Find(id);
            if (consultaBuscada != null)
            {
                consultaBuscada.IdMedico = consulta.IdMedico;
                consultaBuscada.IdPaciente = consulta.IdPaciente;
                consultaBuscada.DataConsulta= consulta.DataConsulta;
                consultaBuscada.HorarioConsulta = consulta.HorarioConsulta;
                consultaBuscada.Descricao = consulta.Descricao;
            }
            _healthClinicContext.Consulta.Update(consultaBuscada);
            _healthClinicContext.SaveChanges();
        }

        public List<Consulta> BucarIdPaciente(Guid id)
        {
            return _healthClinicContext.Consulta.Where(u => u.IdPaciente == id).ToList();
        }

        public List<Consulta> BuscarIdMedico(Guid id)
        {
            return _healthClinicContext.Consulta.Where(u => u.IdMedico == id).ToList();
        }

        public Consulta BuscarPorId(Guid id)
        {
            return _healthClinicContext.Consulta.FirstOrDefault(c => c.IdConsulta == id);
        }

        public void Cadastar(Consulta consulta)
        {
            _healthClinicContext.Consulta.Add(consulta);   
            _healthClinicContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Consulta buscado = _healthClinicContext.Consulta.FirstOrDefault(c => c.IdConsulta == id);

            _healthClinicContext.Remove(buscado);

            _healthClinicContext.SaveChanges();
        }

        public List<Consulta> Listar()
        {
            return _healthClinicContext.Consulta.ToList();
        }


    }
}
