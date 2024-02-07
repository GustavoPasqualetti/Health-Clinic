using HealthClinic_cd.Context;
using HealthClinic_cd.Domains;
using HealthClinic_cd.Interfaces;

namespace HealthClinic_cd.Repositores
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        private readonly HealthClinicContext _healthClinicContext;

        public EspecialidadeRepository()
        {
            _healthClinicContext = new HealthClinicContext();
        }

        public List<Especialidade> Listar()
        {
            return _healthClinicContext.Especialidade.ToList();

        }

        void IEspecialidadeRepository.Cadastrar(Especialidade especialidade)
        {
            _healthClinicContext.Especialidade.Add(especialidade);
            _healthClinicContext.SaveChanges();
        }

        void IEspecialidadeRepository.Deletar(Guid id)
        {
            Especialidade buscada = _healthClinicContext.Especialidade.FirstOrDefault(e => e.IdEspecialidade== id);
            _healthClinicContext.Remove(buscada);
            _healthClinicContext.SaveChanges();
        }
    }
}
