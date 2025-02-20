using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Security;

[Serializable]
public class InvalidKeyException
        : KeyException
{
    public InvalidKeyException()
        : base()
    {
    }

    public InvalidKeyException(string message)
        : base(message)
    {
    }

    public InvalidKeyException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    protected InvalidKeyException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}
