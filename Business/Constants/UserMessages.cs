namespace Business.Constants
{
    class UserMessages : Messages, IMessages
    {
        public static string User = "Kullanıcı";
        public static string Users = "Kullanıcılar";

        public static string UserAdded = $"{User} {Added}.";
        public static string UserUpdated = $"{User} {Updated}.";
        public static string UserDeleted = $"{User} {Deleted}.";
        public static string UsersListed = $"{Users} {Listed}.";

        public static string UserNotFound = $"{User} {NotFound}";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = $"{User} {AlreadyExists}";

        public static string UserRegistered = User + Added;
        public static string AccessTokenCreated = "Access token oluşturuldu";
    };
}
