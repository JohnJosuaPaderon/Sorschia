namespace Sorschia
{
    public interface ICryptoKeyProvider
    {
        void Install(string cryptoKey);
        bool Verify();
        string Request();
    }
}
