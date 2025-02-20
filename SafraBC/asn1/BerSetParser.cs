using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.asn1;

public class BerSetParser
    : Asn1SetParser
{
    private readonly Asn1StreamParser m_parser;

    internal BerSetParser(Asn1StreamParser parser)
    {
        m_parser = parser;
    }

    public IAsn1Convertible ReadObject() => m_parser.ReadObject();

    public Asn1Object ToAsn1Object() => Parse(m_parser);

    internal static BerSet Parse(Asn1StreamParser sp) => BerSet.FromVector(sp.ReadVector());
}
