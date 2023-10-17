using Lab1_4.Classes;
using Lab1_4.TempClasses;
using System.Collections.Generic;
using System.Linq;

namespace Lab1_4.Interfaces
{
    public interface IReceiver
    {
        IEnumerable<Agency> GetAllAgencies();
        IEnumerable<Apartment> GetAllApartments();
        IEnumerable<Realtor> GetAllRealtors();
        int CountApartmentsByRooms(int room);
        IEnumerable<Apartment> GetApartmentsHigherThan(int floor);
        Apartment FirstOrDefaultSquare(double square);
        IEnumerable<Realtor> SkipRealtors(int n);
        IEnumerable<Apartment> FromHighestToLowestSquare();
        IEnumerable<Apartment> TakeWhileUsingFloor(int floor);
        double GetAverageOffersPerRealtor();
        IEnumerable<Realtor> SortByName();
        IEnumerable<Agency> ReverseAgencies();
        IEnumerable<IGrouping<int, Apartment>> GroupByRooms();
        IEnumerable<Realtor> FindWithFirstLetter(string letter);
        bool ApartmentsWithPriceHigherThan(int price);
        double TotalApartmentsSquare();
        IEnumerable<Apartment> GetFirstNApartments(int n);
        IEnumerable<Apartment> GetApartmentsWithRooms(int room1, int room2);
        IEnumerable<FullAgencyInfo> GetFullOffersInfo();
        IEnumerable<FullAgencyInfo> GetRealtorByAgency(int agencyid);
        IEnumerable<FullAgencyInfo> GetOffersByAgency(int agencyid);
    }
}
