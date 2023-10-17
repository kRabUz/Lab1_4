using Lab1_4.Interfaces;
using System;

namespace Lab1_4.Commands
{
    public class FromHighestToLowestSquare : ICommand
    {
        private readonly IReceiver receiver;

        public FromHighestToLowestSquare(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            foreach (var apartment in receiver.FromHighestToLowestSquare())
            {
                Console.WriteLine(apartment);
            }
        }
        public string GetCommandName()
        {
            return "Відсортувати квартири за спаданням їх площ";
        }
    }
}
