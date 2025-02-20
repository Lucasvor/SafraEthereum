using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Util;


	[Serializable]
public class MemoableResetException
        : InvalidCastException
{
    public MemoableResetException()
        : base()
    {
    }

    public MemoableResetException(string message)
        : base(message)
    {
    }

    public MemoableResetException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    protected MemoableResetException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}
