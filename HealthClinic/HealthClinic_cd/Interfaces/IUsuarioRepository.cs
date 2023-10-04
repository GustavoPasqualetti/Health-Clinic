using HealthClinic_cd.Domains;

namespace HealthClinic_cd.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);

        List<Usuario> Listar();

        void Atualizar(Usuario usuario, Guid id);

        void Deletar(Guid id);

        Usuario BuscarPorId(Guid id);

        Usuario BuscarPorEmaileSenha(string Email, string Senha);
    }
}
