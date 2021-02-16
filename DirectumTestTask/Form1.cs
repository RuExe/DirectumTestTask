using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace DirectumTestTask
{
    public partial class Result_DGV : Form
    {
        private readonly Manager manager = new Manager();

        public Result_DGV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Rkk_BTN_Click(object sender, EventArgs e)
        {
            if (RkkOpenFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                Rkk_TB.Text = Path.GetFileName(RkkOpenFileDialog.FileName);
            }
        }

        private void Appeal_BTN_Click(object sender, EventArgs e)
        {
            if (AppealOpenFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                Appeal_TB.Text = Path.GetFileName(AppealOpenFileDialog.FileName);
            }
        }

        private void Run_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (RkkOpenFileDialog.FileName.Equals(String.Empty))
                {
                    throw new Exception("Выберите РКК файл");
                }

                if (AppealOpenFileDialog.FileName.Equals(String.Empty))
                {
                    throw new Exception("Выберите файл с обращениями");
                }

                //Programm result timer
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                List<ExecutorItem> result = GetResultBySelectedOrder();
                FillDataGridView(result);

                stopWatch.Stop();

                TaskTime_TB.Text = stopWatch.Elapsed.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void UploadReport_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (RkkOpenFileDialog.FileName.Equals(String.Empty))
                {
                    throw new Exception("Выберите РКК файл");
                }

                if (AppealOpenFileDialog.FileName.Equals(String.Empty))
                {
                    throw new Exception("Выберите файл с обращениями");
                }

                if (ReportSaveFileDialog.ShowDialog().Equals(DialogResult.OK))
                {
                    List<ExecutorItem> result = GetResultBySelectedOrder();

                    TextReporter.Report(result, ReportSaveFileDialog.FileName);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void FillDataGridView(List<ExecutorItem> list)
        {
            dataGridView.Rows.Clear();

            int index = 1;
            foreach (ExecutorItem executorItem in list)
            {
                dataGridView.Rows.Add(
                    index++,
                    executorItem.Executor.InitialsFullName,
                    executorItem.RkkCount,
                    executorItem.AppealCount,
                    executorItem.Sum);
            }
        }

        private List<ExecutorItem> GetResultBySelectedOrder()
        {
            RadioButton rbChecked = GroupBox.Controls.OfType<RadioButton>().SingleOrDefault(rb => rb.Checked);
            
            switch (rbChecked?.Name ?? "")
            {
                case "OrderBySurname_RB":
                    return manager.ResultOrderDescBySurname(RkkOpenFileDialog.FileName, AppealOpenFileDialog.FileName);
                case "OrderByRkkCount_RB":
                    return manager.ResultOrderDescByRkkCount(RkkOpenFileDialog.FileName, AppealOpenFileDialog.FileName);
                case "OrderByAppealCount_RB":
                    return manager.ResultOrderDescByAppealCount(RkkOpenFileDialog.FileName, AppealOpenFileDialog.FileName);
                case "OrderBySum_RB":
                    return manager.ResultOrderDescBySum(RkkOpenFileDialog.FileName, AppealOpenFileDialog.FileName);
                default:
                    return manager.Result(RkkOpenFileDialog.FileName, AppealOpenFileDialog.FileName);
            }
        }
    }
}
