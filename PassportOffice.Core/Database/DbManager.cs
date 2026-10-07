using PassportOffice.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportOffice.Core.Database
{
    public class DbManager
    {
        private static DbManager instance;
        private Logger logger;

        private DbManager()
        {
            logger = Logger.GetInstance();
        }

        public static DbManager GetInstance()
        {
            if (instance == null)
            {
                instance = new DbManager();
            }
            return instance;
        }

        public void ExecuteQuery(string query)
        {
            logger.Log($"[БД SQL Query]: {query}");
        }
    }
}
