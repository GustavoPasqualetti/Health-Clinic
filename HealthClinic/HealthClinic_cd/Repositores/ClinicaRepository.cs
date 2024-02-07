using HealthClinic_cd.Context;
using HealthClinic_cd.Domains;
using HealthClinic_cd.Interfaces;

namespace HealthClinic_cd.Repositores
{
    public class ClinicaRepository : IClinicaRepository
    {
        private readonly HealthClinicContext _healthClinicContext;
        
        public ClinicaRepository()
        {
            _healthClinicContext= new HealthClinicContext();
        }

        public void Atualizar(Clinica clinica, Guid id)
        {
            Clinica buscado = _healthClinicContext.Clinica.Find(id);
            if (buscado == null)
            {
                buscado.Endereco = clinica.Endereco;
                buscado.HoraFuncionamento = clinica.HoraFuncionamento;
                buscado.HoraFechamento = clinica.HoraFechamento;
                buscado.CNPJ = clinica.CNPJ;
                buscado.NomeFantasia = clinica.NomeFantasia;
                buscado.RazaoSocial = clinica.RazaoSocial; 
            }
            _healthClinicContext.Clinica.Update(buscado);
            _healthClinicContext.SaveChanges();
        }

        public void Cadastrar(Clinica clinica)
        {
            _healthClinicContext.Clinica.Add(clinica);

            _healthClinicContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Clinica clinica = _healthClinicContext.Clinica.FirstOrDefault(c => c.IdClinica == id);

            _healthClinicContext.Clinica.Remove(clinica);

            _healthClinicContext.SaveChanges();
        }

        public List<Clinica> Listar()
        {
            return _healthClinicContext.Clinica.ToList();
        }
    }
}
