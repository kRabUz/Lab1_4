using Lab1_4.Interfaces;
using System;

namespace Lab1_4.Commands
{
    public class SkipRealtors : ICommand
    {
        private readonly IReceiver receiver;

        public SkipRealtors(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine("Введiть n:");
            int n = int.Parse(Console.ReadLine());
            foreach (var realtor in receiver.SkipRealtors(n))
            {
                Console.WriteLine(realtor);
            }
        }
        public string GetCommandName()
        {
            return "Вивести список ріелторів, пропустивши перших n";
        }
    }
}
