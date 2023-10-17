using Lab1_4.Interfaces;
using System;

namespace Lab1_4.Commands
{
    public class CountApartmentsByRooms : ICommand
    {
        private readonly IReceiver receiver;

        public CountApartmentsByRooms(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine("Введiть кількість квартир:");
            int room = int.Parse(Console.ReadLine());

            Console.WriteLine($"Кількість квартир, в яких {room} кімнат: ");
            Console.WriteLine(receiver.CountApartmentsByRooms(room));
        }

        public string GetCommandName()
        {
            return "Вивести кількість квартир за кількістю кімнат";
        }
    }
}
