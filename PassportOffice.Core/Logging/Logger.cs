using PassportOffice.Core.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassportOffice.Core.Documents;

namespace PassportOffice.Core.Logging
{
    public class Logger
    {
        private static Logger instance;
        private string filePath;
        private DocumentSaver documentSaver;
        private List<string> logHistory;

        private Logger()
        {
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "system.log");
            documentSaver = DocumentSaver.GetInstance();
            logHistory = new List<string>();
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        public void Log(string message)
        {
            string logEntry = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] {message}";
            logHistory.Add(logEntry);

            File.AppendAllText(filePath, logEntry + Environment.NewLine);
            documentSaver.SaveDocument("last_action.txt", logEntry);
        }

        public List<string> GetHistory()
        {
            return new List<string>(logHistory);
        }
    }
}
