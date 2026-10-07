using PassportOffice.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportOffice.Core.Services
{
    public class AuthService
    {
        public void Login(string username, string password)
        {
            Logger.GetInstance().Log($"Оператор '{username}' успішно авторизувався.");
        }
    }
}
