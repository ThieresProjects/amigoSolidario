
namespace ASTL.Uteis
{
    public class SessionUtil : ITempDataUtil
    {
        private HttpContext _context;

        public void Delete(string key)
        {
            _context.Session.Remove(key);
        }

        public bool Exists(string key)
        {
            return _context.Session.GetString(key) != null;
        }

        public string? Get(string key)
        {
            string? item = _context.Session.GetString(key);

            if (item == null)
                return default;

            return item;
        }

        public void Set(string key, string value)
        {
            _context.Session.SetString(key, value);
        }
    }
}