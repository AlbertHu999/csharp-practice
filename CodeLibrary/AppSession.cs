namespace CodeLibrary
{
    public static class AppSession
    {
        public static string CurrentUser { get; private set; } = "";
        public static string CurrentRole { get; private set; } = "";
        public static bool   IsAdmin     => CurrentRole == "admin";

        public static void Login(string user, string role)
        {
            CurrentUser = user;
            CurrentRole = role;
        }

        public static void Logout()
        {
            CurrentUser = "";
            CurrentRole = "";
        }
    }
}
