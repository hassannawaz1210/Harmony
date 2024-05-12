namespace SMS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Database database = Database.get_instance();
            database.establish_connection();

            IUser user = new User("hassan", "1234", "Student");
            ApplicationConfiguration.Initialize();
            Application.Run(new login());
        }
    }
}

//=============== TODO: accept/reject student joining applications