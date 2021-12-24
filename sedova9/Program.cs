using System;

namespace sedova9
{
    class Program
    {
        struct Market
        {
            public string ProductName;
            public string Manufacture;
            public DateTime DateOfMan;
            public int DateOfEnd;
            public int Price;
        }
        static void Main(string[] args)
        {
            try
            {
                Market[] markets = new Market[3];
                for (int i = 0; i < markets.Length; i++)
                {
                    Market mini = new Market();
                    Console.Write("Введите наименование " + (i + 1) + " продукта: ");
                    markets[i].ProductName = Console.ReadLine();
                    Console.Write("Введите его фирму-производителя: ");
                    markets[i].Manufacture = Console.ReadLine();
                    Console.WriteLine("Введите дату производства продукта:");
                    Console.Write("Введите день: ");
                    int d = int.Parse(Console.ReadLine());
                    Console.Write("Введите номер месяца: ");
                    int m = int.Parse(Console.ReadLine());
                    Console.Write("Введите год: ");
                    int y = int.Parse(Console.ReadLine());
                    Console.Write("Введите срок годности продукта в сутках: ");
                    markets[i].DateOfEnd = int.Parse(Console.ReadLine());
                    Console.Write("Введите цену продукта: ");
                    markets[i].Price = int.Parse(Console.ReadLine());
                    mini.DateOfMan = new DateTime(y, m, d);
                    mini.DateOfEnd = int.Parse(Console.ReadLine());
                    mini.ProductName = Console.ReadLine();
                    mini.Manufacture = Console.ReadLine();
                    mini.Price = int.Parse(Console.ReadLine());
                    markets[i] = mini;
                }
                DateTime now = DateTime.Now;
                foreach (Market i in markets)
                {

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
