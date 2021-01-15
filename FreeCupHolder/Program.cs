using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FreeCupHolder
{
    class Program
    {
        static void Main(string[] args)
        {
            string driveLetter = ":F";
            string returnString = "";
            Console.WriteLine("Sending the cup holder...");
            int ret = mciSendStringA("set cdaudio door open", null, 0, 0);
            Console.WriteLine("Sent!");
            Console.ReadKey();
        }

        [DllImport("winmm.dll", EntryPoint = "mciSendString")]
        public static extern int mciSendStringA(string lpstrCommand, string lpstrReturnString,
                            int uReturnLength, int hwndCallback);
    }
}
