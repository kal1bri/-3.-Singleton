using PassportOffice.Core.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportOffice.Core.Services
{
    public class UserRepository
    {
        public void GetUser(int id)
        {
            DbManager.GetInstance().ExecuteQuery($"SELECT * FROM Passports WHERE CitizenID = {id}");
        }
    }
}
