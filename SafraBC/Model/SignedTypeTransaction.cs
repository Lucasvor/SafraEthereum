using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Model;

public abstract class SignedTypeTransaction : SignedTransaction
{
    public override void SetSignature(ISignature signature)
    {
        Signature = signature;
    }
}
