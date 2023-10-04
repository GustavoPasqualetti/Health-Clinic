using HealthClinic_cd.Domains;

namespace HealthClinic_cd.Interfaces
{
    public interface IClinicaRepository
    {
        void Cadastrar(Clinica clinica);

        List<Clinica> Listar();

        void Atualizar(Clinica clinica, Guid id);

        void Deletar(Guid id);
    }
}
