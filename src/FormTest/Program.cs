using System.Runtime.InteropServices;

namespace FormTest
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            if (IsConsoleMode(args))
                ConsoleMain();
            else
                Application.Run(new frmMain());
        }

        static bool IsGuiMode(string[] args) 
        {
            return false;
        }
        static bool IsConsoleMode(string[] args) 
        {
            //if OS is linux, always use console mode.
            //if OS is windows and argument has "-console", use console mode.
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return true;
            }

            return true;
        }
        static void ConsoleMain()
        { 
        }
    }
}