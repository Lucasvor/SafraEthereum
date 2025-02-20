using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Math.EC;

public interface ECPointMap
{
    ECPoint Map(ECPoint p);
}
