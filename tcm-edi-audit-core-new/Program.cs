namespace tcm_edi_audit_core_new
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
            ApplicationConfiguration.Initialize();

            frmSplashScreen splash = new frmSplashScreen();
            splash.Show();
            splash.Refresh();

            frmHome mainForm = new frmHome();
            mainForm.Load += (s, e) => splash.Close();

            Application.Run(mainForm);
        }
    }
}