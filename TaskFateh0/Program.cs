using System;

namespace TaskFateh0
{
    class Program
    {
        static void Main(string[] args)
        {
            Lada[] ladas = new Lada[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Lada markali masinin modelini daxil edin...");
                string model = Console.ReadLine();
                Console.Write("Lada markali masinin brandini daxil edin...");
                string brand = Console.ReadLine();
                Console.Write("Lada markali masinin mileageini daxil edin...");
                string mileageStr = Console.ReadLine();
                Console.Write("Lada markali masini 2 teker qaldirmaq olur? (he/yox)...");
                string answer2teker = "";
                do
                {
                    answer2teker =  = Console.ReadLine().ToLower();
                } while (answer2teker != "he" && answer2teker != "yox");
                bool answer;
                if (answer2teker == "he")
                {

                }
            }

        }
    }
}

