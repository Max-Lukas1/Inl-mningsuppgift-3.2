using System;
namespace inlämningsuppgift3_2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("har du gått ut gymnasiet skriv n för nej och j för ja");
            string x = Console.ReadLine();
            switch (x)
            {
                case "j":
                    Console.WriteLine("Hur gammal är du?");
                    break;
                default:
                    Console.WriteLine("Tyvärr vi letar efter annan personal");
                    break;

            }
            int ålder = int.Parse(Console.ReadLine());

            if (ålder < 22) Console.WriteLine("Vi skulle gärna anställa dig");
                    
            if (ålder > 22) Console.WriteLine("Vi letar tyvärr efter annan personal.");

        }
    }    
}

