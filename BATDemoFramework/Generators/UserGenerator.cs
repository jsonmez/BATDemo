namespace BATDemoFramework.Generators
{
    public static class UserGenerator
    {
        public static User LastGeneratedUser;

        public static void Initialize()
        {
            LastGeneratedUser = null;
        }

        public static User Generate()
        {
            var user = new User
            {
                EmailAddress = EmailAddressGenerator.Generate(),
                Password = PasswordGenerator.Generate()
            };

            LastGeneratedUser = user;
            return user;
        }
    }

    public class User
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}