using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Math.EC;

public class ScaleXPointMap
        : ECPointMap
{
    protected readonly ECFieldElement scale;

    public ScaleXPointMap(ECFieldElement scale)
    {
        this.scale = scale;
    }

    public virtual ECPoint Map(ECPoint p)
    {
        return p.ScaleX(scale);
    }
}
