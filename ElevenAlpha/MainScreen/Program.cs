﻿using System;
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
            //Application.Run(new MainScreen());

            //Application.Run(new CreateFacility());
            CreateFacility f = new CreateFacility();
            Application.Run(new FacilityTypeManager(f));

            //Application.Run(new MemberLookup());
            //Application.Run(new BookingsManager("Tennis Court", new DateTime(2018, 03, 24)));
            //Application.Run(new EditFacility(17));
            //Application.Run(new CreateMember());
            //Application.Run(new EditMember(76));
        }
    }
}
