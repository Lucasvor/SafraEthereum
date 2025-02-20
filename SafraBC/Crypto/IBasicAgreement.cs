using SafraBC.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Crypto;

public interface IBasicAgreement
{
    /**
     * initialise the agreement engine.
     */
    void Init(ICipherParameters parameters);

    /**
     * return the field size for the agreement algorithm in bytes.
     */
    int GetFieldSize();

    /**
     * given a public key from a given party calculate the next
     * message in the agreement sequence.
     */
    BigInteger CalculateAgreement(ICipherParameters pubKey);
}
