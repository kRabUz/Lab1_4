using Lab1_4.Interfaces;
using System;

namespace Lab1_4.Commands
{
    public class GetAverageOffersPerRealtor : ICommand
    {
        private readonly IReceiver receiver;

        public GetAverageOffersPerRealtor(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine(receiver.GetAverageOffersPerRealtor());
        }
        public string GetCommandName()
        {
            return "Вивести середню кількість пропозицій в ріелторів";
        }
    }
}
