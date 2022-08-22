namespace Mediator;

public abstract class Usuario
{
    protected IGrupoUsuarioMediator mediator;
    protected string nome;

    public Usuario(IGrupoUsuarioMediator mediator, string nome)
    {
        this.mediator = mediator;
        this.nome = nome;
    }

    public abstract void Enviar(string msg);

    public abstract void Receber(string msg);
}