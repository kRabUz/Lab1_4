using Lab1_4.Interfaces;
using System;

namespace Lab1_4.Commands
{
    public class ReverseAgencies : ICommand
    {
        private readonly IReceiver receiver;

        public ReverseAgencies(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            foreach (var agency in receiver.ReverseAgencies())
            {
                Console.WriteLine(agency);
            }
        }
        public string GetCommandName()
        {
            return "Вивести агенства в оберненому порядку";
        }
    }
}
