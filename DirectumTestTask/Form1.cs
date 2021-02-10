using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
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
            List<Executor> rkkList = new List<Executor>();

            using (StreamReader sr = new StreamReader(RkkOpenFileDialog.FileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] temp = line.Split('\t');
                    if (temp[0] == "Климов Сергей Александрович")
                    {
                        rkkList.Add(new Executor(temp[1].Split(';')[0].Replace("(Отв.)", "").Trim()));
                    }
                    else
                    {
                        rkkList.Add(new Executor(temp[0]));
                    }
                }
            }
            var rkkResult = rkkList.GroupBy(executor => executor.Name)
                .Select(group => new { Name = group.Key, Count = group.Count() })
                .OrderByDescending(executor => executor.Count);

            int index = 0;

            foreach (var executor in rkkResult)
            {
                dataGridView1.Rows.Add(index++, executor.Name, executor.Count, "");
            }
        }
    }
}
