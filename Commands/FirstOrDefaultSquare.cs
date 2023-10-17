using Lab1_4.Interfaces;
using System;

namespace Lab1_4.Commands
{
    public class FirstOrDefaultSquare : ICommand

    {
        private readonly IReceiver receiver;

        public FirstOrDefaultSquare(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine("Введiть площу s м.кв.:");
            double square = double.Parse(Console.ReadLine());
            var apartment = receiver.FirstOrDefaultSquare(square);
            Console.WriteLine(apartment);
        }
        public string GetCommandName()
        {
            return "Вивести квартиру, площа якої дорівнює s, або першу";
        }
    }
}
