﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.asn1;

public interface Asn1SequenceParser
    : IAsn1Convertible
{
    IAsn1Convertible ReadObject();
}
