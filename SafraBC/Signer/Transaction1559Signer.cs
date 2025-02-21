using SafraBC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Signer;

public class Transaction1559Signer : TypeTransactionSigner<Transaction1559>
{

#if !DOTNET35
    public Task SignExternallyAsync(IEthExternalSigner externalSigner, Transaction1559 transaction)
    {
        return externalSigner.SignAsync(transaction);
    }
#endif
}
