using HealthClinic_cd.Domains;

namespace HealthClinic_cd.Interfaces
{
    public interface IMedicoRepository
    {
        void Cadastrar(Medico medico);

        List<Medico> Listar();

        void Deletar(Guid id);

        Medico BuscarPorId(Guid id);

    }
}
