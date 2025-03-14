using System.Collections.Generic;

namespace MyFace.Data
{
    public static class PasswordGenerator
    {
        private static readonly IList<string> Passwords = new List<string>
        {
            "password123", "123password", "coolpassword1", "passwordpassword1", "12345PassPass", "Password54321", "GetPassPassword", "GThello123", "HelloPassword", "password1",
            "password123", "123password", "coolpassword1", "passwordpassword1", "12345PassPass", "Password54321", "GetPassPassword", "GThello123", "HelloPassword", "password1",
            "password123", "123password", "coolpassword1", "passwordpassword1", "12345PassPass", "Password54321", "GetPassPassword", "GThello123", "HelloPassword", "password1",
            "password123", "123password", "coolpassword1", "passwordpassword1", "12345PassPass", "Password54321", "GetPassPassword", "GThello123", "HelloPassword", "password1",
            "password123", "123password", "coolpassword1", "passwordpassword1", "12345PassPass", "Password54321", "GetPassPassword", "GThello123", "HelloPassword", "password1",
            "password123", "123password", "coolpassword1", "passwordpassword1", "12345PassPass", "Password54321", "GetPassPassword", "GThello123", "HelloPassword", "password1",
            "password123", "123password", "coolpassword1", "passwordpassword1", "12345PassPass", "Password54321", "GetPassPassword", "GThello123", "HelloPassword", "password1",
            "password123", "123password", "coolpassword1", "passwordpassword1", "12345PassPass", "Password54321", "GetPassPassword", "GThello123", "HelloPassword", "password1",
            "password123", "123password", "coolpassword1", "passwordpassword1", "12345PassPass", "Password54321", "GetPassPassword", "GThello123", "HelloPassword", "password1",
            "password123", "123password", "coolpassword1", "passwordpassword1", "12345PassPass", "Password54321", "GetPassPassword", "GThello123", "HelloPassword", "password1"
        };

        // public static IEnumerable<Passwords> GetPosts()
        // {
        //     return Enumerable.Range(0, NumberOfPosts).Select(CreateRandomPost);
        // }

        public static string GetPassword(int index)
        {
            return Passwords[index];
        }
    }
}