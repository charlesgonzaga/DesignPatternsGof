using FactoryMethod.Dtos;
using FactoryMethod.Patterns;

//Payload
var pf = new PessoaFisica("Charles", "999.999.999-99", new DateTime(1993, 8, 10));
var pj = new PessoaJuridica("Empresa", "11.111.111/0001-11");

//Direcionar servico de acordo com payload - design pattern Factory Method
var f = PessoaFactory.ObterPessoa(pf);
var j = PessoaFactory.ObterPessoa(pj);

//Retorno da aplicação
Console.WriteLine(f);
Console.WriteLine(j);