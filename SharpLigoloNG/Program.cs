using System;
using System.Text;
using System.Runtime.InteropServices;

namespace SharpLigoloNG
{
    class Program
    {
        [DllImport("main.dll", EntryPoint = "mainwrapper")]
        extern static int mainwrapper(byte[] args);

        static void Main(string[] args)
        {
            string argsAsString = String.Join(" ", args);
            mainwrapper(Encoding.Default.GetBytes(argsAsString));
        }
    }
}
