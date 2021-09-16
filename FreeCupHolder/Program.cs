using System;
using System.Runtime.InteropServices;

namespace FreeCupHolder
{
    class Program
    {

        //import windows api method to open cd drive
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]

        protected static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, IntPtr hwndCallback);

        static void Main(string[] args)
        {
            Console.WriteLine("Would you like a free cup holder?");
            Console.WriteLine("\ty - Yes");
            Console.WriteLine("\tn - No");

            //operations for yes and no
            switch (Console.ReadLine())
            {
                case "y":
                    Console.WriteLine("Enjoy your free cupholder!");
                    mciSendString("set CDAudio door open", null, 127, IntPtr.Zero);
                    break;
                case "n":
                    Console.WriteLine("Okay then.");
                    break;
            }
            //fin
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}
