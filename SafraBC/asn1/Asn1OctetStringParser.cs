using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.asn1;

public interface Asn1OctetStringParser
    : IAsn1Convertible
{
    /// <summary>Return the content of the OCTET STRING as a <see cref="Stream"/>.</summary>
    /// <returns>A <see cref="Stream"/> represnting the OCTET STRING's content.</returns>
    Stream GetOctetStream();
}
