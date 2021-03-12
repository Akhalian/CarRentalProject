namespace Business.Constants
{
    class ColorMessages : Messages, IMessages
    {
        public static string Color = "Renk";
        public static string Colors = "Renkler";

        public static string ColorAdded = $"{Color} {Added}.";
        public static string ColorUpdated = $"{Color} {Updated}.";
        public static string ColorDeleted = $"{Color} {Deleted}.";
        public static string ColorsListed = $"{Colors} {Listed}.";
    }
}
