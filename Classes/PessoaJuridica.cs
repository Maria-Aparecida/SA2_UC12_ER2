using Cadastro_Pessoa.Interfaces;

namespace Cadastro_Pessoa.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string ?cnpj { get; set; }
        public string ?razaoSocial { get; set; }
        
        
        
        

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool validarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}