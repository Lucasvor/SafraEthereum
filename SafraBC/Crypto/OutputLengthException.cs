using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Crypto;

[Serializable]
public class OutputLengthException
    : DataLengthException
{
    public OutputLengthException()
        : base()
    {
    }

    public OutputLengthException(string message)
        : base(message)
    {
    }

    public OutputLengthException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    protected OutputLengthException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}
