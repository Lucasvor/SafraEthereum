using SafraBC.Math;
using SafraBC.Math.EC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.asn1.X9;
public abstract class X9IntegerConverter
{
    public static int GetByteLength(ECFieldElement fe) => fe.GetEncodedLength();

    public static int GetByteLength(ECCurve c) => c.FieldElementEncodingLength;

    public static byte[] IntegerToBytes(BigInteger s, int qLength)
    {
        byte[] bytes = s.ToByteArrayUnsigned();

        if (qLength < bytes.Length)
        {
            byte[] tmp = new byte[qLength];
            Array.Copy(bytes, bytes.Length - tmp.Length, tmp, 0, tmp.Length);
            return tmp;
        }
        else if (qLength > bytes.Length)
        {
            byte[] tmp = new byte[qLength];
            Array.Copy(bytes, 0, tmp, tmp.Length - bytes.Length, bytes.Length);
            return tmp;
        }

        return bytes;
    }
}
