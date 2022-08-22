namespace Mediator;

public interface IGrupoUsuarioMediator
{
    void RegistrarUsuario(Usuario usuario);
    void EnviarMensagens(string msg, Usuario usuario);
}
