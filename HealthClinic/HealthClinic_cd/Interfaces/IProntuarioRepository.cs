using HealthClinic_cd.Domains;

namespace HealthClinic_cd.Interfaces
{
    public interface IProntuarioRepository
    {
        void Cadastrar(Prontuario prontuario);

        Prontuario BuscarPorIdConsulta(Guid id);

        void Atualizar(Guid id, Prontuario prontuario); 
    }
}
