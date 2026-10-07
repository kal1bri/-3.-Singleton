using PassportOffice.Core.Documents;
using PassportOffice.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportOffice.Core.Services
{
    public class ReportGenerator
    {
        public void CreateReport(string citizenName, string details)
        {
            string content = $"ДОВІДКА ПАСПОРТНОГО СТОЛА\nГромадянин: {citizenName}\nІнформація: {details}";
            DocumentSaver.GetInstance().SaveDocument("Spravka.txt", content);
            Logger.GetInstance().Log($"Сформовано довідку для: {citizenName}");
        }
    }
}
