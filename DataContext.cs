using Lab1_4.Classes;
using Lab1_4.Interfaces;
using System.Collections.Generic;

namespace Lab1_4
{
    public class DataContext : IDataContext
    {
        public IEnumerable<Agency> Agencies => new List<Agency>
        {
            new Agency
            {
                Id = 1,
                Name = "Доля",
                Address = "вул.Шевченка 113",
            },
            new Agency
            {
                Id = 2,
                Name = "Революціонер",
                Address = "вул.Франка 14",
            },
            new Agency
            {
                Id = 3,
                Name = "Жабаки",
                Address = "вул.Жадана 88",
            },
        };
        public IEnumerable<Realtor> Realtors => new List<Realtor>
        {
            new Realtor
            {
                Id = 1,
                AgencyId = 1,
                Name = "Підручний М.О.",
                PhoneNumber = "0951234567",
            },
            new Realtor
            {
                Id = 2,
                AgencyId = 1,
                Name = "Мудрик Д.А.",
                PhoneNumber = "0669876543",
            },
            new Realtor
            {
                Id = 3,
                AgencyId = 1,
                Name = "Ярмоленко Є.Є.",
                PhoneNumber = "0972345678",
            },
            new Realtor
            {
                Id = 4,
                AgencyId = 2,
                Name = "Довбик М.К.",
                PhoneNumber = "0738765432",
            },
            new Realtor
            {
                Id = 5,
                AgencyId = 2,
                Name = "Забарний І.В.",
                PhoneNumber = "0683456789",
            },
            new Realtor
            {
                Id = 6,
                AgencyId = 2,
                Name = "Мороз А.А.",
                PhoneNumber = "0997654321",
            },
            new Realtor
            {
                Id = 7,
                AgencyId = 3,
                Name = "Усик О.М.",
                PhoneNumber = "0674567890",
            },
            new Realtor
            {
                Id = 8,
                AgencyId = 3,
                Name = "Джима Ю.А.",
                PhoneNumber = "0965432109",
            },
            new Realtor
            {
                Id = 9,
                AgencyId = 3,
                Name = "Оруджев В.М.",
                PhoneNumber = "0985678901",
            },
        };
        public IEnumerable<Offer> Offers => new List<Offer>
        {
            new Offer
            {
                Id = 1,
                RealtorId = 1,
                ApartmentId = 1,
                Price = 130000
            },
            new Offer
            {
                Id = 2,
                RealtorId = 1,
                ApartmentId = 2,
                Price = 86000
            },
            new Offer
            {
                Id = 3,
                RealtorId = 1,
                ApartmentId = 3,
                Price = 180000
            },
            new Offer
            {
                Id = 4,
                RealtorId = 2,
                ApartmentId = 4,
                Price = 176000
            },
            new Offer
            {
                Id = 5,
                RealtorId = 2,
                ApartmentId = 5,
                Price = 134000
            },
            new Offer
            {
                Id = 6,
                RealtorId = 2,
                ApartmentId = 6,
                Price = 90000
            },
            new Offer
            {
                Id = 7,
                RealtorId = 3,
                ApartmentId = 7,
                Price = 140000
            },
            new Offer
            {
                Id = 8,
                RealtorId = 3,
                ApartmentId = 8,
                Price = 172000
            },
            new Offer
            {
                Id = 9,
                RealtorId = 3,
                ApartmentId = 9,
                Price = 136000
            },
            new Offer
            {
                Id = 10,
                RealtorId = 4,
                ApartmentId = 10,
                Price = 128000
            },
            new Offer
            {
                Id = 11,
                RealtorId = 4,
                ApartmentId = 11,
                Price = 89000
            },
            new Offer
            {
                Id = 12,
                RealtorId = 4,
                ApartmentId = 12,
                Price = 178000
            },
            new Offer
            {
                Id = 13,
                RealtorId = 5,
                ApartmentId = 13,
                Price = 142000
            },
            new Offer
            {
                Id = 14,
                RealtorId = 5,
                ApartmentId = 14,
                Price = 129500
            },
            new Offer
            {
                Id = 15,
                RealtorId = 5,
                ApartmentId = 15,
                Price = 98000
            },
            new Offer
            {
                Id = 16,
                RealtorId = 6,
                ApartmentId = 16,
                Price = 142000
            },
            new Offer
            {
                Id = 17,
                RealtorId = 6,
                ApartmentId = 17,
                Price = 168000
            },
            new Offer
            {
                Id = 18,
                RealtorId = 9,
                ApartmentId = 18,
                Price = 138000
            },
            new Offer
            {
                Id = 19,
                RealtorId = 7,
                ApartmentId = 19,
                Price = 88000
            },
            new Offer
            {
                Id = 20,
                RealtorId = 7,
                ApartmentId = 20,
                Price = 170000
            },
            new Offer
            {
                Id = 21,
                RealtorId = 7,
                ApartmentId = 21,
                Price = 135500
            },
            new Offer
            {
                Id = 22,
                RealtorId = 8,
                ApartmentId = 22,
                Price = 135000
            },
            new Offer
            {
                Id = 23,
                RealtorId = 8,
                ApartmentId = 23,
                Price = 138000
            },
            new Offer
            {
                Id = 24,
                RealtorId = 8,
                ApartmentId = 24,
                Price = 175000
            },
            new Offer
            {
                Id = 25,
                RealtorId = 6,
                ApartmentId = 5,
                Price = 133000
            },
            new Offer
            {
                Id = 26,
                RealtorId = 9,
                ApartmentId = 6,
                Price = 88000
            },
            new Offer
            {
                Id = 27,
                RealtorId = 1,
                ApartmentId = 23,
                Price = 135000
            },
        };
        public IEnumerable<Apartment> Apartments => new List<Apartment>
        {
            new Apartment
            {
                Id = 1,
                Address = "вул.Коваленка 19",
                Floor = 2,
                Square = 65,
                Rooms = 2
            },
            new Apartment
            {
                Id = 2,
                Address = "вул.Мазепи 73",
                Floor = 5,
                Square = 43,
                Rooms = 1
            },
            new Apartment
            {
                Id = 3,
                Address = "вул.Зеленського 95",
                Floor = 3,
                Square = 90,
                Rooms = 3
            },
            new Apartment
            {
                Id = 4,
                Address = "вул.Ткача 32",
                Floor = 9,
                Square = 88,
                Rooms = 3
            },
            new Apartment
            {
                Id = 5,
                Address = "вул.Монастирська 4",
                Floor = 7,
                Square = 67,
                Rooms = 2
            },
            new Apartment
            {
                Id = 6,
                Address = "вул.Банкова 35",
                Floor = 4,
                Square = 45,
                Rooms = 1
            },
            new Apartment
            {
                Id = 7,
                Address = "вул.Джонсонюка 47",
                Floor = 4,
                Square = 70,
                Rooms = 2
            },
            new Apartment
            {
                Id = 8,
                Address = "вул.Львівська 12",
                Floor = 6,
                Square = 86,
                Rooms = 3
            },
            new Apartment
            {
                Id = 9,
                Address = "вул.Бандери 88",
                Floor = 8,
                Square = 68,
                Rooms = 2
            },
            new Apartment
            {
                Id = 10,
                Address = "вул.Коваленка 35",
                Floor = 4,
                Square = 64,
                Rooms = 2
            },
            new Apartment
            {
                Id = 11,
                Address = "вул.Мазепи 23",
                Floor = 5,
                Square = 45,
                Rooms = 1
            },
            new Apartment
            {
                Id = 12,
                Address = "вул.Зеленського 96",
                Floor = 8,
                Square = 89,
                Rooms = 3
            },
            new Apartment
            {
                Id = 13,
                Address = "вул.Ткача 33",
                Floor = 1,
                Square = 71,
                Rooms = 2
            },
            new Apartment
            {
                Id = 14,
                Address = "вул.Монастирська 41",
                Floor = 4,
                Square = 65,
                Rooms = 2
            },
            new Apartment
            {
                Id = 15,
                Address = "вул.Банкова 95",
                Floor = 5,
                Square = 49,
                Rooms = 1
            },
            new Apartment
            {
                Id = 16,
                Address = "вул.Джонсонюка 72",
                Floor = 6,
                Square = 71,
                Rooms = 2
            },
            new Apartment
            {
                Id = 17,
                Address = "вул.Львівська 19",
                Floor = 3,
                Square = 84,
                Rooms = 3
            },
            new Apartment
            {
                Id = 18,
                Address = "вул.Бандери 14",
                Floor = 5,
                Square = 69,
                Rooms = 2
            },
            new Apartment
            {
                Id = 19,
                Address = "вул.Мазепи 35",
                Floor = 5,
                Square = 44,
                Rooms = 1
            },
            new Apartment
            {
                Id = 20,
                Address = "вул.Зеленського 17",
                Floor = 4,
                Square = 85,
                Rooms = 3
            },
            new Apartment
            {
                Id = 21,
                Address = "вул.Ткача 36",
                Floor = 9,
                Square = 68,
                Rooms = 2
            },
            new Apartment
            {
                Id = 22,
                Address = "вул.Монастирська 14",
                Floor = 5,
                Square = 68,
                Rooms = 2
            },
            new Apartment
            {
                Id = 23,
                Address = "вул.Джонсонюка 49",
                Floor = 6,
                Square = 69,
                Rooms = 2
            },
            new Apartment
            {
                Id = 24,
                Address = "вул.Львівська 22",
                Floor = 3,
                Square = 88,
                Rooms = 3
            },
        };
    }
}
