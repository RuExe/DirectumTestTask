using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace DirectumTestTask
{
    class TextReporter
    {
        public static void Report(List<ExecutorItem> executorItems, string filePath)
        {
            int rkkCount = executorItems.Sum(item => item.RkkCount);
            int appealCount = executorItems.Sum(item => item.AppealCount);

            int countLength = executorItems.Count.ToString().Length;

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Не исполнено в срок " + (rkkCount + appealCount) + " документов, из них:" + Environment.NewLine +
                    "- количество неисполненных входящих документов: " + rkkCount + ";" + Environment.NewLine +
                    "- количество неисполненных письменных обращений граждан: " + appealCount + "." + Environment.NewLine);

                string firstTitle = "Ответственный исполнитель";
                string secondTitle = "Количество неисполненных входящих документов";
                string thirdTitle = "Количество неисполненных письменных обращений граждан";

                sw.Write("№ \t");
                sw.Write(firstTitle + "\t");
                sw.Write(secondTitle + "\t");
                sw.Write(thirdTitle + "\t");
                sw.WriteLine("Общее количество документов и обращений");

                int index = 1;
                foreach (ExecutorItem executor in executorItems)
                {
                    sw.Write(index++.ToString() + "\t".PadLeft(countLength - (index.ToString().Length - 1)));
                    sw.Write(executor.Executor.InitialsFullName + "\t".PadLeft(firstTitle.Length - executor.Executor.InitialsFullName.Length));
                    sw.Write(executor.RkkCount.ToString() + "\t".PadLeft(secondTitle.Length - executor.RkkCount.ToString().Length));
                    sw.Write(executor.AppealCount.ToString() + "\t".PadLeft(thirdTitle.Length - executor.AppealCount.ToString().Length));
                    sw.WriteLine(executor.Sum);
                }

                sw.Write(Environment.NewLine + "Дата составления справки: " + DateTime.Now.ToString("dd.MM.yyyy"));
            }
        }
    }
}
