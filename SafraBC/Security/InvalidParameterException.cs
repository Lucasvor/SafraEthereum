using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Security;

[Serializable]
public class InvalidParameterException
        : KeyException
{
    public InvalidParameterException()
        : base()
    {
    }

    public InvalidParameterException(string message)
        : base(message)
    {
    }

    public InvalidParameterException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    protected InvalidParameterException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}
