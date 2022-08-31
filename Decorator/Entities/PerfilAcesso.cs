using Decorator.Entities.Interfaces;

namespace Decorator.Entities;

public class PerfilAcesso : IPerfilAcesso
{
    public List<string> Acesso { get; set; }

    public PerfilAcesso()
    {
        Acesso = new List<string> { "BASIC" };
    }

    public List<string> ObterAcesso() => Acesso;
}
