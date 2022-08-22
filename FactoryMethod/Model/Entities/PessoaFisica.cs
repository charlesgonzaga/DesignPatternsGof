using FactoryMethod.Model.Entities;

namespace FactoryMethod.Dtos;

public class PessoaFisica : Pessoa
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public DateTime DataNascimento { get; set; }

    public PessoaFisica(string nome, string cpf, DateTime dataNascimento)
    {
        Nome = nome;
        Cpf = cpf;
        DataNascimento = dataNascimento;
    }
}
