using static System.Net.Mime.MediaTypeNames;

namespace Proyct2doParcial
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
            Application.Run(new MainForm()); // Asegúrate de que la clase MainForm esté definida en tu proyecto
        }
    }
}