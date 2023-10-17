using Lab1_4.Interfaces;
using System;

namespace Lab1_4.Commands
{
    public class GetFullOffersInfo : ICommand
    {
        private readonly IReceiver receiver;

        public GetFullOffersInfo(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine($"Список пропозицій:");
            foreach (var offer in receiver.GetFullOffersInfo())
            {
                Console.WriteLine($"{offer.ApartmentAddress}, площа - {offer.Square} м.кв., {offer.Rooms} кімнат, ціна - {offer.Price} $");
            }
        }
        public string GetCommandName()
        {
            return "Перегляд повної інформації про пропозиції";
        }
    }
}
