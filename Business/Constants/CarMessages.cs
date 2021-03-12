namespace Business.Constants
{
    class CarMessages : Messages, IMessages
    {
        public static string Car = "Araba";
        public static string Cars = "Arabalar";

        public static string CarAdded = $"{Car} {Added}.";
        public static string CarNameInvalid = $"{Car} ismi 2 karakterden uzun olmalıdır.";
        public static string CarDailyPriceInvalid = $"{Car} günlük kira bedeli 0'dan büyük olmalıdır.";

        public static string CarUpdated = $"{Car} {Updated}.";

        public static string CarDeleted = $"{Car} {Deleted}.";

        public static string CarsListed = Cars + Listed;
        public static string CarsListedByBrandId = $"{Cars} markalara göre {Listed}.";
        public static string CarsListedByColorId = $"{Cars} renklere göre {Listed}.";
        public static string CarsListedByDailyPrice = $"{Car} fiyata göre {Listed}.";
        public static string GetCarDetails = $"{Cars} {Details} {Listed}.";
    }
}
