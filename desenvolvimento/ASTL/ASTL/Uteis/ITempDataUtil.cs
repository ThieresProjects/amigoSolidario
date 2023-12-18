namespace ASTL.Uteis
{
    internal interface ITempDataUtil
    {
        string? Get(string key);
        void Set(string key, string value);
        bool Exists(string key);
        void Delete(string key);

    }
}