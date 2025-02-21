using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Model;

public interface ITransactionTypeDecoder
{
    SignedTypeTransaction DecodeAsGeneric(byte[] rlpData);
}
