namespace Mediator;

internal class GrupoUsuarioMediator : IGrupoUsuarioMediator
{
    private List<Usuario> listaUsuarios = new();

    public void RegistrarUsuario(Usuario usuario)
    {
        this.listaUsuarios.Add(usuario);
    }

    // cada usuario recebera a mensagem
    public void EnviarMensagens(string msg, Usuario usuario)
    {
        foreach (var item in listaUsuarios)
        {
            if (item != usuario)
                item.Receber(msg);
        }
    }
}
