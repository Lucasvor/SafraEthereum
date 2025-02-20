using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Util.IO;

[Serializable]
public class StreamOverflowException
     : IOException
{
    public StreamOverflowException()
        : base()
    {
    }

    public StreamOverflowException(string message)
        : base(message)
    {
    }

    public StreamOverflowException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    protected StreamOverflowException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}
