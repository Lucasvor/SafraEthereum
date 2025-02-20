using SafraBC.Math.EC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Math.Endo;

public interface ECEndomorphism
{
    ECPointMap PointMap { get; }

    bool HasEfficientPointMap { get; }
}
