using Lab1_4.Interfaces;
using System;

namespace Lab1_4.Commands
{
    public class FindWithFirstLetter : ICommand
    {
        private readonly IReceiver receiver;

        public FindWithFirstLetter(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine("Введiть букву:");
            string letter = Console.ReadLine();
            Console.WriteLine($"Ріелтори, чиє iм'я починається на букву {letter}:");
            foreach (var realtor in receiver.FindWithFirstLetter(letter))
            {
                Console.WriteLine(realtor);
            }
        }
        public string GetCommandName()
        {
            return "Вивести ріелторів, чиє ім'я починається на введену букву";
        }
    }
}
