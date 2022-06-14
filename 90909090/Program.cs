using System;

namespace _90909090
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Product pr1 = new Book()
            {
                Author = "Carl Sagan",
                Genre = "Science",
                Name = "Cosmos",
                Price = 5

            };

            Product pr2 = new Book()
            {
                Author = "Harari",
                Genre = "Science",
                Name = "Sapiens",
                Price = 20.2
            };

            Product pr3 = new Journal()
            {
                Name = "Wall Street Journal",
                Company = "WS",
                Price = 4
            };

            Product pr4 = new Journal()
            {
                Name = "Gourmet",
                Company = "TS",
                Price = 5
            };

            library.AddProduct(pr1);
            library.AddProduct(pr2);
            library.AddProduct(pr3);
            library.AddProduct(pr4);


            Console.WriteLine("1. Jurnallarin sayini almaq");
            Console.WriteLine("2. Kitablarin sayini almaq");
            Console.WriteLine("3. Productlarin adlarini console-a yazdirmaq");
            string answer;
            do
            {
                Console.WriteLine("Seciminizi daxil edin");
                answer = Console.ReadLine();

            } while ((answer == null) || (answer != "1" && answer != "2"));

            switch (answer)
            {
                case "1":
                    int count = library.GetJournalCount();
                    Console.WriteLine(count);
                    break;
                case "2":
                    int countBook = library.GetBookCount();
                    Console.WriteLine(countBook);
                    break;
                case "3":
                    Console.WriteLine("1. Kitab");
                    Console.WriteLine("2. Jurnal");
                    string answerBook;
                    do
                    {
                        answerBook = Console.ReadLine();

                    } while (answerBook == null || (answerBook !="1" && answerBook != "2"));
                    if (answerBook == "1")
                    {
                        Product[] productsBook = library.GetProducts(true);
                        foreach (var item in productsBook)
                        {
                            Console.WriteLine(item.Name);
                        }
                    }
                    else if (answerBook == "2")
                    {
                        Product[] productsJournal = library.GetProducts(false);
                        foreach (var item in productsJournal)
                        {
                            Console.WriteLine(item.Name);
                        }
                    }
                    break;
                default:
                    break;
            }





        }
    }
}

