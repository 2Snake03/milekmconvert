namespace milekmconvert;

class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        while (run)
        {
            Console.WriteLine("MILE AND KILOMETER CONVERTER");
            Console.Write("Podaj liczbę do przeliczenia z km na mile lub z mili na km: ");
            string xs = Console.ReadLine();

            decimal x = decimal.Parse(xs);

            bool subRun = true;
            while (subRun)
            {
                Console.WriteLine("\nJak chcesz przeliczyć tą liczbę?");
                Console.WriteLine("1. Mile na Kilometry");
                Console.WriteLine("2. Kilometry na Mile");
                string opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        //to do
                        break;
                    case "2":
                        //to do
                        break;
                    default:
                        Console.WriteLine("Niepoprawna opcja. Wybierz ponownie.");
                        break;
                }

                Console.WriteLine("\nCzy chcesz kontynuować?");
                Console.WriteLine("1. Przelicz tą samą liczbę na drugą opcję.");
                Console.WriteLine("2. Przelicz nową liczbę.");
                Console.WriteLine("3. Zakończ program.");
                string optt = Console.ReadLine();

                switch (optt)
                {
                    case "1":
                        break;
                    case "2":
                        subRun = false;
                        break;
                    case "3":
                        subRun = false;
                        run = false;
                        break;
                }

            }
        }

        Console.WriteLine("Program zakończony.");
    }
}