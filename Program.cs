// See https://aka.ms/new-console-template for more information
using Cadastro_Pessoa.Classes;

PessoaFisica novaPF = new PessoaFisica();

novaPF.nome = "Cida";

Console.WriteLine("Nome: "+novaPF.nome);
Console.WriteLine($"Nome: {novaPF.nome}");