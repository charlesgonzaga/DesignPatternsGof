using Decorator.Entities;
using Decorator.Entities.Interfaces;

namespace Decorator.Pattern;

public class UsuarioPerfil2Decorator : IPerfilAcesso
{
    private readonly PerfilAcesso _perfilAcesso;

    public UsuarioPerfil2Decorator(PerfilAcesso perfilAcesso)
    {
        _perfilAcesso = perfilAcesso;
        _perfilAcesso.Acesso.Add("PERF2");
    }

    public PerfilAcesso RetornarPerfil() => _perfilAcesso;

    public List<string> ObterAcesso() => _perfilAcesso.Acesso;
}
