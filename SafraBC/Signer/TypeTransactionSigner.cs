using SafraBC.Model;
using SafraBC.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Signer;

public class TypeTransactionSigner<T> where T : SignedTypeTransaction
{
    public TypeTransactionSigner() { }


    public string SignTransaction(string privateKey, T transaction)
    {
        return SignTransaction(privateKey.HexToByteArray(), transaction);
    }

    public string SignTransaction(byte[] privateKey, T transaction)
    {
        return SignTransaction(new EthECKey(privateKey, true), transaction);
    }

    public string SignTransaction(EthECKey ecKey, T transaction)
    {
        var signature = ecKey.SignAndCalculateYParityV(transaction.RawHash);
        transaction.SetSignature(new Signature() { R = signature.R, S = signature.S, V = signature.V });
        return transaction.GetRLPEncoded().ToHex();
    }
}
