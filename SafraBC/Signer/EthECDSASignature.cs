using SafraBC.Math;
using SafraBC.Model;
using SafraBC.Signer.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Signer;

public class EthECDSASignature : ISignature
{
    internal EthECDSASignature(BigInteger r, BigInteger s)
    {
        ECDSASignature = new ECDSASignature(r, s);
    }

    public EthECDSASignature(BigInteger r, BigInteger s, byte[] v)
    {
        ECDSASignature = new ECDSASignature(r, s);
        ECDSASignature.V = v;
    }

    internal EthECDSASignature(ECDSASignature signature)
    {
        ECDSASignature = signature;
    }

    internal EthECDSASignature(BigInteger[] rs)
    {
        ECDSASignature = new ECDSASignature(rs);
    }

    public EthECDSASignature(byte[] derSig)
    {
        ECDSASignature = new ECDSASignature(derSig);
    }

    internal ECDSASignature ECDSASignature { get; }

    public byte[] R => ECDSASignature.R.ToByteArrayUnsigned();

    public byte[] S => ECDSASignature.S.ToByteArrayUnsigned();

    public byte[] V
    {
        get => ECDSASignature.V;
        set => ECDSASignature.V = value;
    }

    public bool IsLowS => ECDSASignature.IsLowS;

    public static EthECDSASignature FromDER(byte[] sig)
    {
        return new EthECDSASignature(sig);
    }



    public byte[] ToDER()
    {
        return ECDSASignature.ToDER();
    }



    public static bool IsValidDER(byte[] bytes)
    {
        try
        {
            FromDER(bytes);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static string CreateStringSignature(EthECDSASignature signature)
    {
        return signature.CreateStringSignature();
    }
}
