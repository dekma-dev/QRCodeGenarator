namespace QRCodeGenarator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //using (SQLClass db = new SQLClass())
            //{
            //    User user1 = new User { name = "Tom", age = 33 };
            //    User user2 = new User { name = "Alice", age = 26 };

            //    db.users.AddRange(user1, user2);
            //    db.SaveChanges();
            //}


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}