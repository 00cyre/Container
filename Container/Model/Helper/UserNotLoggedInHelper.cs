using System.Security.Cryptography;
using System.Text;

namespace Container.Model.Helper

{
    class UserNotLoggedInHelper : UserNotLoggedIn
    {
        public static bool validarParametrosLogin(string email, string senha)
        {
            return !email.Contains("--");
        }

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("X2"));
            }
            return sBuilder.ToString();
        }
    }
}
