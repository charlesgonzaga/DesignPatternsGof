using FactoryMethod.Model.Dtos;
using FactoryMethod.Model.Interfaces.Services;

namespace FactoryMethod.Model.Interfaces.Pattersns;

public interface IPessoaFactory
{
    IPessoaService ObterPessoa(PessoaInputModel entity);
}
