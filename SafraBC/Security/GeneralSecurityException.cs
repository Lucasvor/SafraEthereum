using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Security;

[Serializable]
public class GeneralSecurityException
        : Exception
{
    public GeneralSecurityException()
        : base()
    {
    }

    public GeneralSecurityException(string message)
        : base(message)
    {
    }

    public GeneralSecurityException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    protected GeneralSecurityException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}
