using FactoryMethod.Model.Dtos;
using FactoryMethod.Model.Interfaces.Pattersns;
using FactoryMethod.Model.Interfaces.Services;

namespace FactoryMethod.Patterns;

public class PessoaFactory : IPessoaFactory
{
    private readonly IPessoaFisicaService _pessoaFisicaService;
    private readonly IPessoaJuridicaService _pessoaJuridicaService;

    public PessoaFactory(IPessoaFisicaService pessoaFisicaService, IPessoaJuridicaService pessoaJuridicaService)
    {
        _pessoaFisicaService = pessoaFisicaService;
        _pessoaJuridicaService = pessoaJuridicaService;
    }

    public IPessoaService ObterPessoa(PessoaInputModel entity)
    {
        switch (entity.Cpf)
        {
            case null:
                return _pessoaJuridicaService;
            default:
                return _pessoaFisicaService;
        }
    }
}
