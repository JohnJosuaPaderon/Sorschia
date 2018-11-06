namespace Sorschia
{
    public interface ICrypto
    {
        string Encrypt(string plainText);
        string Decrypt(string cipherText);
    }
}
