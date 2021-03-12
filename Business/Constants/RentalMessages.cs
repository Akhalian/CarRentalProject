namespace Business.Constants
{
    class RentalMessages : Messages, IMessages
    {
        public static string Rental = "Kiralama";
        public static string Rentals = "Kiralamalar";

        public static string RentalAdded = $"{Rental} {Added}.";
        public static string RentalUpdated = $"{Rental} {Updated}.";
        public static string RentalDeleted = $"{Rental} {Deleted}.";
        public static string RentalsListed = $"{Rentals} {Listed}.";

        public static string GetRentDetails = $"{Rentals} {Details} {Listed}.";
    }
}
