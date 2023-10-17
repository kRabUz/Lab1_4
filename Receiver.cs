using Lab1_4.Classes;
using Lab1_4.Interfaces;
using Lab1_4.TempClasses;
using System.Collections.Generic;
using System.Linq;

namespace Lab1_4
{
    public class Receiver : IReceiver
    {
        private readonly IDataContext context;

        public Receiver(IDataContext context)
        {
            this.context = context;
        }
        public IEnumerable<Agency> GetAllAgencies()
        {
            return context.Agencies;
        }
        public IEnumerable<Apartment> GetAllApartments()
        {
            return context.Apartments;
        }
        public IEnumerable<Realtor> GetAllRealtors()
        {
            return context.Realtors;
        }

        public int CountApartmentsByRooms(int room)
        {
            return context.Apartments
            .Count(apartment => apartment.Rooms == room);
        }

        public IEnumerable<Apartment> GetApartmentsHigherThan(int floor)
        {
            return context.Apartments
            .Where(apartment => apartment.Floor > floor)
            .OrderBy(apartment => apartment.Floor);
        }

        public Apartment FirstOrDefaultSquare(double square)
        {
            return context.Apartments.FirstOrDefault(s => s.Square == square) ?? context.Apartments.FirstOrDefault();
        }

        public IEnumerable<Realtor> SkipRealtors(int n)
        {
            return context.Realtors.Skip(n);
        }

        public IEnumerable<Apartment> FromHighestToLowestSquare()
        {
            return context.Apartments.OrderByDescending(s => s.Square);
        }

        public IEnumerable<Apartment> TakeWhileUsingFloor(int floor)
        {
            return context.Apartments.TakeWhile(d => d.Floor >= floor);
        }

        public double GetAverageOffersPerRealtor()
        {
            return context.Realtors
                .Select(realtor => new
                {
                    RealtorName = realtor.Name,
                    OfferCount = context.Offers.Count(offer => offer.RealtorId == realtor.Id)
                })
                .Average(result => result.OfferCount); ;
        }

        public IEnumerable<Realtor> SortByName()
        {
            return context.Realtors.OrderBy(d => d.Name);
        }

        public IEnumerable<Agency> ReverseAgencies()
        {
            return context.Agencies.Reverse();
        }

        public IEnumerable<IGrouping<int, Apartment>> GroupByRooms()
        {
            return from a in context.Apartments
                   group a by a.Rooms;
        }

        public IEnumerable<Realtor> FindWithFirstLetter(string letter)
        {
            return context.Realtors.Where(realtor => realtor.Name.StartsWith(letter));
        }

        public bool ApartmentsWithPriceHigherThan(int price)
        {
            var q = context.Apartments.Join(context.Offers, a => a.Id, o => o.ApartmentId,
                (a, o) => new
                {
                    Price = o.Price
                });
            return q.Any(a => a.Price > price);
        }

        public double TotalApartmentsSquare()
        {
            return context.Apartments.Sum(apartment => apartment.Square);
        }

        public IEnumerable<Apartment> GetFirstNApartments(int n)
        {
            return context.Apartments.Take(n);
        }

        public IEnumerable<Apartment> GetApartmentsWithRooms(int room1, int room2)
        {
            var q1 = context.Apartments.Where(d => d.Rooms == room1);
            var q2 = context.Apartments.Where(d => d.Rooms == room2);

            return q1.Concat(q2);
        }

        public IEnumerable<FullAgencyInfo> GetFullOffersInfo()
        {
            return from apartment in context.Apartments
                   join offer in context.Offers
                        on apartment.Id equals offer.ApartmentId
                   select new FullAgencyInfo
                   {
                       OfferId = offer.Id,
                       ApartmentAddress = apartment.Address,
                       Floor = apartment.Floor,
                       Square = apartment.Square,
                       Rooms = apartment.Rooms,
                       Price = offer.Price
                   };
        }

        public IEnumerable<FullAgencyInfo> GetRealtorByAgency(int agencyid)
        {
            return from agency in context.Agencies
                   join realtor in context.Realtors
                        on agency.Id equals realtor.AgencyId
                   where agency.Id == agencyid
                   select new FullAgencyInfo
                   {
                       Id = agency.Id,
                       RealtorName = realtor.Name,
                       RealtorPhoneNumber = realtor.PhoneNumber
                   };
        }
        public IEnumerable<FullAgencyInfo> GetOffersByAgency(int agencyid)
        {
            return from agency in context.Agencies
                   join realtor in context.Realtors
                        on agency.Id equals realtor.AgencyId
                   join offer in context.Offers
                        on realtor.Id equals offer.RealtorId
                   join apartment in context.Apartments
                        on offer.ApartmentId equals apartment.Id
                   where agency.Id == agencyid
                   select new FullAgencyInfo
                   {
                       Id = agency.Id,
                       OfferId = offer.Id,
                       ApartmentAddress = apartment.Address,
                       Floor = apartment.Floor,
                       Square = apartment.Square,
                       Rooms = apartment.Rooms,
                       Price = offer.Price
                   };
        }
    }
}
