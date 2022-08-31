using Decorator.Entities;
using Decorator.Entities.Interfaces;

namespace Decorator.Pattern;

public class UsuarioPerfil1Decorator : IPerfilAcesso
{
    private readonly PerfilAcesso _perfilAcesso;

    public UsuarioPerfil1Decorator(PerfilAcesso perfilAcesso)
    {
        _perfilAcesso = perfilAcesso;
        _perfilAcesso.Acesso.Add("PERF1");
    }

    public PerfilAcesso RetornarPerfil() => _perfilAcesso;

    public List<string> ObterAcesso() => _perfilAcesso.Acesso;
}
