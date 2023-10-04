using HealthClinic_cd.Domains;

namespace HealthClinic_cd.Interfaces
{
    public interface IConsultaRepository
    {
        void Cadastar(Consulta consulta);

        List<Consulta> Listar();

        void Atualizar(Consulta consulta, Guid id);

        void Deletar(Guid id);

        Consulta BuscarPorId(Guid id);

        List<Consulta> BucarIdPaciente(Guid id);

        List<Consulta> BuscarIdMedico(Guid id);


    }
}
