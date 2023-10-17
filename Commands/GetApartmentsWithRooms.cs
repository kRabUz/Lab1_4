using Lab1_4.Interfaces;
using System;

namespace Lab1_4.Commands
{
    public class GetApartmentsWithRooms : ICommand
    {
        private readonly IReceiver receiver;

        public GetApartmentsWithRooms(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine("Введiть кiлькiсть кімнат: ");
            int room1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введiть кiлькiсть кімнат: ");
            int room2 = int.Parse(Console.ReadLine());

            foreach (var discipline in receiver.GetApartmentsWithRooms(room1, room2))
            {
                Console.WriteLine(discipline);
            }
        }
        public string GetCommandName()
        {
            return "Вивести квартири з різною кількістю кімнат";
        }
    }
}
