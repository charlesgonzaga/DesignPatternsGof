using Decorator.Entities;
using Decorator.Entities.Interfaces;
using Decorator.Pattern;
using Microsoft.Extensions.DependencyInjection;

#region Configurations

// Criando uma colecao de servicos
var services = new ServiceCollection();

// Configurando nossas classes na colecao de servicos
services.AddScoped<IPerfilAcesso, PerfilAcesso>();

// Criando provedor de acesso aos servicos
var serviceProvider = services.BuildServiceProvider();

#endregion

// Obtendo instancia do servico
var perfilAcesso = serviceProvider.GetRequiredService<IPerfilAcesso>();

Console.WriteLine("========= PERFIL BASICO =========");
foreach (string item in perfilAcesso.ObterAcesso())
    Console.WriteLine(item);

#region Usando Decorator

// Ponteiro para o objeto que sera incrementado a cada chamada com Decorator
//var perfil = (PerfilAcesso)perfilAcesso;

Console.WriteLine("========= PERFIL 1 ==============");
perfilAcesso = new UsuarioPerfil1Decorator((PerfilAcesso)perfilAcesso).RetornarPerfil();
foreach (string item in perfilAcesso.ObterAcesso())
    Console.WriteLine(item);

Console.WriteLine("========= PERFIL 2 ==============");
perfilAcesso = new UsuarioPerfil2Decorator((PerfilAcesso)perfilAcesso).RetornarPerfil();
foreach (string item in perfilAcesso.ObterAcesso())
    Console.WriteLine(item);

Console.WriteLine("========= PERFIL ADM ============");
perfilAcesso = new UsuarioPerfilADMDecorator((PerfilAcesso)perfilAcesso).RetornarPerfil();
foreach (string item in perfilAcesso.ObterAcesso())
    Console.WriteLine(item);

#endregion