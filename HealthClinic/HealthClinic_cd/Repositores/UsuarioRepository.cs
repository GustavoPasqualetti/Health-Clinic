using HealthClinic_cd.Context;
using HealthClinic_cd.Domains;
using HealthClinic_cd.Interfaces;
using HealthClinic_cd.Utils;

namespace HealthClinic_cd.Repositores
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly HealthClinicContext _healthClinicContext;

        public UsuarioRepository()
        {
            _healthClinicContext = new HealthClinicContext();
        }

        public void Atualizar(Usuario usuario, Guid id)
        {
            Usuario buscado = _healthClinicContext.Usuario.Find(id);
            if (buscado != null)
            {
                buscado.IdTipoDeUsuario = usuario.IdTipoDeUsuario;
                buscado.Email = usuario.Email;
                buscado.Senha= usuario.Senha;
            }
            _healthClinicContext.Usuario.Update(buscado);
            _healthClinicContext.SaveChanges();
        }

        public Usuario BuscarPorEmaileSenha(string email, string senha)
        {
            try
            {
                Usuario usuarioBuscado = _healthClinicContext.Usuario
                    .Select(u => new Usuario
                    {
                        IdUsuario = u.IdUsuario,
                        Email = u.Email,
                        Senha = u.Senha,
                        TipoDeUsuario = new TipoDeUsuario
                        {
                            IdTipoDeUsuario = u.IdTipoDeUsuario,
                            Titulo = u.TipoDeUsuario!.Titulo
                        }
                    }).FirstOrDefault(u => u.Email == email)!;

                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senha!);

                    if (confere)
                    {
                        return usuarioBuscado;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuario BuscarPorId(Guid id)
        {
            try
            {
                Usuario usuarioBuscado = _healthClinicContext.Usuario.
                    Select(u => new Usuario
                    {
                        IdUsuario = u.IdUsuario,
                        Email = u.Email,
                        TipoDeUsuario = new TipoDeUsuario
                        {
                            IdTipoDeUsuario = u.IdTipoDeUsuario,
                            Titulo = u.TipoDeUsuario.Titulo
                        }
                    }).FirstOrDefault(u => u.IdUsuario == id)!;

                if (usuarioBuscado != null)
                {
                    return usuarioBuscado;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            usuario.Senha = Criptografia.GerarHash(usuario.Senha);
            _healthClinicContext.Usuario.Add(usuario);
            _healthClinicContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Usuario usuarioBuscado = _healthClinicContext.Usuario.FirstOrDefault(u => u.IdUsuario == id);
            _healthClinicContext.Remove(usuarioBuscado);
            _healthClinicContext.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return _healthClinicContext.Usuario.ToList();
        }
    }
}
