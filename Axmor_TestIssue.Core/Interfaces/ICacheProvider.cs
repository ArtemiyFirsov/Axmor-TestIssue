namespace Axmor_TestIssue.Core.Interfaces
{
    public interface ICacheProvider
    {
        void Put(object o, string key, int expirationSeconds = 0);
        TType Get<TType>(string key);
    }
}