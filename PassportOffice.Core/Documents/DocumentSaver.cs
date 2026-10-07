using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportOffice.Core.Documents
{
    public class DocumentSaver
    {
        private static DocumentSaver instance;

        private DocumentSaver() { }

        public static DocumentSaver GetInstance()
        {
            if (instance == null)
            {
                instance = new DocumentSaver();
            }
            return instance;
        }

        public void SaveDocument(string name, string content)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, name);
            File.WriteAllText(path, content);
        }
    }
}
