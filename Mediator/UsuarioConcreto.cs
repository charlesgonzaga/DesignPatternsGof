namespace Mediator;

public class UsuarioConcreto : Usuario
{
    public UsuarioConcreto(IGrupoUsuarioMediator mediator, string nome)
        : base(mediator, nome)
    {
    }

    public override void Enviar(string msg)
    {
        Console.WriteLine($"\n{nome} : enviada => {msg} \n");

        // envia ao grupo, todos receberao a mensagem
        mediator.EnviarMensagens(msg, this);
    }

    public override void Receber(string msg)
    {
        Console.WriteLine($"{nome} : recebida <= {msg}");
    }
}
