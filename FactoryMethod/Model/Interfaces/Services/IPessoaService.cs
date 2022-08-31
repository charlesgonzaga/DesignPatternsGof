using FactoryMethod.Model.Dtos;

namespace FactoryMethod.Model.Interfaces.Services;

public interface IPessoaService
{
    string RegraDeNegocio(PessoaInputModel inputModel);
}
