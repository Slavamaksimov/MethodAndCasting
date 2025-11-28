using System.Net.NetworkInformation;

namespace Method2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Tervitus();
            string kasutajaNimi = "";
            kasutajaNimi = KasutajanimeKüsimine(kasutajaNimi);
            float eelarve = 0.00f;
            bool kasKasutajaNõustab = false;
            Tervitus();
            kasKasutajaNõustab = NõusolekuKüsimine(kasutajaNimi, kasKasutajaNõustab);


        }

        private static void Tervitus()
        {
            Console.WriteLine("'OMMIK");
        }

        private static bool NõusolekuKüsimine(string kasutajaNimi, bool kasKasutajaNõustab)
        {
            while (kasKasutajaNõustab == false)
            {
                Console.WriteLine($"{kasutajaNimi}, kas see on sinu õige eelarve");
                Console.WriteLine("Vasta kas jah või ei");
                string vastus = Console.ReadLine();
                if (vastus == "jah")
                {
                    kasKasutajaNõustab = true;
                }
                else
                {
                    kasKasutajaNõustab = false;
                }



            }

            return kasKasutajaNõustab;
        }

        private static string KasutajanimeKüsimine(string kasutajaNimi)
        {
            while (kasutajaNimi == "")
            {
                Console.WriteLine("TERRE; palun sisesta oma kasutajaNimi");
                kasutajaNimi = Console.ReadLine();
            }
            Console.WriteLine("Mis on sinu nädalane eelarve?");
            return kasutajaNimi;
        }
    }
}
