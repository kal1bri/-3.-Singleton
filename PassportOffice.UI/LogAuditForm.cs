using PassportOffice.Core.Database;
using PassportOffice.Core.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassportOffice.UI
{
    public partial class LogAuditForm : Form
    {
        public LogAuditForm()
        {
            InitializeComponent();
        }
        private void RefreshLogs()
        {
            if (lstGlobalSystemLog != null)
            {
                lstGlobalSystemLog.Items.Clear();
                foreach (var logEntry in Logger.GetInstance().GetHistory())
                {
                    lstGlobalSystemLog.Items.Add(logEntry);
                }
            }
        }

        private void LogAuditForm_Load(object sender, EventArgs e)
        {
            RefreshLogs();
        }

        private void btnExecuteDatabaseQuery_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCustomSqlQuery.Text))
            {
                DbManager.GetInstance().ExecuteQuery(txtCustomSqlQuery.Text);
                MessageBox.Show("Запит успішно виконано та зафіксовано у журналі!", "База даних", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshLogs();
            }
        }

        private void btnRefreshLogStream_Click(object sender, EventArgs e)
        {
            RefreshLogs();
        }
    }
}