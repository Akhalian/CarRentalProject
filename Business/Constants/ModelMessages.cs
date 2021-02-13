using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;

namespace Business.Constants
{
    class ModelMessages : IMessages
    {
        public static string ModelAdded = "Model eklendi";
        public static string ModelUpdated = "Model güncellendi";
        public static string ModelDeleted = "Model silindi";
        public static string ModelsListed = "Modeller listelendi";
    }
}
