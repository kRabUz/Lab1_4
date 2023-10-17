using Lab1_4.Interfaces;
using System;

namespace Lab1_4.Commands
{
    public class GetOffersByAgency : ICommand
    {
        private readonly IReceiver receiver;

        public GetOffersByAgency(IReceiver receiver)
        {
            this.receiver = receiver;
        }
        public void Execute()
        {
            foreach (var agency in receiver.GetAllAgencies())
            {
                Console.WriteLine(agency);
            }
            Console.WriteLine("Введiть номер агенства:");
            int agencyid = int.Parse(Console.ReadLine());

            foreach (var agency in receiver.GetOffersByAgency(agencyid))
            {
                Console.WriteLine($"{agency.ApartmentAddress}, площа - {agency.Square} м.кв., {agency.Rooms} кімнат, ціна - {agency.Price} $");
            }
        }
        public string GetCommandName()
        {
            return "Виведення пропозицій за агенством";
        }
    }
}
