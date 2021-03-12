namespace Business.Constants
{
    class BrandMessages : Messages, IMessages
    {
        public static string Brand = "Marka";
        public static string Brands = "Markalar";

        public static string BrandAdded = $"{Brand} {Added}.";
        public static string BrandUpdated = $"{Brand} {Updated}.";
        public static string BrandDeleted = $"{Brand} {Deleted}.";
        public static string BrandsListed = $"{Brands} {Listed}.";
    }
}
