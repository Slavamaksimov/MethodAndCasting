internal class Program
{
    private static void Main(string[] args)
    {
        NewMessage();
        List<string> ostunimekiri = new List<string>();
        Console.WriteLine("Sisesta oma tänane poeskäigunimekiri");
        string kasutajaSisestus = "";
        GetUserInput(kasutajaSisestus, ostunimekiri); 
        foreach (var söök in ostunimekiri)
        {
            Console.WriteLine($" -*- {söök}");
        }
        GetUserInput(kasutajaSisestus, ostunimekiri);

    }

    static List<string> GetUserInput(string kasutajasisestus, List<string> ostunimekiri)
    {
        while (kasutajasisestus != "rohkem pole")
        {
            Console.WriteLine("Kirjuta ükshaaval, sisesta järgmine ost:\nKui rohkem ei ole midagi lisada, siis ütle \"rohkem pole\"");
            kasutajasisestus = Console.ReadLine();
            if (kasutajasisestus != "" || kasutajasisestus != "rohkem pole")
            {
                ostunimekiri.Add(kasutajasisestus);
            }
            else if (kasutajasisestus == "rohkem pole")
            {
                kasutajasisestus = "";
            }
        }
        Console.WriteLine("see sinu nimekiri");
        return ostunimekiri;
    }

    static void NewMessage()
    {
        Console.WriteLine("this is message");
    }



}