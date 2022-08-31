using Adapter.Dtos;
using Adapter.Patterns;

// XML
var teste = new CotacaoFrete();
var docXml = teste.ObterCotacaoXML();
Console.WriteLine(docXml);

// Padrao Adapter - convertendo em Json
var teste2 = new CotacaoFreteAdapter(teste);
var docJson = teste2.ObterCotacaoJson();
Console.WriteLine(docJson);
