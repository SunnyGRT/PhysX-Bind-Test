using System;
using System.Runtime.InteropServices;

namespace PhysX_Bind_Test
{
    class Program
    {

        [DllImport(@"\HelperDlls\PhysXDevice64.dll", EntryPoint = "physxDevInit")]
        private static extern int physxDevInit();


        [DllImport(@"\HelperDlls\PhysXDevice64.dll", EntryPoint = "physxDevErrorString", CharSet = CharSet.Unicode)]
        private static extern int physxDevErrorString(ref string message);

        static void Main(string[] args)
        {

            var init = physxDevInit();
            string err = null;
            init = physxDevErrorString(ref err);
            Console.WriteLine("Hello World!");
            Console.Read();

        }
    }
}
