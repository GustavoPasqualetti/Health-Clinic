using HealthClinic_cd.Domains;

namespace HealthClinic_cd.Interfaces
{
    public interface IEspecialidadeRepository
    {
        void Cadastrar(Especialidade especialidade);

        void Deletar(Guid id);

        List<Especialidade> Listar();
    }
}
