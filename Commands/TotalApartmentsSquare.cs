using Lab1_4.Interfaces;
using System;

namespace Lab1_4.Commands
{
    public class TotalApartmentsSquare : ICommand
    {
        private readonly IReceiver receiver;

        public TotalApartmentsSquare(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine($"{receiver.TotalApartmentsSquare()} м.кв.");
        }
        public string GetCommandName()
        {
            return "Вивести загальну площу всіх квартир";
        }
    }
}
