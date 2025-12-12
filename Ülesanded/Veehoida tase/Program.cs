using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Veehoida_tase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string kasutajaNimi = KasutajaNimi();



            string correctUser = "siksseven";
            if (correctUser != kasutajaNimi)  // H Ü Ü U M Ä R K 
            {
                Console.WriteLine(kasutajaNimi+", Sinu nimi ei ole õige");
            }
            else
            {

                double veetase = 0d;
                Console.WriteLine("Tere"+correctUser+". Mis on veetasame hetkeseis meetrites?: ");
                bool errorState = false;
                do
                {
                    Console.WriteLine("Mis on veetase anduril?:");
                    double andur = double.Parse(Console.ReadLine());
                    veetase = andur; 
                    if (veetase < 1.00d || veetase > 4.25d)
                    {
                        errorState = true;
                        break;
                    }
                }
                while (veetase < 1.00d && veetase > 4.25d);
                HoiatusSõnum(veetase, errorState);
            }


        }

        private static void HoiatusSõnum(double veetase, bool errorState)
        {

            if (veetase >= 1.00d &&  veetase < 2.00d)
            {
                Console.WriteLine("VEETASE ON MADAL");
            }
            else if (veetase >= 2.0d && veetase < 3.5d) 
            {
                Console.WriteLine("veetase on normaalne PaAnIkAkS ei ole PÕHjUsT!!!!!");
            }
            else if (veetase >= 3.5d && veetase < 4.25d)
            {
                Console.WriteLine("tase on liiga kõrge, chill...");
            }
            else
            {
                errorState = true; 
                Console.WriteLine("* anduri viga, kontrolli seedet *");
            }
        }





        private static string KasutajaNimi() 
        {
            string sisestus = ""; 
            do
            {
                Console.WriteLine("Palun sisesta oma kasutajanimi");
                sisestus  = Console.ReadLine();
            } while (sisestus == "");
            return sisestus;
           
        }
    }
}
