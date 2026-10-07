using PassportOffice.Core.Database;
using PassportOffice.Core.Documents;
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
    public partial class MainPassportForm : Form
    {
        public MainPassportForm()
        {
            InitializeComponent();
        }
        private void RefreshLocalLogs()
        {
            if (lstLocalActivityLog != null)
            {
                lstLocalActivityLog.Items.Clear();
                foreach (var log in Logger.GetInstance().GetHistory())
                {
                    lstLocalActivityLog.Items.Add(log);
                }
            }
        }

        private void btnLoginOperator_Click(object sender, EventArgs e)
        {
            string opName = string.IsNullOrWhiteSpace(txtOperatorName.Text) ? "Оператор" : txtOperatorName.Text;
            Logger.GetInstance().Log($"Оператор '{opName}' успішно авторизувався у системі.");
            MessageBox.Show($"Оператор {opName} успішно авторизований!", "Авторизація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshLocalLogs();
        }

        private void btnFetchPassportData_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCitizenIdentifier.Text, out int citizenId))
            {
                DbManager.GetInstance().ExecuteQuery($"SELECT * FROM Passports WHERE CitizenID = {citizenId}");
                MessageBox.Show($"Дані громадянина з ID {citizenId} запитано з БД!", "Паспортні дані", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshLocalLogs();
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректний цифровий ID!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegisterAddress_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCitizenIdentifier.Text, out int citizenId))
            {
                DbManager.GetInstance().ExecuteQuery($"UPDATE Passports SET Address = 'м. Київ' WHERE CitizenID = {citizenId}");
                MessageBox.Show("Місце проживання успішно зареєстровано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshLocalLogs();
            }
        }

        private void btnGenerateCertificate_Click(object sender, EventArgs e)
        {
            string content = $"ДОВІДКА ПРО РЕЄСТРАЦІЮ МІСЦЯ ПРОЖИВАННЯ\nГромадянин ID: {txtCitizenIdentifier.Text}\nДата видачі: {DateTime.Now:dd.MM.yyyy}";
            DocumentSaver.GetInstance().SaveDocument("Dovidka.txt", content);
            Logger.GetInstance().Log($"Сформовано довідку для громадянина ID: {txtCitizenIdentifier.Text}");
            MessageBox.Show("Довідку сформовано та збережено на диск!", "Документообіг", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshLocalLogs();
        }

        private void btnOpenAuditWindow_Click(object sender, EventArgs e)
        {
            LogAuditForm auditForm = new LogAuditForm();
            auditForm.Show();
        }
    }
}
