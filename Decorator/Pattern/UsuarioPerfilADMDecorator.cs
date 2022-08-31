using Decorator.Entities;
using Decorator.Entities.Interfaces;

namespace Decorator.Pattern;

public class UsuarioPerfilADMDecorator : IPerfilAcesso
{
    private readonly PerfilAcesso _perfilAcesso;

    public UsuarioPerfilADMDecorator(PerfilAcesso perfilAcesso)
    {
        _perfilAcesso = perfilAcesso;
        _perfilAcesso.Acesso.Add("ADM");
    }

    public PerfilAcesso RetornarPerfil() => _perfilAcesso;

    public List<string> ObterAcesso() => _perfilAcesso.Acesso;
}
