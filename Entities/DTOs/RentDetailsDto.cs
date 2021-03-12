using System;
using Core.Entities;

namespace Entities.DTOs
{
    public class RentDetailsDto : IDtos
    {
        public int RentalId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string CustomerName { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
    }
}
