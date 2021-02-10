using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace DirectumTestTask
{
    public partial class Result_DGV : Form
    {
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
            List<Executor> rkkList = Parser.Parse(RkkOpenFileDialog.FileName);
            List<Executor> appealList = Parser.Parse(AppealOpenFileDialog.FileName);

            var rkkResult = rkkList
                .GroupBy(executor => executor.InitialsFullName)
                .Select(group => new { Name = group.Key, Count = group.Count(), SecondCount = 0 });

            var appealResult = appealList
                .GroupBy(executor => executor.InitialsFullName)
                .Select(group => new { Name = group.Key, Count = 0, SecondCount = group.Count() });

            var result = rkkResult
                .Concat(appealResult)
                .GroupBy(executor => executor.Name)
                .Select(group => new { Name = group.Key, Count = group.Sum(item => item.Count), SecondCount = group.Sum(item => item.SecondCount) });

            int index = 1;

            foreach (var executor in result)
            {
                dataGridView1.Rows.Add(index++, executor.Name, executor.Count, executor.SecondCount, executor.Count + executor.SecondCount);
            }
        }
    }
}
