using System.Numerics;

namespace ESys.Domain.Entities;
public class BizXml
{
    public BigInteger Id { set; get; }
    public string BizId { set; get; } = string.Empty;
    public string TName { set; get; } = string.Empty;
    public string Xml { set; get; } = string.Empty;
    public string XmlTitles { set; get; } = string.Empty;
    public string XmlTags { set; get; } = string.Empty;
    public string XmlColCount { set; get; } = string.Empty;
    public string WhereClause { set; get; } = string.Empty;
    public Biz? Biz { get; set; } = default;
}

