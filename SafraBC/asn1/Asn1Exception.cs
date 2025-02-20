using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.asn1;

[Serializable]
public class Asn1Exception
        : IOException
{
    public Asn1Exception()
        : base()
    {
    }

    public Asn1Exception(string message)
        : base(message)
    {
    }

    public Asn1Exception(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    protected Asn1Exception(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}
