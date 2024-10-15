using HomeLandCost._02.DataAccess.Concrete;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeLandCost
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize application configuration settings
            ApplicationConfiguration.Initialize();

            // Seed data asynchronously, without awaiting.
            Task.Run(async () => await SeedData.SeedMembershipAsync()).Wait();

            // Start the main page of the application
            Application.Run(new Login());
        }
    }
}
