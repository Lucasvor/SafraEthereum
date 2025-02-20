using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Security;

[Serializable]
public class SecurityUtilityException
        : Exception
{
    public SecurityUtilityException()
        : base()
    {
    }

    public SecurityUtilityException(string message)
        : base(message)
    {
    }

    public SecurityUtilityException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    protected SecurityUtilityException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}