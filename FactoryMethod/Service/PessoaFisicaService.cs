using FactoryMethod.Model.Dtos;
using FactoryMethod.Model.Interfaces.Services;

namespace FactoryMethod.Service;

public class PessoaFisicaService : IPessoaFisicaService
{
    public PessoaFisicaService() { }

    public string RegraDeNegocio(PessoaInputModel inputModel)
    {
        return $"Regra de negócio para pessoa [Física: {inputModel.Nome}] aplicada.";
    }
}
