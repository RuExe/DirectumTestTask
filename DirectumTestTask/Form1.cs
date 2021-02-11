using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;

namespace DirectumTestTask
{
    public partial class Result_DGV : Form
    {
        private Manager manager = new Manager();

        public Result_DGV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Rkk_BTN_Click(object sender, EventArgs e)
        {
            if (RkkOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Rkk_TB.Text = Path.GetFileName(RkkOpenFileDialog.FileName);
            }
        }

        private void Appeal_BTN_Click(object sender, EventArgs e)
        {
            if (AppealOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Appeal_TB.Text = Path.GetFileName(AppealOpenFileDialog.FileName);
            }
        }

        private void Run_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (RkkOpenFileDialog.FileName == String.Empty)
                {
                    throw new Exception("Выберите РКК файл");
                }

                if (AppealOpenFileDialog.FileName == String.Empty)
                {
                    throw new Exception("Выберите файл с обращениями");
                }

                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                List<ExecutorItem> result = manager.Result(RkkOpenFileDialog.FileName, AppealOpenFileDialog.FileName);

                int index = 1;
                dataGridView1.Rows.Clear();
                foreach (ExecutorItem executorItem in result)
                {
                    dataGridView1.Rows.Add(
                        index++,
                        executorItem.Executor.InitialsFullName,
                        executorItem.RkkCount,
                        executorItem.AppealCount,
                        executorItem.RkkCount + executorItem.AppealCount);
                }

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
                if (RkkOpenFileDialog.FileName == String.Empty)
                {
                    throw new Exception("Выберите РКК файл");
                }

                if (AppealOpenFileDialog.FileName == String.Empty)
                {
                    throw new Exception("Выберите файл с обращениями");
                }

                List<ExecutorItem> result = manager.Result(RkkOpenFileDialog.FileName, AppealOpenFileDialog.FileName);
                TextReporter.Report(result);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
