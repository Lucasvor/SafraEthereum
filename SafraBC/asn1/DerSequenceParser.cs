using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.asn1;

public class DerSequenceParser
    : Asn1SequenceParser
{
    private readonly Asn1StreamParser m_parser;

    internal DerSequenceParser(Asn1StreamParser parser)
    {
        this.m_parser = parser;
    }

    public IAsn1Convertible ReadObject()
    {
        return m_parser.ReadObject();
    }

    public Asn1Object ToAsn1Object()
    {
        return DLSequence.FromVector(m_parser.ReadVector());
    }
}
