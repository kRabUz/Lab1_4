using Lab1_4.Classes;
using System.Collections.Generic;

namespace Lab1_4.Interfaces
{
    public interface IDataContext
    {
        IEnumerable<Agency> Agencies { get; }
        IEnumerable<Realtor> Realtors { get; }
        IEnumerable<Apartment> Apartments { get; }
        IEnumerable<Offer> Offers { get; }
    }
}
