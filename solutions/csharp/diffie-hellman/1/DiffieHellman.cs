using System.Numerics;

public static class DiffieHellman
{
    public static BigInteger PrivateKey(BigInteger primeP) => Random.Shared.RandomBigInt(BigInteger.Parse("1"), primeP);

    public static BigInteger PublicKey(BigInteger primeP, BigInteger primeG, BigInteger privateKey) => (BigInteger)(BigInteger.ModPow(primeG, privateKey, primeP));

    public static BigInteger Secret(BigInteger primeP, BigInteger publicKey, BigInteger privateKey) => (BigInteger)(BigInteger.ModPow(publicKey, privateKey, primeP));

    // Get random big integer
    public static BigInteger RandomBigInt(this Random random, BigInteger minValue, BigInteger maxValue) {
        BigInteger range = maxValue - minValue;

        byte[] bytes = range.ToByteArray();

        BigInteger result;
        do {
            random.NextBytes(bytes);
            bytes[bytes.Length - 1] &= 0x7F;
            result = new BigInteger(bytes);
        } while(result >= range);

        return minValue + result;
    }
}