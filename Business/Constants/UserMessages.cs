using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;

namespace Business.Constants
{
    class UserMessages : IMessages
    {
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UsersListed = "Kullanıcılar listelendi";
    }
}
