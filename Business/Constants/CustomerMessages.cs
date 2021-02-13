using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;

namespace Business.Constants
{
    class CustomerMessages : IMessages
    {
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomersListed = "Müşteriler listelendi";
    }
}
