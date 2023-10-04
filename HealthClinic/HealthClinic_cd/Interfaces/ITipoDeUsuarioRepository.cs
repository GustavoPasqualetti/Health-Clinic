using HealthClinic_cd.Domains;

namespace HealthClinic_cd.Interfaces
{
    public interface ITipoDeUsuarioRepository
    {
        void Cadastrar(TipoDeUsuario tipoDeUsuario);

        void Deletar(Guid id);
    }
}
