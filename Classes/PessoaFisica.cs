using Cadastro_Pessoa.Interfaces;

namespace Cadastro_Pessoa.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set; }
        public DateTime ?dataNascimento { get; set; }
        
        
        
        
        public bool validarDataNascimento(DateTime dataNascimento)
        {
            throw new NotImplementedException();
        }
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}