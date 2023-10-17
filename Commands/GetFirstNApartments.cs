using Lab1_4.Interfaces;
using System;

namespace Lab1_4.Commands
{
    public class GetFirstNApartments : ICommand
    {
        private readonly IReceiver receiver;

        public GetFirstNApartments(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine("Введiть кількість квартир:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Перші {n} квартир:");
            foreach (var apartment in receiver.GetFirstNApartments(n))
            {
                Console.WriteLine(apartment);
            }
        }
        public string GetCommandName()
        {
            return "Вивести перших n квартир";
        }
    }
}
