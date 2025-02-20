using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.asn1.Anssi;

public sealed class AnssiObjectIdentifiers
{
    private AnssiObjectIdentifiers()
    {
    }

    public static readonly DerObjectIdentifier FRP256v1 = new DerObjectIdentifier("1.2.250.1.223.101.256.1");
}
