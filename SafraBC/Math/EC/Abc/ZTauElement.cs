using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Math.EC.Abc;

internal class ZTauElement
{
    /**
    * The &quot;real&quot; part of <code>&#955;</code>.
    */
    public readonly BigInteger u;

    /**
    * The &quot;<code>&#964;</code>-adic&quot; part of <code>&#955;</code>.
    */
    public readonly BigInteger v;

    /**
    * Constructor for an element <code>&#955;</code> of
    * <code><b>Z</b>[&#964;]</code>.
    * @param u The &quot;real&quot; part of <code>&#955;</code>.
    * @param v The &quot;<code>&#964;</code>-adic&quot; part of
    * <code>&#955;</code>.
    */
    public ZTauElement(BigInteger u, BigInteger v)
    {
        this.u = u;
        this.v = v;
    }
}
