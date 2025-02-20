using SafraBC.asn1.Sec;
using SafraBC.Crypto.Digests;
using SafraBC.Math;
using SafraBC.Math.EC;
using SafraBC.Security;
using SafraBC.Signer;
using SafraBC.Util;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        //Gera a chave com a Semelhante a biblioteca Nehterium
        GerarChaveComPort();
        // Gera a chave só com BouncyCastle
        GerarChaveSemBibliotecaNethereum();
    }
    public static void GerarChaveComPort()
    {
        var account = EthECKey.GenerateKey();
        var privateKey = account.GetPrivateKey();
        var global_privateKey = account.GetPrivateKeyAsBytes();
        var address = account.GetPublicAddress();
        var publicKey = account.GetPubKey();

        Console.WriteLine($"Endereço Nethereum: {address}");
        Console.WriteLine($"Chave publica  Nethereum: {publicKey.ToHex()}");
        Console.WriteLine($"Chave privada  Nethereum: {privateKey}");
        Console.WriteLine("Teste --- Teste\n\n\n\n");
    }
    public static void GerarChaveSemBibliotecaNethereum()
    {
        // 1. Gerar chave privada
        BigInteger privateKey = GeneratePrivateKey();

        // 2. Calcular a chave pública a partir da chave privada
        ECPoint publicKeyPoint = GetPublicKeyFromPrivateKey(privateKey);
        // Obter o array de bytes da chave pública (formato não comprimido: prefixo 0x04 seguido dos bytes X e Y)
        byte[] publicKeyBytes = publicKeyPoint.GetEncoded(false);
        // Remover o prefixo 0x04 para o cálculo do endereço (conforme padrão Ethereum)
        byte[] publicKeyBytesWithoutPrefix = new byte[publicKeyBytes.Length - 1];
        Array.Copy(publicKeyBytes, 1, publicKeyBytesWithoutPrefix, 0, publicKeyBytesWithoutPrefix.Length);

        // 3. Calcular o hash Keccak256 da chave pública sem prefixo
        byte[] hash = Keccak256(publicKeyBytesWithoutPrefix);

        // 4. O endereço Ethereum é composto pelos últimos 20 bytes do hash
        byte[] addressBytes = new byte[20];
        Array.Copy(hash, hash.Length - 20, addressBytes, 0, 20);

        // 5. Converter os valores para hexadecimal
        string privateKeyHex = privateKey.ToString(16).PadLeft(64, '0');
        string publicKeyHex = BitConverter.ToString(publicKeyBytesWithoutPrefix).Replace("-", "").ToLower();
        string addressHex = "0x" + BitConverter.ToString(addressBytes).Replace("-", "").ToLower();

        Console.WriteLine("Chave Privada: " + privateKeyHex);
        Console.WriteLine("Chave Válida ? " + IsValidPrivateKey(privateKey));
        Console.WriteLine("Chave Pública: " + publicKeyHex);
        Console.WriteLine("Endereço Ethereum: " + addressHex);
        Console.WriteLine("Endereço Válido ? " + IsValidEthereumAddress(addressHex));


        Console.WriteLine("Teste --- Teste");
    }
    public static bool IsValidPrivateKey(BigInteger privateKey)
    {
        // Obtém os parâmetros da curva secp256k1
        var ecParams = SecNamedCurves.GetByName("secp256k1");
        BigInteger n = ecParams.N;

        // A chave privada deve ser >= 1 e menor que n
        return privateKey.CompareTo(BigInteger.One) >= 0 && privateKey.CompareTo(n) < 0;
    }

    public static bool IsValidEthereumAddress(string address)
    {
        // Remove o prefixo "0x", se houver
        if (address.StartsWith("0x", System.StringComparison.OrdinalIgnoreCase))
            address = address.Substring(2);

        // O endereço deve ter 40 caracteres (20 bytes)
        if (address.Length != 40)
            return false;

        // Verifica se todos os caracteres são hexadecimais
        return Regex.IsMatch(address, @"\A\b[0-9a-fA-F]+\b\Z");
    }
    // Gera um número aleatório válido para a chave privada (menor que a ordem n da curva secp256k1)
    static BigInteger GeneratePrivateKey()
    {
        SecureRandom secureRandom = new SecureRandom();
        var ecParams = SecNamedCurves.GetByName("secp256k1");
        BigInteger n = ecParams.N;
        BigInteger d;
        do
        {
            d = new BigInteger(n.BitLength, secureRandom);
        } while (d.SignValue == 0 || d.CompareTo(n) >= 0);
        return d;
    }

    // Calcula a chave pública correspondente à chave privada utilizando a multiplicação escalar na curva secp256k1
    static ECPoint GetPublicKeyFromPrivateKey(BigInteger privateKey)
    {
        var ecParams = SecNamedCurves.GetByName("secp256k1");
        ECPoint G = ecParams.G;
        ECPoint q = G.Multiply(privateKey);
        return q.Normalize();
    }

    // Calcula o hash Keccak256 (utilizado pelo Ethereum) do array de bytes de entrada
    static byte[] Keccak256(byte[] input)
    {
        KeccakDigest keccak = new KeccakDigest(256);
        keccak.BlockUpdate(input, 0, input.Length);
        byte[] hash = new byte[keccak.GetDigestSize()];
        keccak.DoFinal(hash, 0);
        return hash;
    }
}