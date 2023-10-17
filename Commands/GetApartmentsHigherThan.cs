using Lab1_4.Interfaces;
using System;

namespace Lab1_4.Commands
{
    public class GetApartmentsHigherThan : ICommand
    {
        private readonly IReceiver receiver;

        public GetApartmentsHigherThan(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine("Введiть поверх:");
            int floor = int.Parse(Console.ReadLine());

            Console.WriteLine($"Квартири, котрі вище за {floor} поверх:");
            foreach (var apartment in receiver.GetApartmentsHigherThan(floor))
            {
                Console.WriteLine($"{apartment.Address}, {apartment.Floor}-й поверх");
            }
        }
        public string GetCommandName()
        {
            return "Вивести квартири, котрі вище за n поверх";
        }
    }
}
