﻿
namespace DirectumTestTask
{
    partial class Result_DGV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rkk_TB = new System.Windows.Forms.TextBox();
            this.Appeal_TB = new System.Windows.Forms.TextBox();
            this.Rkk_BTN = new System.Windows.Forms.Button();
            this.Appeal_BTN = new System.Windows.Forms.Button();
            this.RkkOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outstandingDocumentsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outstandingRequestsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Run_BTN = new System.Windows.Forms.Button();
            this.UploadReport_BTN = new System.Windows.Forms.Button();
            this.AppealOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Данные РКК";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Данные по обращениям";
            // 
            // Rkk_TB
            // 
            this.Rkk_TB.Enabled = false;
            this.Rkk_TB.Location = new System.Drawing.Point(149, 15);
            this.Rkk_TB.Name = "Rkk_TB";
            this.Rkk_TB.ReadOnly = true;
            this.Rkk_TB.Size = new System.Drawing.Size(245, 20);
            this.Rkk_TB.TabIndex = 2;
            // 
            // Appeal_TB
            // 
            this.Appeal_TB.Enabled = false;
            this.Appeal_TB.Location = new System.Drawing.Point(149, 45);
            this.Appeal_TB.Name = "Appeal_TB";
            this.Appeal_TB.ReadOnly = true;
            this.Appeal_TB.Size = new System.Drawing.Size(245, 20);
            this.Appeal_TB.TabIndex = 3;
            // 
            // Rkk_BTN
            // 
            this.Rkk_BTN.Location = new System.Drawing.Point(400, 13);
            this.Rkk_BTN.Name = "Rkk_BTN";
            this.Rkk_BTN.Size = new System.Drawing.Size(135, 23);
            this.Rkk_BTN.TabIndex = 4;
            this.Rkk_BTN.Text = "Выберите файл";
            this.Rkk_BTN.UseVisualStyleBackColor = true;
            this.Rkk_BTN.Click += new System.EventHandler(this.Rkk_BTN_Click);
            // 
            // Appeal_BTN
            // 
            this.Appeal_BTN.Location = new System.Drawing.Point(400, 42);
            this.Appeal_BTN.Name = "Appeal_BTN";
            this.Appeal_BTN.Size = new System.Drawing.Size(135, 23);
            this.Appeal_BTN.TabIndex = 5;
            this.Appeal_BTN.Text = "Выберите файл";
            this.Appeal_BTN.UseVisualStyleBackColor = true;
            this.Appeal_BTN.Click += new System.EventHandler(this.Appeal_BTN_Click);
            // 
            // RkkOpenFileDialog
            // 
            this.RkkOpenFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.responsible,
            this.outstandingDocumentsCount,
            this.outstandingRequestsCount,
            this.totalCount});
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(656, 456);
            this.dataGridView1.TabIndex = 6;
            // 
            // number
            // 
            this.number.HeaderText = "№ п.п.";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 45;
            // 
            // responsible
            // 
            this.responsible.HeaderText = "Ответственный исполнитель";
            this.responsible.Name = "responsible";
            this.responsible.ReadOnly = true;
            this.responsible.Width = 152;
            // 
            // outstandingDocumentsCount
            // 
            this.outstandingDocumentsCount.HeaderText = "Количество неисполненных входящих документов";
            this.outstandingDocumentsCount.Name = "outstandingDocumentsCount";
            this.outstandingDocumentsCount.ReadOnly = true;
            this.outstandingDocumentsCount.Width = 151;
            // 
            // outstandingRequestsCount
            // 
            this.outstandingRequestsCount.HeaderText = "Количество неисполненных письменных обращений граждан";
            this.outstandingRequestsCount.Name = "outstandingRequestsCount";
            this.outstandingRequestsCount.ReadOnly = true;
            this.outstandingRequestsCount.Width = 152;
            // 
            // totalCount
            // 
            this.totalCount.HeaderText = "Общее количество документов и обращений";
            this.totalCount.Name = "totalCount";
            this.totalCount.ReadOnly = true;
            this.totalCount.Width = 152;
            // 
            // Run_BTN
            // 
            this.Run_BTN.Location = new System.Drawing.Point(541, 13);
            this.Run_BTN.Name = "Run_BTN";
            this.Run_BTN.Size = new System.Drawing.Size(127, 23);
            this.Run_BTN.TabIndex = 7;
            this.Run_BTN.Text = "Сделать отчет";
            this.Run_BTN.UseVisualStyleBackColor = true;
            this.Run_BTN.Click += new System.EventHandler(this.Run_BTN_Click);
            // 
            // UploadReport_BTN
            // 
            this.UploadReport_BTN.Location = new System.Drawing.Point(541, 42);
            this.UploadReport_BTN.Name = "UploadReport_BTN";
            this.UploadReport_BTN.Size = new System.Drawing.Size(127, 23);
            this.UploadReport_BTN.TabIndex = 8;
            this.UploadReport_BTN.Text = "Выгрузить отчет";
            this.UploadReport_BTN.UseVisualStyleBackColor = true;
            // 
            // AppealOpenFileDialog
            // 
            this.AppealOpenFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
            // 
            // Result_DGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 540);
            this.Controls.Add(this.UploadReport_BTN);
            this.Controls.Add(this.Run_BTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Appeal_BTN);
            this.Controls.Add(this.Rkk_BTN);
            this.Controls.Add(this.Appeal_TB);
            this.Controls.Add(this.Rkk_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Result_DGV";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Rkk_TB;
        private System.Windows.Forms.TextBox Appeal_TB;
        private System.Windows.Forms.Button Rkk_BTN;
        private System.Windows.Forms.Button Appeal_BTN;
        private System.Windows.Forms.OpenFileDialog RkkOpenFileDialog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsible;
        private System.Windows.Forms.DataGridViewTextBoxColumn outstandingDocumentsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn outstandingRequestsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCount;
        private System.Windows.Forms.Button Run_BTN;
        private System.Windows.Forms.Button UploadReport_BTN;
        private System.Windows.Forms.OpenFileDialog AppealOpenFileDialog;
    }
}
