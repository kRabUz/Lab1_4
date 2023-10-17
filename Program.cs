using Lab1_4.Commands;
using Lab1_4.Interfaces;
using System;

namespace Lab1_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            IDataContext context = new DataContext();
            IReceiver receiver = new Receiver(context);
            CommandInvoker invoker = new CommandInvoker();
            invoker.SetUpCommand(new GetAllApartments(receiver));
            invoker.SetUpCommand(new GetAllRealtors(receiver));
            invoker.SetUpCommand(new CountApartmentsByRooms(receiver));
            invoker.SetUpCommand(new GetApartmentsHigherThan(receiver));
            invoker.SetUpCommand(new FirstOrDefaultSquare(receiver));
            invoker.SetUpCommand(new SkipRealtors(receiver));
            invoker.SetUpCommand(new FromHighestToLowestSquare(receiver));
            invoker.SetUpCommand(new TakeWhileUsingFloor(receiver));
            invoker.SetUpCommand(new GetAverageOffersPerRealtor(receiver));
            invoker.SetUpCommand(new SortByName(receiver));
            invoker.SetUpCommand(new ReverseAgencies(receiver));
            invoker.SetUpCommand(new GroupByRooms(receiver));
            invoker.SetUpCommand(new FindWithFirstLetter(receiver));
            invoker.SetUpCommand(new ApartmentsWithPriceHigherThan(receiver));
            invoker.SetUpCommand(new TotalApartmentsSquare(receiver));
            invoker.SetUpCommand(new GetFirstNApartments(receiver));
            invoker.SetUpCommand(new GetApartmentsWithRooms(receiver));
            invoker.SetUpCommand(new GetFullOffersInfo(receiver));
            invoker.SetUpCommand(new GetRealtorByAgency(receiver));
            invoker.SetUpCommand(new GetOffersByAgency(receiver));
            Menu.GenerateMenu(invoker.GetCommands());
            Menu.PrintMenu();
            int commandCount = invoker.GetCommandsCount();
            Console.WriteLine("Для закриття консолі введіть 0\n");
            while (true)
            {
                Console.Write("Запит #");
                bool flag = int.TryParse(Console.ReadLine(), out int option);
                if (!flag)
                {
                    Console.WriteLine("Введіть число\n");
                    continue;
                }
                if (option == 0)
                {
                    return;
                }
                if (option < 1 || option > commandCount)
                {
                    Console.WriteLine($"Введіть число в межах від 1 до {commandCount}\n");
                    continue;
                }
                Console.WriteLine(invoker.GetCommandName(option - 1) + ":\n");
                invoker.ExecuteCommand(option - 1);
                Console.WriteLine("\n");
            }
        }
    }
}
