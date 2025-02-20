using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Math.EC.Multiplier;

public class WTauNafPreCompInfo
        : PreCompInfo
{
    /**
     * Array holding the precomputed <code>AbstractF2mPoint</code>s used for the
     * WTNAF multiplication in <code>
     * {@link Org.BouncyCastle.Math.EC.multiplier.WTauNafMultiplier.multiply()
     * WTauNafMultiplier.multiply()}</code>.
     */
    protected AbstractF2mPoint[] m_preComp;

    public virtual AbstractF2mPoint[] PreComp
    {
        get { return m_preComp; }
        set { this.m_preComp = value; }
    }
}
