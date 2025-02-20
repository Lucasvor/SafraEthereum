using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Security;

[Serializable]
public class KeyException
        : GeneralSecurityException
{
    public KeyException()
        : base()
    {
    }

    public KeyException(string message)
        : base(message)
    {
    }

    public KeyException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    protected KeyException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}
