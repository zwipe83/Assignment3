
/// <summary>
/// Filename: Program.cs
/// Created on: 2024-02-18 00:00:00
/// Author: Samuel Jeffman
/// </summary>

namespace Assignment3
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
            Application.Run(new MainForm());
        }
    }
}