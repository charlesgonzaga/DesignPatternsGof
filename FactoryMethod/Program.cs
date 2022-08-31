using FactoryMethod.Model.Dtos;
using FactoryMethod.Model.Interfaces.Pattersns;
using FactoryMethod.Model.Interfaces.Services;
using FactoryMethod.Patterns;
using FactoryMethod.Service;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;

#region Configurations

// Criando uma colecao de servicos
var services = new ServiceCollection();

// Configurando nossas classes na colecao de servicos
services.AddScoped<IPessoaFisicaService, PessoaFisicaService>();
services.AddScoped<IPessoaJuridicaService, PessoaJuridicaService>();
services.AddScoped<IPessoaFactory, PessoaFactory>();

// Criando provedor de acesso aos servicos
var serviceProvider = services.BuildServiceProvider();

#endregion

#region Payload - processo de deserializar

//Direcionar servico de acordo com payload - design pattern Factory Method

var payload = "{\"Nome\":\"Charles\",\"Cpf\":\"999.999.999-99\",\"DataNascimento\":\"1993-08-10T00:00:00\"}";
//payload = "{\"NomeFantasia\":\"Empresa\",\"Cnpj\":\"11.111.111/0001-11\"}";

var inputModel = JsonSerializer.Deserialize<PessoaInputModel>(payload);

#endregion

// Obtendo instancia do servico
var pessoaFactory = serviceProvider.GetRequiredService<IPessoaFactory>();

var pessoa = pessoaFactory.ObterPessoa(inputModel);
Console.WriteLine(pessoa.RegraDeNegocio(inputModel));
