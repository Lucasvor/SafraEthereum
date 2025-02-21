using SafraBC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Signer;
#if !DOTNET35
public enum ExternalSignerTransactionFormat
{
    RLP,
    Hash,
    Transaction
}
public interface IEthExternalSigner
{
    bool CalculatesV { get; }
    ExternalSignerTransactionFormat ExternalSignerTransactionFormat { get; }
    Task<string> GetAddressAsync();
    Task<EthECDSASignature> SignAsync(byte[] rawBytes);
    Task<EthECDSASignature> SignEthereumMessageAsync(byte[] rawBytes);
    Task<EthECDSASignature> SignAsync(byte[] rawBytes, BigInteger chainId);
    Task SignAsync(LegacyTransaction transaction);
    Task SignAsync(LegacyTransactionChainId transaction);
    Task SignAsync(Transaction1559 transaction);
    bool Supported1559 { get; }
}
#endif