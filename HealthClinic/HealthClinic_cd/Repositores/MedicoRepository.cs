using HealthClinic_cd.Context;
using HealthClinic_cd.Domains;
using HealthClinic_cd.Interfaces;

namespace HealthClinic_cd.Repositores
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly HealthClinicContext _healthClinicContext;

        public MedicoRepository()
        {
            _healthClinicContext = new HealthClinicContext();
        }


        public Medico BuscarPorId(Guid id)
        {
            return _healthClinicContext.Medico.FirstOrDefault(m => m.IdMedico == id);
        }

        public void Cadastrar(Medico medico)
        {
            _healthClinicContext.Medico.Add(medico);
            _healthClinicContext.SaveChanges(true);
        }

        public void Deletar(Guid id)
        {
            Medico buscado = _healthClinicContext.Medico.Find(id);
            _healthClinicContext.Remove(buscado);
            _healthClinicContext.SaveChanges();
        }

        public List<Medico> Listar()
        {
            return _healthClinicContext.Medico.ToList();
        }
    }
}
