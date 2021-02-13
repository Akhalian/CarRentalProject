using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;

namespace Business.Constants
{
    class BrandMessages : IMessages
    {
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandsListed = "Markalar listelendi";
    }
}
