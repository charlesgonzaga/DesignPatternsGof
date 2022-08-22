using FactoryMethod.Dtos;
using FactoryMethod.Model;
using FactoryMethod.Model.Entities;

namespace FactoryMethod.Service;

public class PessoaFisicaService : IPessoaService
{
    public PessoaFisicaService() { }

    public string RegraDeNegocioPessoaFisica(Pessoa entity)
    {
        var p = (PessoaFisica)entity;
        return $"Regra de negócio para pessoa [Física: {p.Nome}] aplicada.";
    }
}
