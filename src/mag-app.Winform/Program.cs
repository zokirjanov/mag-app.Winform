using mag_app.DataAccess.DbContexts;
using mag_app.Winform.Windows;

namespace mag_app.Winform
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		//static void Main()
		//{
		//	// To customize application configuration such as set high DPI settings or default font,
		//	// see https://aka.ms/applicationconfiguration.
		//	ApplicationConfiguration.Initialize();
		//	Application.Run(new LoginForm(new AppDbContext()));
		//}
        static void Main()
        {
            using (Mutex mutex = new Mutex(false, "Global\\" + appGuid))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("Instance already running");
                    return;
                }
                ApplicationConfiguration.Initialize();
                Application.Run(new LoginForm(new AppDbContext()));
            }
        }

        private static string appGuid = "c0a76b5a-12ab-45c5-b9d9-d693faa6e7b9";
    }
}