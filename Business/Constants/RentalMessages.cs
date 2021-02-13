using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;

namespace Business.Constants
{
    class RentalMessages : IMessages
    {
        public static string RentalAdded = "Kira eklendi";
        public static string RentalUpdated = "Kira güncellendi";
        public static string RentalDeleted = "Kira silindi";
        public static string RentalsListed = "Kiralar listelendi";
    }
}
