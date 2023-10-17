using Lab1_4.Interfaces;
using System;

namespace Lab1_4.Commands
{
    public class ApartmentsWithPriceHigherThan : ICommand
    {
        private readonly IReceiver receiver;

        public ApartmentsWithPriceHigherThan(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine("Введiть ціну:");
            int price = int.Parse(Console.ReadLine());

            Console.WriteLine($"Чи є квартири, ціна яких вище за {price}?");
            Console.WriteLine(receiver.ApartmentsWithPriceHigherThan(price));
        }
        public string GetCommandName()
        {
            return "Перевірка, чи є квартири, ціна яких вище за введену";
        }
    }
}
