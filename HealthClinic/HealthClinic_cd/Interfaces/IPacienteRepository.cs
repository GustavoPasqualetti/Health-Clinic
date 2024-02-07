using HealthClinic_cd.Domains;

namespace HealthClinic_cd.Interfaces
{
    public interface IPacienteRepository
    {
        void Cadastrar(Paciente paciente);

        List<Paciente> Listar();

        void Deletar(Guid id);

        Paciente BuscarPorId(Guid id);
    }
}
