using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevenAlpha
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
          
            // Debug Application Calls
          
            //Application.Run(new BookingHistoryMembers(6, new DateTime(2018, 03, 24), new DateTime(2018, 03, 24)));
            //Application.Run(new BookingHistoryFacilities(17, new DateTime(2018, 03, 24), new DateTime(2018, 03, 24)));
            //Application.Run(new MemberLookup());
            //Application.Run(new BookingsManager("Tennis Court", new DateTime(2018, 03, 24)));
        }
    }
}
