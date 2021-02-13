using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;

namespace Business.Constants
{
    class CarMessages : IMessages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string CarNameInvalid = "Arabanın ismi 2 karakterden uzun olmalıdır.";
        public static string CarDailyPriceInvalid = "Arabanın günlük kira bedeli 0'dan büyük olmalıdır.";

        public static string CarUpdated = "Araba güncellendi.";

        public static string CarDeleted = "Araba silindi.";

        public static string CarsListed = "Arabalar listelendi";
        public static string CarsListedByBrandId = "Markalara göre arabalar listelendi.";
        public static string CarsListedByColorId = "Renklere göre arabalar listelendi.";
        public static string CarsListedByDailyPrice = "Günlük fiyata göre arabalar listelendi.";

        public static string CarsRentDetailsDto = "Arabalar detaylarıyla listelendi.";
    }
}
