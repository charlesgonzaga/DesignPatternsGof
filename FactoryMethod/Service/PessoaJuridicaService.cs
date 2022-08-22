using FactoryMethod.Dtos;
using FactoryMethod.Model;
using FactoryMethod.Model.Entities;

namespace FactoryMethod.Service;

public class PessoaJuridicaService : IPessoaService
{
    public PessoaJuridicaService() { }

    public string RegraDeNegocioPessoaJuridica(Pessoa entity)
    {
        var p = (PessoaJuridica)entity;
        return $"Regra de negócio para pessoa [Jurídica: {p.NomeFantasia}] aplicada.";
    }
}
