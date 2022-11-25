using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace UCSpoofer.Functions
{
    internal class changer
    {
        public static void hwid()
        {
            Console.WriteLine("spoofing");

            // Strings
            string AmideWinBAT = "C:\\UC Spoofer\\files\\run.bat";
            string AutoAmide = "C:\\UC Spoofer\\files\\automide.exe";
            string Hwid = "C:\\UC Spoofer\\files\\OS.bat";
            string Hwid_2 = "C:\\UC Spoofer\\files\\productkey.bat";
            string gpu = "C:\\UC Spoofer\\files\\gpu.bat";
            string vgkstop = "C:\\UC Spoofer\\files\\vgk.bat";

            // Functions
            void AmideWin()
            {
                void amide()
                {
                    string str = "demmacs uoy siht rof diap uoy fi"; string strresult = ""; int leng;
                    leng = str.Length - 1;
                    while (leng >= 0)
                    {
                        strresult = strresult + str[leng];
                        leng--;
                    }
                    Console.WriteLine("{0}", strresult);
                }
                amide();
                Process.Start(AmideWinBAT);
            }
            void AutoAmideWin()
            {
                Process.Start(AutoAmide);
            }
            void HwidNull()
            {
                Process.Start(Hwid);
                Process.Start(Hwid_2);
            }
            void GPU()
            {
                Console.WriteLine("gpu spoof? [Y-N]");

                string yn = Console.ReadLine().ToUpper();
                bool active = false;

                if (yn != "Y" && yn != "N")
                {
                    active = false;
                }
                else if (yn == "Y")
                {
                    active = true;
                }
                else if (yn == "N")
                {
                    active = false;
                }

                if (active == true)
                {
                    Process.Start(gpu);
                }
            }
            void vgk()
            {
                Process.Start(vgkstop);
            }

            vgk();
            AmideWin();
            AutoAmideWin();
            HwidNull();
            GPU();
        }
        public static void clean()
        {
            // Strings
            string Clean_1 = "C:\\UC Spoofer\\files\\vava1.bat";
            string Clean_2 = "C:\\UC Spoofer\\files\\vava2.bat";
            string Clean_3 = "C:\\UC Spoofer\\files\\vava3.bat";

            // Functions
            void Clean()
            {
                Process.Start(Clean_1);
                Process.Start(Clean_2);
                Process.Start(Clean_3);
            }

            Clean();
        }
    }
}
