using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Crypto;

public interface IAsymmetricCipherKeyPairGenerator
{
    /**
     * intialise the key pair generator.
     *
     * @param the parameters the key pair is to be initialised with.
     */
    void Init(KeyGenerationParameters parameters);

    /**
     * return an AsymmetricCipherKeyPair containing the Generated keys.
     *
     * @return an AsymmetricCipherKeyPair containing the Generated keys.
     */
    AsymmetricCipherKeyPair GenerateKeyPair();
}
