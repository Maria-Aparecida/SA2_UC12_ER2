using Cadastro_Pessoa.Interfaces;

namespace Cadastro_Pessoa.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set; }
        public string ?dataNascimento { get; set; }
        
        
        
        
        public bool validarDataNascimento(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataNascimento).TotalDays/365;
            if(anos>= 18){
                Console.WriteLine($"{dataNascimento}");
                
                return true;
            }
            return false;
            
        }

        
        public bool validarDataNascimento(string dataNascimento)
        {

            DateTime dataConvertida;
            if(DateTime.TryParse(dataNascimento, out dataConvertida)){

                Console.WriteLine($"{dataConvertida}");
                

                 DateTime dataAtual = DateTime.Today;
                double anos = (dataAtual - dataConvertida).TotalDays/365;
            if(anos>= 18){
                return true;
            }
            return false;
            
        }
        return false;


    }


           


        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}