using FactoryMethod.Model.Dtos;
using FactoryMethod.Model.Interfaces.Services;

namespace FactoryMethod.Service;

public class PessoaJuridicaService : IPessoaJuridicaService
{
    public PessoaJuridicaService() { }

    public string RegraDeNegocio(PessoaInputModel inputModel)
    {
        return $"Regra de negócio para pessoa [Jurídica: {inputModel.NomeFantasia}] aplicada.";
    }
}
