using Adapter.Dtos;
using Adapter.Interfaces;
using System.Text.Json;

namespace Adapter.Patterns;

public class CotacaoFreteAdapter : ICotacaoFreteAdapter
{
    private readonly CotacaoFrete _cotacaoFrete;

    public CotacaoFreteAdapter(CotacaoFrete cotacaoFrete)
    {
        _cotacaoFrete = cotacaoFrete;
    }

    public string ObterCotacaoJson() => JsonSerializer.Serialize(_cotacaoFrete);
}
