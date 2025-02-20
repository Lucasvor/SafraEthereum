using SafraBC.Crypto.parameters;
using SafraBC.Math;
using SafraBC.Math.EC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Crypto.Agreement
{
    public class ECDHBasicAgreement
       : IBasicAgreement
    {
        // TODO[api] private
        protected internal ECPrivateKeyParameters privKey;

        public virtual void Init(ICipherParameters parameters)
        {
            if (parameters is ParametersWithRandom withRandom)
            {
                parameters = withRandom.Parameters;
            }

            if (!(parameters is ECPrivateKeyParameters ecPrivateKeyParameters))
                throw new ArgumentException("ECDHBasicAgreement expects ECPrivateKeyParameters");

            this.privKey = ecPrivateKeyParameters;
        }

        public virtual int GetFieldSize() => privKey.Parameters.Curve.FieldElementEncodingLength;

        public virtual BigInteger CalculateAgreement(ICipherParameters pubKey)
        {
            ECPublicKeyParameters pub = (ECPublicKeyParameters)pubKey;
            ECDomainParameters dp = privKey.Parameters;
            if (!dp.Equals(pub.Parameters))
                throw new InvalidOperationException("ECDH public key has wrong domain parameters");

            BigInteger d = privKey.D;

            // Always perform calculations on the exact curve specified by our private key's parameters
            ECPoint Q = ECAlgorithms.CleanPoint(dp.Curve, pub.Q);
            if (Q.IsInfinity)
                throw new InvalidOperationException("Infinity is not a valid public key for ECDH");

            BigInteger h = dp.H;
            if (!h.Equals(BigInteger.One))
            {
                d = dp.HInv.Multiply(d).Mod(dp.N);
                Q = ECAlgorithms.ReferenceMultiply(Q, h);
            }

            ECPoint P = Q.Multiply(d).Normalize();
            if (P.IsInfinity)
                throw new InvalidOperationException("Infinity is not a valid agreement value for ECDH");

            return P.AffineXCoord.ToBigInteger();
        }
    }
}
