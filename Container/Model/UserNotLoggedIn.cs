using System;
using System.Security.Cryptography;
using Container.Model.Helper;

namespace Container.Model
{
    class UserNotLoggedIn
    {
        public bool logarUsuario(string email, string senha)
        {
            if (!UserNotLoggedInHelper.validarParametrosLogin(email, senha))
            {
                return false;
            }
            using (MD5 md5 = MD5.Create())
            {
                senha = UserNotLoggedInHelper.GetMd5Hash(md5, senha);

            }
            string sucess = Database.selectSingleValue("empresa", $"email='{email}' AND senha='{senha}'");
            return Convert.ToInt32(sucess) > 0;
        }
    }
}
