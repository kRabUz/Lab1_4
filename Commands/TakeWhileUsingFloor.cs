using Lab1_4.Interfaces;
using System;

namespace Lab1_4.Commands
{
    public class TakeWhileUsingFloor : ICommand
    {
        private readonly IReceiver receiver;

        public TakeWhileUsingFloor(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine("Введiть поверх: ");
            int floor = int.Parse(Console.ReadLine());

            Console.WriteLine($"Послідовне виведення квартир, поки їх поверх не нижче за {floor}-й");
            foreach (var apartment in receiver.TakeWhileUsingFloor(floor))
            {
                Console.WriteLine(apartment);
            }
        }
        public string GetCommandName()
        {
            return "Послідовне виведення квартир, поки їх поверх не нижче за введений";
        }
    }
}
