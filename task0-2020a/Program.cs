using System;
using System.Collections.Generic;
using System.Linq;

namespace task0_2020a
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new ConsolePrinter();
            List<Client> list = new List<Client>
            {
                new Client("Olivia", 213, 0),
                new Client("Emily", 100, 0),
                new Client("Richard", 50, 0),
                new Client("Paige", 400, 1),
                new Client("Maddison", 200, 1),
                new Client("Dexter", 20, 1),
                new Client("Jack", 335, 2),
                new Client("John", 175, 2),
                new Client("Leo", 30, 2),
                new Client("Alfie", 220, 3),
                new Client("Henry", 112, 3),
                new Client("Rose", 40, 3)
            };
            


            Console.WriteLine("1. Отсортировать массив по энергии по убыванию");
            list.Sort(new Comparison<Client>((x, y) => y.Energy.CompareTo(x.Energy)));
            OutputClientList(list, printer);


            Console.WriteLine("2. Отсортировать массив по величине оплаты клиентами по возрастанию");
            list.Sort(new Comparison<Client>((x, y) => x.CostPerMonth(x.Tariff, x.Energy).CompareTo(y.CostPerMonth(y.Tariff, y.Energy))));
            OutputClientList(list, printer);


            Console.WriteLine("3. Упорядочить массив по типу клиентов");
            list.Sort(new Comparison<Client>((x, y) => x.Tariff.CompareTo(y.Tariff)));
            OutputClientList(list, printer);


            double Summa = list.Sum(x => x.CostPerMonth(x.Tariff,x.Energy));
            Console.WriteLine("4. Вычислить общую сумму Sum оплаты всех клиентов за потреблённую энергию");
            Console.WriteLine($"Сумма: {Summa}");


            Console.WriteLine("5. Вычислить общий размер льготы Lg");
            int AllEnergy = list.Sum(x => x.Energy);
            double Sum0 = AllEnergy * Tariff.BaseCost;
            Console.WriteLine($"Льгота: {Sum0 - Summa}");
        }
        public static void OutputClientList(List<Client> list, IPrinter printer)
        {  
            Console.WriteLine(String.Format("{0,10}\t|{1,5}\t|{2,15}\t|{3,10}","Client Name", "Energy", "Tariff Name", "Month Cost"));
            foreach (Client l in list)
                l.Print(printer);
            Console.WriteLine();
        }
    }
}
