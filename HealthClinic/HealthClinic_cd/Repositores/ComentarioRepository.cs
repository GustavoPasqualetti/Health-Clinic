using HealthClinic_cd.Context;
using HealthClinic_cd.Domains;
using HealthClinic_cd.Interfaces;

namespace HealthClinic_cd.Repositores
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly HealthClinicContext _healthClinicContext;

        public ComentarioRepository()
        {
            _healthClinicContext = new HealthClinicContext();
        }

        public void Atualizar(Comentario comentario, Guid id)
        {
            Comentario buscado = _healthClinicContext.Comentario.Find(id)!;
            if (buscado != null)
            {
                buscado.Comentarios = comentario.Comentarios;
            }
            _healthClinicContext.Comentario.Update(buscado);
            _healthClinicContext.SaveChanges();
        }

        public List<Comentario> BuscarPorIdConsulta(Guid id)
        {
            return _healthClinicContext.Comentario.Where(c => c.IdConsulta == id).ToList();

            //Comentario comentarioBuscado = _healthClinicContext.Comentario.FirstOrDefault(p => p.IdConsulta == id)!;
            //if (comentarioBuscado != null)
            //{
            //    return comentarioBuscado;
            //}
            //return null;
        }

        public void Cadastrar(Comentario comentario)
        {
            _healthClinicContext.Comentario.Add(comentario);
            _healthClinicContext.SaveChanges();
        }

    }
}
