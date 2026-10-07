namespace PassportOffice.UI
{
    partial class LogAuditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDatabaseInspection = new System.Windows.Forms.GroupBox();
            this.txtCustomSqlQuery = new System.Windows.Forms.TextBox();
            this.btnExecuteDatabaseQuery = new System.Windows.Forms.Button();
            this.grpGlobalLogViewer = new System.Windows.Forms.GroupBox();
            this.lstGlobalSystemLog = new System.Windows.Forms.ListBox();
            this.btnRefreshLogStream = new System.Windows.Forms.Button();
            this.grpDatabaseInspection.SuspendLayout();
            this.grpGlobalLogViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatabaseInspection
            // 
            this.grpDatabaseInspection.Controls.Add(this.btnExecuteDatabaseQuery);
            this.grpDatabaseInspection.Controls.Add(this.txtCustomSqlQuery);
            this.grpDatabaseInspection.Location = new System.Drawing.Point(13, 13);
            this.grpDatabaseInspection.Name = "grpDatabaseInspection";
            this.grpDatabaseInspection.Size = new System.Drawing.Size(352, 137);
            this.grpDatabaseInspection.TabIndex = 0;
            this.grpDatabaseInspection.TabStop = false;
            this.grpDatabaseInspection.Text = "Прямий доступ до БД через DbManager";
            // 
            // txtCustomSqlQuery
            // 
            this.txtCustomSqlQuery.Location = new System.Drawing.Point(7, 26);
            this.txtCustomSqlQuery.Name = "txtCustomSqlQuery";
            this.txtCustomSqlQuery.Size = new System.Drawing.Size(309, 26);
            this.txtCustomSqlQuery.TabIndex = 0;
            this.txtCustomSqlQuery.Text = "SELECT * FROM PassportArchive";
            // 
            // btnExecuteDatabaseQuery
            // 
            this.btnExecuteDatabaseQuery.Location = new System.Drawing.Point(7, 59);
            this.btnExecuteDatabaseQuery.Name = "btnExecuteDatabaseQuery";
            this.btnExecuteDatabaseQuery.Size = new System.Drawing.Size(309, 33);
            this.btnExecuteDatabaseQuery.TabIndex = 1;
            this.btnExecuteDatabaseQuery.Text = "Виконати SQL-запит";
            this.btnExecuteDatabaseQuery.UseVisualStyleBackColor = true;
            this.btnExecuteDatabaseQuery.Click += new System.EventHandler(this.btnExecuteDatabaseQuery_Click);
            // 
            // grpGlobalLogViewer
            // 
            this.grpGlobalLogViewer.Controls.Add(this.btnRefreshLogStream);
            this.grpGlobalLogViewer.Controls.Add(this.lstGlobalSystemLog);
            this.grpGlobalLogViewer.Location = new System.Drawing.Point(13, 225);
            this.grpGlobalLogViewer.Name = "grpGlobalLogViewer";
            this.grpGlobalLogViewer.Size = new System.Drawing.Size(765, 281);
            this.grpGlobalLogViewer.TabIndex = 1;
            this.grpGlobalLogViewer.TabStop = false;
            this.grpGlobalLogViewer.Text = "Наскрізний журнал дій";
            // 
            // lstGlobalSystemLog
            // 
            this.lstGlobalSystemLog.FormattingEnabled = true;
            this.lstGlobalSystemLog.ItemHeight = 20;
            this.lstGlobalSystemLog.Location = new System.Drawing.Point(6, 26);
            this.lstGlobalSystemLog.Name = "lstGlobalSystemLog";
            this.lstGlobalSystemLog.Size = new System.Drawing.Size(741, 184);
            this.lstGlobalSystemLog.TabIndex = 0;
            // 
            // btnRefreshLogStream
            // 
            this.btnRefreshLogStream.Location = new System.Drawing.Point(6, 216);
            this.btnRefreshLogStream.Name = "btnRefreshLogStream";
            this.btnRefreshLogStream.Size = new System.Drawing.Size(741, 40);
            this.btnRefreshLogStream.TabIndex = 1;
            this.btnRefreshLogStream.Text = "Оновити потік логів";
            this.btnRefreshLogStream.UseVisualStyleBackColor = true;
            this.btnRefreshLogStream.Click += new System.EventHandler(this.btnRefreshLogStream_Click);
            // 
            // LogAuditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.grpGlobalLogViewer);
            this.Controls.Add(this.grpDatabaseInspection);
            this.Name = "LogAuditForm";
            this.Text = "LogAuditForm";
            this.Load += new System.EventHandler(this.LogAuditForm_Load);
            this.grpDatabaseInspection.ResumeLayout(false);
            this.grpDatabaseInspection.PerformLayout();
            this.grpGlobalLogViewer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatabaseInspection;
        private System.Windows.Forms.Button btnExecuteDatabaseQuery;
        private System.Windows.Forms.TextBox txtCustomSqlQuery;
        private System.Windows.Forms.GroupBox grpGlobalLogViewer;
        private System.Windows.Forms.Button btnRefreshLogStream;
        private System.Windows.Forms.ListBox lstGlobalSystemLog;
    }
}