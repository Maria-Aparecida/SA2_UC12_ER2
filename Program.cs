// See https://aka.ms/new-console-template for more information
using Cadastro_Pessoa.Classes;
// PessoaFisica metodoPF= new PessoaFisica();

// PessoaFisica novaPF = new PessoaFisica();
// Endereco novoEnd =  new Endereco();

// novaPF.nome = "Aparecida";
// novaPF.dataNascimento = ("13/08;/1987");
// novaPF.cpf = "12345678901";
// novaPF.rendimento = 1854.5f;

// novoEnd.logradouro = "Rua das Flores";
// novoEnd.numero = 12345;
// novoEnd.complemento = "Comercial Violeta";
// novoEnd.endComercial = true;

// novaPF.endereco = novoEnd;


//Console.WriteLine($"Nome:{novaPF.nome}");
//Console.WriteLine($"Data de Nascimento:{novaPF.dataNascimento}");
//Console.WriteLine($"CPF:{novaPF.cpf}");
//Console.WriteLine($"Rendimento:{novaPF.rendimento}");
//Console.WriteLine($"Endereço: {novaPF.endereco.logradouro},{novaPF.endereco.numero}");

// Console.WriteLine(@$"
// Nome:{novaPF.nome}
// Maior de idade:{ metodoPF.validarDataNascimento(novaPF.dataNascimento)}
// CPF:{novaPF.cpf}
// Rendimento:{novaPF.rendimento}
// Endereço: {novaPF.endereco.logradouro},{novaPF.endereco.numero}
// ");

PessoaJuridica metodoPj= new PessoaJuridica();


PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.nome = "Nome Pj";
novaPj.cnpj = "00111222000133";
novaPj.razaoSocial = "Razão Social PJ";
novaPj.rendimento = 30000.5f;

novoEndPj.logradouro = "Rua das Violetas";
novoEndPj.numero = 1313;
novoEndPj.complemento = "Palácio do Comércio";
novoEndPj.endComercial = true;

novaPj.endereco = novoEndPj;

 //Console.WriteLine($"{metodoPj.validarCnpj("00111222000133")}");

Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
CNPJ Válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}");



