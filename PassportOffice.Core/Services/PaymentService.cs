using PassportOffice.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportOffice.Core.Services
{
    public class PaymentService
    {
        public void ProcessPayment(double amount)
        {
            Logger.GetInstance().Log($"Оплачено державне мито: {amount} грн.");
        }
    }
}
