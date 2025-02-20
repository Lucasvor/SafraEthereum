using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Math.Endo;

public interface GlvEndomorphism
        : ECEndomorphism
{
    BigInteger[] DecomposeScalar(BigInteger k);
}
