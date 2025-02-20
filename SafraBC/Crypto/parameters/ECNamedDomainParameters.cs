using SafraBC.asn1.X9;
using SafraBC.asn1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafraBC.Math.EC;
using SafraBC.Math;

namespace SafraBC.Crypto.parameters;

public class ECNamedDomainParameters
        : ECDomainParameters
{
    private readonly DerObjectIdentifier name;

    public DerObjectIdentifier Name
    {
        get { return name; }
    }

    public ECNamedDomainParameters(DerObjectIdentifier name, ECDomainParameters dp)
        : this(name, dp.Curve, dp.G, dp.N, dp.H, dp.GetSeed())
    {
    }

    public ECNamedDomainParameters(DerObjectIdentifier name, X9ECParameters x9)
        : base(x9)
    {
        this.name = name;
    }

    public ECNamedDomainParameters(DerObjectIdentifier name, ECCurve curve, ECPoint g, BigInteger n)
        : base(curve, g, n)
    {
        this.name = name;
    }

    public ECNamedDomainParameters(DerObjectIdentifier name, ECCurve curve, ECPoint g, BigInteger n, BigInteger h)
        : base(curve, g, n, h)
    {
        this.name = name;
    }

    public ECNamedDomainParameters(DerObjectIdentifier name, ECCurve curve, ECPoint g, BigInteger n, BigInteger h, byte[] seed)
        : base(curve, g, n, h, seed)
    {
        this.name = name;
    }
}