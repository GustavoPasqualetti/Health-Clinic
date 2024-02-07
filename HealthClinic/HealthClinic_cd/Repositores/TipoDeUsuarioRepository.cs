using HealthClinic_cd.Context;
using HealthClinic_cd.Domains;
using HealthClinic_cd.Interfaces;

namespace HealthClinic_cd.Repositores
{
    public class TipoDeUsuarioRepository : ITipoDeUsuarioRepository
    {
        private readonly HealthClinicContext _healthClinicContext;

        public TipoDeUsuarioRepository()
        {
            _healthClinicContext = new HealthClinicContext();
        }

        public void Cadastrar(TipoDeUsuario tipoDeUsuario)
        {
            _healthClinicContext.TipoDeUsuario.Add(tipoDeUsuario);
            _healthClinicContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            TipoDeUsuario buscado = _healthClinicContext.TipoDeUsuario.Find(id);
            _healthClinicContext.Remove(buscado);
            _healthClinicContext.SaveChanges();
        }
    }
}
