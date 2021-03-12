namespace Business.Constants
{
    class CustomerMessages : Messages, IMessages
    {
        public static string Customer = "Müşteri";
        public static string Customers = "Müşteriler";

        public static string CustomerAdded = $"{Customer} {Added}.";
        public static string CustomerUpdated = $"{Customer} {Updated}.";
        public static string CustomerDeleted = $"{Customer} {Deleted}.";
        public static string CustomersListed = $"{Customers} {Listed}.";
        public static string GetCustomerDetails = $"{Customers} {Details} {Listed}.";
    }
}
