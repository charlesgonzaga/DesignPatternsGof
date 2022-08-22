using FactoryMethod.Dtos;
using FactoryMethod.Model.Entities;
using FactoryMethod.Service;

namespace FactoryMethod.Patterns;

public class PessoaFactory
{
    public static string ObterPessoa(Pessoa entity)
    {
        if (entity is PessoaFisica)
            return new PessoaFisicaService().RegraDeNegocioPessoaFisica(entity);

        return new PessoaJuridicaService().RegraDeNegocioPessoaJuridica(entity);
    }
}
