using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.asn1;

public interface IAsn1Convertible
{
    Asn1Object ToAsn1Object();
}