using HealthClinic_cd.Context;
using HealthClinic_cd.Domains;
using HealthClinic_cd.Interfaces;

namespace HealthClinic_cd.Repositores
{
    public class ProntuarioRepository : IProntuarioRepository
    {
        private readonly HealthClinicContext _healthClinicContext;

        public ProntuarioRepository()
        {
            _healthClinicContext = new HealthClinicContext();
        }

        public void Atualizar(Guid id, Prontuario prontuario)
        {
            Prontuario buscado = _healthClinicContext.Prontuario.Find(id)!;
            if (buscado != null)
            {
                buscado.DescricaoProntuario = prontuario.DescricaoProntuario;
            }
            _healthClinicContext.Prontuario.Update(buscado);
            _healthClinicContext.SaveChanges();
        }

        public Prontuario BuscarPorIdConsulta(Guid id)
        {
            Prontuario prontuarioBuscado = _healthClinicContext.Prontuario.FirstOrDefault(p => p.IdConsulta == id)!;
            if (prontuarioBuscado != null)
            {
                return prontuarioBuscado;
            }
            return null;
        }

        public void Cadastrar(Prontuario prontuario)
        {
            _healthClinicContext.Prontuario.Add(prontuario);
            _healthClinicContext.SaveChanges();
        }


    }
}
