using SafraBC.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Crypto;

public static class CryptoServicesRegistrar
{
    public static SecureRandom GetSecureRandom()
    {
        return new SecureRandom();
    }

    public static SecureRandom GetSecureRandom(SecureRandom secureRandom)
    {
        return secureRandom ?? GetSecureRandom();
    }
}
