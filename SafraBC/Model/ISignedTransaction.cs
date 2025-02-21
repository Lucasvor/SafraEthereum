using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Model;

public interface ISignedTransaction
{
    TransactionType TransactionType { get; }
    ISignature Signature { get; }
    byte[] RawHash { get; }
    byte[] Hash { get; }
    byte[] GetRLPEncoded();
    byte[] GetRLPEncodedRaw();
    void SetSignature(ISignature signature);
}
