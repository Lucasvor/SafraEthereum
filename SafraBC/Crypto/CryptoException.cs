using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Crypto;

[Serializable]
public class CryptoException
     : Exception
{
    public CryptoException()
        : base()
    {
    }

    public CryptoException(string message)
        : base(message)
    {
    }

    public CryptoException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    protected CryptoException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}
