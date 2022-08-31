using System.Xml;

namespace Adapter.Dtos;

public class CotacaoFrete
{
    public string CnpjEmpresa { get; set; }
    public string Cep { get; set; }
    public int CdTransportadora { get; set; }
    public double PsReal { get; set; }
    public int PsCubado { get; set; }
    public double VlNotaFiscal { get; set; }
    public string IdTipoCliente { get; set; }
    public string IdContribuinteIcms { get; set; }
    public string CdTipoServico { get; set; }
    public int IdTabelaMedia { get; set; }
    public int QtdTotal { get; set; }
    public string IdRanking { get; set; }

    public CotacaoFrete() {}

    public string ObterCotacaoXML()
    {
        var objCotacao = new CotacaoFrete();
        var strCotacao = @"
        <root>
          <CnpjEmpresa/>
          <Cep/>
          <CdTransportadora>0</CdTransportadora>
          <PsReal>0</PsReal>
          <PsCubado>0</PsCubado>
          <VlNotaFiscal>0</VlNotaFiscal>
          <IdTipoCliente/>
          <IdContribuinteIcms/>
          <CdTipoServico/>
          <IdTabelaMedia>0</IdTabelaMedia>
          <QtdTotal>0</QtdTotal>
          <IdRanking/>
        </root>
        ";

        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(strCotacao);

        return xmlDocument.InnerXml;
    }
}
