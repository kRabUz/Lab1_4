using Lab1_4.Interfaces;
using System;

namespace Lab1_4.Commands
{
    public class GetAllRealtors : ICommand
    {
        private readonly IReceiver receiver;

        public GetAllRealtors(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            foreach (var realtor in receiver.GetAllRealtors())
            {
                Console.WriteLine(realtor);
            }
        }
        public string GetCommandName()
        {
            return "Вивести список ріелторів";
        }
    }
}
