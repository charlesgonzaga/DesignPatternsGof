namespace FactoryMethod.Model.Entities;

public class PessoaJuridica : Pessoa
{
    public string NomeFantasia { get; set; }
    public string Cnpj { get; set; }

    public PessoaJuridica(string nomeFantasia, string cnpj)
    {
        NomeFantasia = nomeFantasia;
        Cnpj = cnpj;
    }
}
