using Lab1_4.Interfaces;
using System;

namespace Lab1_4.Commands
{
    public class GetAllApartments : ICommand
    {
        private readonly IReceiver receiver;

        public GetAllApartments(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            foreach (var apartment in receiver.GetAllApartments())
            {
                Console.WriteLine(apartment);
            }
        }
        public string GetCommandName()
        {
            return "Вивести список квартир";
        }
    }
}
