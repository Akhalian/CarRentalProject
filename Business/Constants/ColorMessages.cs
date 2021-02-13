using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;

namespace Business.Constants
{
    class ColorMessages : IMessages
    {
        public static string ColorAdded = "Renk eklendi.";
        public static string ColorUpdated = "Renk güncellendi.";
        public static string ColorDeleted = "Renk silindi.";
        public static string ColorsListed = "Renkler listelendi";
    }
}
