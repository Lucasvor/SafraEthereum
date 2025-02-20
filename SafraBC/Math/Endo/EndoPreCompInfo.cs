using SafraBC.Math.EC;
using SafraBC.Math.EC.Multiplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Math.Endo;

public class EndoPreCompInfo
        : PreCompInfo
{
    protected ECEndomorphism m_endomorphism;

    protected ECPoint m_mappedPoint;

    public virtual ECEndomorphism Endomorphism
    {
        get { return m_endomorphism; }
        set { this.m_endomorphism = value; }
    }

    public virtual ECPoint MappedPoint
    {
        get { return m_mappedPoint; }
        set { this.m_mappedPoint = value; }
    }
}
