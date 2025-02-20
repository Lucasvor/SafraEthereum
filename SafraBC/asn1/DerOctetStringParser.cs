using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.asn1;

public class DerOctetStringParser
        : Asn1OctetStringParser
{
    private readonly DefiniteLengthInputStream stream;

    internal DerOctetStringParser(
        DefiniteLengthInputStream stream)
    {
        this.stream = stream;
    }

    public Stream GetOctetStream()
    {
        return stream;
    }

    public Asn1Object ToAsn1Object()
    {
        try
        {
            return DerOctetString.WithContents(stream.ToArray());
        }
        catch (IOException e)
        {
            throw new InvalidOperationException("IOException converting stream to byte array: " + e.Message, e);
        }
    }
}
