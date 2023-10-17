using Lab1_4.Interfaces;
using System;
using System.Linq;

namespace Lab1_4.Commands
{
    public class GroupByRooms : ICommand
    {
        private readonly IReceiver receiver;

        public GroupByRooms(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            foreach (var group in receiver.GroupByRooms().OrderBy(group => group.Key))
            {
                Console.WriteLine(group.Key);
                foreach (var apartment in group)
                {
                    Console.WriteLine(apartment);
                }
            }
        }
        public string GetCommandName()
        {
            return "Вивести квартири за кількістю кімнат";
        }
    }
}
