using HealthClinic_cd.Domains;

namespace HealthClinic_cd.Interfaces
{
    public interface IComentarioRepository
    {
        void Cadastrar(Comentario comentario);

        List<Comentario> BuscarPorIdConsulta(Guid id);

        void Atualizar(Comentario comentario, Guid id);
    }
}
