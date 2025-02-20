using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.asn1;

public class BerSequenceParser
        : Asn1SequenceParser
{
    private readonly Asn1StreamParser m_parser;

    internal BerSequenceParser(Asn1StreamParser parser)
    {
        m_parser = parser;
    }

    public IAsn1Convertible ReadObject() => m_parser.ReadObject();

    public Asn1Object ToAsn1Object() => Parse(m_parser);

    internal static BerSequence Parse(Asn1StreamParser sp) => BerSequence.FromVector(sp.ReadVector());
}
