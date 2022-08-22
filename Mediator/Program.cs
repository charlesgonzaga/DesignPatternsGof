using Mediator;

IGrupoUsuarioMediator grupoUsuario = new GrupoUsuarioMediator();

Usuario charles = new UsuarioConcreto(grupoUsuario, "Charles");
Usuario maria = new UsuarioConcreto(grupoUsuario, "Maria");
Usuario joao = new UsuarioConcreto(grupoUsuario, "Joao");
Usuario pedro = new UsuarioConcreto(grupoUsuario, "Pedro");

grupoUsuario.RegistrarUsuario(charles);
grupoUsuario.RegistrarUsuario(maria);
//grupoUsuario.RegistrarUsuario(joao);
grupoUsuario.RegistrarUsuario(pedro);

// a cada envio, todos os usuarios receberao a mensagem
charles.Enviar("Bom dia Grupo");
maria.Enviar("bom dia");

Console.Read();