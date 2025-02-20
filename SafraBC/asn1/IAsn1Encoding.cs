using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.asn1;

internal interface IAsn1Encoding
{
    void Encode(Asn1OutputStream asn1Out);

    int GetLength();
}
