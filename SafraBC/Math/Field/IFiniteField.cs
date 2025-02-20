using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Math.Field;

public interface IFiniteField
{
    BigInteger Characteristic { get; }

    int Dimension { get; }
}
