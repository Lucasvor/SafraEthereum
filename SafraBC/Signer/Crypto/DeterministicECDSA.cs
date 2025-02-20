using SafraBC.Crypto.Digests;
using SafraBC.Crypto.parameters;
using SafraBC.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafraBC.Crypto.Signers;

namespace SafraBC.Signer.Crypto;

internal class DeterministicECDSA : ECDsaSigner
{
    private readonly IDigest _digest;
    private byte[] _buffer = new byte[0];

    public DeterministicECDSA()
        : base(new HMacDsaKCalculator(new Sha256Digest()))

    {
        _digest = new Sha256Digest();
    }

    public DeterministicECDSA(Func<IDigest> digest)
        : base(new HMacDsaKCalculator(digest()))
    {
        _digest = digest();
    }


    public void setPrivateKey(ECPrivateKeyParameters ecKey)
    {
        Init(true, ecKey);
    }

    public byte[] sign()
    {
        var hash = new byte[_digest.GetDigestSize()];
        _digest.BlockUpdate(_buffer, 0, _buffer.Length);
        _digest.DoFinal(hash, 0);
        _digest.Reset();
        return signHash(hash);
    }

    public byte[] signHash(byte[] hash)
    {
        return new ECDSASignature(GenerateSignature(hash)).ToDER();
    }

    public void update(byte[] buf)
    {
        _buffer = _buffer.Concat(buf).ToArray();
    }
}
