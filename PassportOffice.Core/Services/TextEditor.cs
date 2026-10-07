using PassportOffice.Core.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportOffice.Core.Services
{
    public class TextEditor
    {
        public void CreateDocument()
        {
            DocumentSaver.GetInstance().SaveDocument("Note.txt", "Чернетка документа паспортного столу.");
        }
    }
}
