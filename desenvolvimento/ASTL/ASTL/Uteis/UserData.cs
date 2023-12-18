namespace ASTL.Uteis
{
    public class UserData
    {
        private static readonly ITempDataUtil session = new SessionUtil();

        public static int ContaID
        {
            get {
                int.TryParse(session.Get("wd_ContaID"), out int num);
                return num;
            }
            set => session.Set("wd_ContaID", value.ToString());
        }

        public static bool Authenticated() => session.Exists("wd_ContaID");
    }
}
