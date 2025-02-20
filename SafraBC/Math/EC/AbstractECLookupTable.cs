using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Math.EC;

public abstract class AbstractECLookupTable
        : ECLookupTable
{
    public abstract ECPoint Lookup(int index);
    public abstract int Size { get; }

    public virtual ECPoint LookupVar(int index)
    {
        return Lookup(index);
    }
}
