using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.asn1;

internal class DLOutputStream
    : Asn1OutputStream
{
    internal DLOutputStream(Stream os, bool leaveOpen)
        : base(os, leaveOpen)
    {
    }

    internal override int Encoding
    {
        get { return EncodingDL; }
    }
}
