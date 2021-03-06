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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rkk_TB = new System.Windows.Forms.TextBox();
            this.Appeal_TB = new System.Windows.Forms.TextBox();
            this.Rkk_BTN = new System.Windows.Forms.Button();
            this.Appeal_BTN = new System.Windows.Forms.Button();
            this.RkkOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Run_BTN = new System.Windows.Forms.Button();
            this.UploadReport_BTN = new System.Windows.Forms.Button();
            this.AppealOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.TaskTime_TB = new System.Windows.Forms.TextBox();
            this.totalCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outstandingRequestsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outstandingDocumentsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ReportSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.OrderBySum_RB = new System.Windows.Forms.RadioButton();
            this.OrderByAppealCount_RB = new System.Windows.Forms.RadioButton();
            this.OrderByRkkCount_RB = new System.Windows.Forms.RadioButton();
            this.OrderBySurname_RB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.GroupBox.SuspendLayout();
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
            // Run_BTN
            // 
            this.Run_BTN.Location = new System.Drawing.Point(713, 137);
            this.Run_BTN.Name = "Run_BTN";
            this.Run_BTN.Size = new System.Drawing.Size(127, 23);
            this.Run_BTN.TabIndex = 7;
            this.Run_BTN.Text = "Сделать отчет";
            this.Run_BTN.UseVisualStyleBackColor = true;
            this.Run_BTN.Click += new System.EventHandler(this.Run_BTN_Click);
            // 
            // UploadReport_BTN
            // 
            this.UploadReport_BTN.Location = new System.Drawing.Point(713, 166);
            this.UploadReport_BTN.Name = "UploadReport_BTN";
            this.UploadReport_BTN.Size = new System.Drawing.Size(127, 23);
            this.UploadReport_BTN.TabIndex = 8;
            this.UploadReport_BTN.Text = "Выгрузить отчет";
            this.UploadReport_BTN.UseVisualStyleBackColor = true;
            this.UploadReport_BTN.Click += new System.EventHandler(this.UploadReport_BTN_Click);
            // 
            // AppealOpenFileDialog
            // 
            this.AppealOpenFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 589);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Время выполнения";
            // 
            // TaskTime_TB
            // 
            this.TaskTime_TB.Enabled = false;
            this.TaskTime_TB.Location = new System.Drawing.Point(123, 586);
            this.TaskTime_TB.Name = "TaskTime_TB";
            this.TaskTime_TB.Size = new System.Drawing.Size(97, 20);
            this.TaskTime_TB.TabIndex = 10;
            // 
            // totalCount
            // 
            this.totalCount.HeaderText = "Общее количество документов и обращений";
            this.totalCount.Name = "totalCount";
            this.totalCount.ReadOnly = true;
            this.totalCount.Width = 152;
            // 
            // outstandingRequestsCount
            // 
            this.outstandingRequestsCount.HeaderText = "Количество неисполненных письменных обращений граждан";
            this.outstandingRequestsCount.Name = "outstandingRequestsCount";
            this.outstandingRequestsCount.ReadOnly = true;
            this.outstandingRequestsCount.Width = 152;
            // 
            // outstandingDocumentsCount
            // 
            this.outstandingDocumentsCount.HeaderText = "Количество неисполненных входящих документов";
            this.outstandingDocumentsCount.Name = "outstandingDocumentsCount";
            this.outstandingDocumentsCount.ReadOnly = true;
            this.outstandingDocumentsCount.Width = 151;
            // 
            // responsible
            // 
            this.responsible.HeaderText = "Ответственный исполнитель";
            this.responsible.Name = "responsible";
            this.responsible.ReadOnly = true;
            this.responsible.Width = 152;
            // 
            // number
            // 
            this.number.HeaderText = "№ п.п.";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 45;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.responsible,
            this.outstandingDocumentsCount,
            this.outstandingRequestsCount,
            this.totalCount});
            this.dataGridView.Location = new System.Drawing.Point(12, 72);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(656, 508);
            this.dataGridView.TabIndex = 6;
            // 
            // ReportSaveFileDialog
            // 
            this.ReportSaveFileDialog.FileName = "Тестовое задание - результат работы программы";
            this.ReportSaveFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.OrderBySum_RB);
            this.GroupBox.Controls.Add(this.OrderByAppealCount_RB);
            this.GroupBox.Controls.Add(this.OrderByRkkCount_RB);
            this.GroupBox.Controls.Add(this.OrderBySurname_RB);
            this.GroupBox.Location = new System.Drawing.Point(675, 12);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(199, 119);
            this.GroupBox.TabIndex = 11;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Сортировка";
            // 
            // OrderBySum_RB
            // 
            this.OrderBySum_RB.AutoSize = true;
            this.OrderBySum_RB.Location = new System.Drawing.Point(6, 88);
            this.OrderBySum_RB.Name = "OrderBySum_RB";
            this.OrderBySum_RB.Size = new System.Drawing.Size(117, 17);
            this.OrderBySum_RB.TabIndex = 15;
            this.OrderBySum_RB.TabStop = true;
            this.OrderBySum_RB.Text = "По общему кол-ву";
            this.OrderBySum_RB.UseVisualStyleBackColor = true;
            // 
            // OrderByAppealCount_RB
            // 
            this.OrderByAppealCount_RB.AutoSize = true;
            this.OrderByAppealCount_RB.Location = new System.Drawing.Point(6, 65);
            this.OrderByAppealCount_RB.Name = "OrderByAppealCount_RB";
            this.OrderByAppealCount_RB.Size = new System.Drawing.Size(107, 17);
            this.OrderByAppealCount_RB.TabIndex = 14;
            this.OrderByAppealCount_RB.TabStop = true;
            this.OrderByAppealCount_RB.Text = "По обращениям";
            this.OrderByAppealCount_RB.UseVisualStyleBackColor = true;
            // 
            // OrderByRkkCount_RB
            // 
            this.OrderByRkkCount_RB.AutoSize = true;
            this.OrderByRkkCount_RB.Location = new System.Drawing.Point(6, 42);
            this.OrderByRkkCount_RB.Name = "OrderByRkkCount_RB";
            this.OrderByRkkCount_RB.Size = new System.Drawing.Size(63, 17);
            this.OrderByRkkCount_RB.TabIndex = 13;
            this.OrderByRkkCount_RB.TabStop = true;
            this.OrderByRkkCount_RB.Text = "По РКК";
            this.OrderByRkkCount_RB.UseVisualStyleBackColor = true;
            // 
            // OrderBySurname_RB
            // 
            this.OrderBySurname_RB.AutoSize = true;
            this.OrderBySurname_RB.Location = new System.Drawing.Point(6, 19);
            this.OrderBySurname_RB.Name = "OrderBySurname_RB";
            this.OrderBySurname_RB.Size = new System.Drawing.Size(88, 17);
            this.OrderBySurname_RB.TabIndex = 12;
            this.OrderBySurname_RB.TabStop = true;
            this.OrderBySurname_RB.Text = "По фамилии";
            this.OrderBySurname_RB.UseVisualStyleBackColor = true;
            // 
            // Result_DGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 609);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.TaskTime_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UploadReport_BTN);
            this.Controls.Add(this.Run_BTN);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Appeal_BTN);
            this.Controls.Add(this.Rkk_BTN);
            this.Controls.Add(this.Appeal_TB);
            this.Controls.Add(this.Rkk_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Result_DGV";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
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
        private System.Windows.Forms.Button Run_BTN;
        private System.Windows.Forms.Button UploadReport_BTN;
        private System.Windows.Forms.OpenFileDialog AppealOpenFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TaskTime_TB;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn outstandingRequestsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn outstandingDocumentsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsible;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.SaveFileDialog ReportSaveFileDialog;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.RadioButton OrderBySum_RB;
        private System.Windows.Forms.RadioButton OrderByAppealCount_RB;
        private System.Windows.Forms.RadioButton OrderByRkkCount_RB;
        private System.Windows.Forms.RadioButton OrderBySurname_RB;
    }
}

