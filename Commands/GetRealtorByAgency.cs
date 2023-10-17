using Lab1_4.Interfaces;
using System;

namespace Lab1_4.Commands
{
    public class GetRealtorByAgency : ICommand
    {
        private readonly IReceiver receiver;

        public GetRealtorByAgency(IReceiver receiver)
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

            foreach (var realtor in receiver.GetRealtorByAgency(agencyid))
            {
                Console.WriteLine($"{realtor.RealtorName}, номер - телефону {realtor.RealtorPhoneNumber}");
            }
        }
        public string GetCommandName()
        {
            return "Виведення ріелторів за агенством";
        }
    }
}
