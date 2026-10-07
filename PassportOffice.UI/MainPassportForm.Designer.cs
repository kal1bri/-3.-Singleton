namespace PassportOffice.UI
{
    partial class MainPassportForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAuthentication = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOperatorName = new System.Windows.Forms.TextBox();
            this.btnLoginOperator = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpPassportManagement = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCitizenIdentifier = new System.Windows.Forms.TextBox();
            this.btnFetchPassportData = new System.Windows.Forms.Button();
            this.btnRegisterAddress = new System.Windows.Forms.Button();
            this.grpDocumentExport = new System.Windows.Forms.GroupBox();
            this.btnGenerateCertificate = new System.Windows.Forms.Button();
            this.grpSystemMonitoring = new System.Windows.Forms.GroupBox();
            this.lstLocalActivityLog = new System.Windows.Forms.ListBox();
            this.btnOpenAuditWindow = new System.Windows.Forms.Button();
            this.grpAuthentication.SuspendLayout();
            this.grpPassportManagement.SuspendLayout();
            this.grpDocumentExport.SuspendLayout();
            this.grpSystemMonitoring.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAuthentication
            // 
            this.grpAuthentication.Controls.Add(this.groupBox1);
            this.grpAuthentication.Controls.Add(this.btnLoginOperator);
            this.grpAuthentication.Controls.Add(this.txtOperatorName);
            this.grpAuthentication.Controls.Add(this.label1);
            this.grpAuthentication.Location = new System.Drawing.Point(12, 12);
            this.grpAuthentication.Name = "grpAuthentication";
            this.grpAuthentication.Size = new System.Drawing.Size(228, 179);
            this.grpAuthentication.TabIndex = 0;
            this.grpAuthentication.TabStop = false;
            this.grpAuthentication.Text = "Авторизація оператора";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оператор:";
            // 
            // txtOperatorName
            // 
            this.txtOperatorName.Location = new System.Drawing.Point(10, 70);
            this.txtOperatorName.Name = "txtOperatorName";
            this.txtOperatorName.Size = new System.Drawing.Size(145, 26);
            this.txtOperatorName.TabIndex = 1;
            this.txtOperatorName.Text = "Иванов И.И.";
            // 
            // btnLoginOperator
            // 
            this.btnLoginOperator.Location = new System.Drawing.Point(6, 102);
            this.btnLoginOperator.Name = "btnLoginOperator";
            this.btnLoginOperator.Size = new System.Drawing.Size(149, 33);
            this.btnLoginOperator.TabIndex = 2;
            this.btnLoginOperator.Text = "Авторизуватися";
            this.btnLoginOperator.UseVisualStyleBackColor = true;
            this.btnLoginOperator.Click += new System.EventHandler(this.btnLoginOperator_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(234, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // grpPassportManagement
            // 
            this.grpPassportManagement.Controls.Add(this.btnRegisterAddress);
            this.grpPassportManagement.Controls.Add(this.btnFetchPassportData);
            this.grpPassportManagement.Controls.Add(this.txtCitizenIdentifier);
            this.grpPassportManagement.Controls.Add(this.label2);
            this.grpPassportManagement.Location = new System.Drawing.Point(252, 12);
            this.grpPassportManagement.Name = "grpPassportManagement";
            this.grpPassportManagement.Size = new System.Drawing.Size(304, 179);
            this.grpPassportManagement.TabIndex = 1;
            this.grpPassportManagement.TabStop = false;
            this.grpPassportManagement.Text = "Облік паспортних даних";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Громадянина:";
            // 
            // txtCitizenIdentifier
            // 
            this.txtCitizenIdentifier.Location = new System.Drawing.Point(10, 70);
            this.txtCitizenIdentifier.Name = "txtCitizenIdentifier";
            this.txtCitizenIdentifier.Size = new System.Drawing.Size(100, 26);
            this.txtCitizenIdentifier.TabIndex = 1;
            this.txtCitizenIdentifier.Text = "101";
            // 
            // btnFetchPassportData
            // 
            this.btnFetchPassportData.Location = new System.Drawing.Point(10, 102);
            this.btnFetchPassportData.Name = "btnFetchPassportData";
            this.btnFetchPassportData.Size = new System.Drawing.Size(178, 33);
            this.btnFetchPassportData.TabIndex = 2;
            this.btnFetchPassportData.Text = "Запитати дані (БД)";
            this.btnFetchPassportData.UseVisualStyleBackColor = true;
            this.btnFetchPassportData.Click += new System.EventHandler(this.btnFetchPassportData_Click);
            // 
            // btnRegisterAddress
            // 
            this.btnRegisterAddress.Location = new System.Drawing.Point(10, 140);
            this.btnRegisterAddress.Name = "btnRegisterAddress";
            this.btnRegisterAddress.Size = new System.Drawing.Size(282, 33);
            this.btnRegisterAddress.TabIndex = 3;
            this.btnRegisterAddress.Text = "Зареєструвати місце проживання";
            this.btnRegisterAddress.UseVisualStyleBackColor = true;
            this.btnRegisterAddress.Click += new System.EventHandler(this.btnRegisterAddress_Click);
            // 
            // grpDocumentExport
            // 
            this.grpDocumentExport.Controls.Add(this.btnGenerateCertificate);
            this.grpDocumentExport.Location = new System.Drawing.Point(12, 197);
            this.grpDocumentExport.Name = "grpDocumentExport";
            this.grpDocumentExport.Size = new System.Drawing.Size(228, 107);
            this.grpDocumentExport.TabIndex = 2;
            this.grpDocumentExport.TabStop = false;
            this.grpDocumentExport.Text = "Формування документів";
            // 
            // btnGenerateCertificate
            // 
            this.btnGenerateCertificate.Location = new System.Drawing.Point(6, 36);
            this.btnGenerateCertificate.Name = "btnGenerateCertificate";
            this.btnGenerateCertificate.Size = new System.Drawing.Size(182, 30);
            this.btnGenerateCertificate.TabIndex = 0;
            this.btnGenerateCertificate.Text = "Сформувати довідку";
            this.btnGenerateCertificate.UseVisualStyleBackColor = true;
            this.btnGenerateCertificate.Click += new System.EventHandler(this.btnGenerateCertificate_Click);
            // 
            // grpSystemMonitoring
            // 
            this.grpSystemMonitoring.Controls.Add(this.btnOpenAuditWindow);
            this.grpSystemMonitoring.Controls.Add(this.lstLocalActivityLog);
            this.grpSystemMonitoring.Location = new System.Drawing.Point(12, 330);
            this.grpSystemMonitoring.Name = "grpSystemMonitoring";
            this.grpSystemMonitoring.Size = new System.Drawing.Size(798, 287);
            this.grpSystemMonitoring.TabIndex = 3;
            this.grpSystemMonitoring.TabStop = false;
            this.grpSystemMonitoring.Text = "Системний журнал та навігація";
            // 
            // lstLocalActivityLog
            // 
            this.lstLocalActivityLog.FormattingEnabled = true;
            this.lstLocalActivityLog.ItemHeight = 20;
            this.lstLocalActivityLog.Location = new System.Drawing.Point(10, 25);
            this.lstLocalActivityLog.Name = "lstLocalActivityLog";
            this.lstLocalActivityLog.Size = new System.Drawing.Size(756, 204);
            this.lstLocalActivityLog.TabIndex = 0;
            // 
            // btnOpenAuditWindow
            // 
            this.btnOpenAuditWindow.Location = new System.Drawing.Point(10, 235);
            this.btnOpenAuditWindow.Name = "btnOpenAuditWindow";
            this.btnOpenAuditWindow.Size = new System.Drawing.Size(225, 46);
            this.btnOpenAuditWindow.TabIndex = 1;
            this.btnOpenAuditWindow.Text = "Відкрити журнал аудиту";
            this.btnOpenAuditWindow.UseVisualStyleBackColor = true;
            this.btnOpenAuditWindow.Click += new System.EventHandler(this.btnOpenAuditWindow_Click);
            // 
            // MainPassportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 629);
            this.Controls.Add(this.grpSystemMonitoring);
            this.Controls.Add(this.grpDocumentExport);
            this.Controls.Add(this.grpPassportManagement);
            this.Controls.Add(this.grpAuthentication);
            this.Name = "MainPassportForm";
            this.Text = "Form1";
            this.grpAuthentication.ResumeLayout(false);
            this.grpAuthentication.PerformLayout();
            this.grpPassportManagement.ResumeLayout(false);
            this.grpPassportManagement.PerformLayout();
            this.grpDocumentExport.ResumeLayout(false);
            this.grpSystemMonitoring.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAuthentication;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoginOperator;
        private System.Windows.Forms.TextBox txtOperatorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpPassportManagement;
        private System.Windows.Forms.Button btnRegisterAddress;
        private System.Windows.Forms.Button btnFetchPassportData;
        private System.Windows.Forms.TextBox txtCitizenIdentifier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpDocumentExport;
        private System.Windows.Forms.Button btnGenerateCertificate;
        private System.Windows.Forms.GroupBox grpSystemMonitoring;
        private System.Windows.Forms.Button btnOpenAuditWindow;
        private System.Windows.Forms.ListBox lstLocalActivityLog;
    }
}

