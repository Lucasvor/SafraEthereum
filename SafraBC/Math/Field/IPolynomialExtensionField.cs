using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Math.Field;

public interface IPolynomialExtensionField
    : IExtensionField
{
    IPolynomial MinimalPolynomial { get; }
}
