using PassportOffice.Core.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportOffice.Core.Services
{
    public class OrderRepository
    {
        public void GetOrder(int id)
        {
            DbManager.GetInstance().ExecuteQuery($"SELECT * FROM Orders WHERE OrderID = {id}");
        }
    }
}
