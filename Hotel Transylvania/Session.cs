namespace Hotel_Transylvania
{
    public static class Session
    {
        public static int userId;
        public static int customerId;

        public static string username;
        public static string FullName;
        public static string role;

        public static void Clear()
        {
            userId = 0;
            customerId = 0;

            username = "";
            role = "";
        }
    }
}   