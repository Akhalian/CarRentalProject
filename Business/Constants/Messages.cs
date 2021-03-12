using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages : IMessages
    {
        public static string Added = "eklendi";
        public static string Updated = "güncellendi";
        public static string Deleted = "silindi";
        public static string Listed = "listelendi";
        public static string Details = "detaylarıyla ";

        public static string AlreadyExists = "mevcut";
        public static string NotFound = "bulunamadı";

        public static string Denied = "reddedildi";

    }
}
