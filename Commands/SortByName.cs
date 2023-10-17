using Lab1_4.Interfaces;
using System;

namespace Lab1_4.Commands
{
    public class SortByName : ICommand
    {
        private readonly IReceiver receiver;

        public SortByName(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            foreach (var realtor in receiver.SortByName())
            {
                Console.WriteLine(realtor);
            }
        }
        public string GetCommandName()
        {
            return "Відсортувати ріелторів за ім'ям";
        }
    }
}
