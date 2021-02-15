using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace DirectumTestTask
{
    class TextReporter
    {
        public static void Report(List<ExecutorItem> executorItems, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                int rkkCount = executorItems.Sum(item => item.RkkCount);
                int appealCount = executorItems.Sum(item => item.AppealCount);

                sw.WriteLine("Не исполнено в срок " + (rkkCount + appealCount) + " документов, из них:" + Environment.NewLine +
                    "- количество неисполненных входящих документов: " + rkkCount + ";" + Environment.NewLine +
                    "- количество неисполненных письменных обращений граждан: " + appealCount + "." + Environment.NewLine);

                int countLength = executorItems.Count.ToString().Length;

                string firstTitle = "Ответственный исполнитель";
                string secondTitle = "Количество неисполненных входящих документов";
                string thirdTitle = "Количество неисполненных письменных обращений граждан";

                sw.Write("№ \t");
                sw.Write(firstTitle + "\t");
                sw.Write(secondTitle + "\t");
                sw.Write(thirdTitle + "\t");
                sw.Write("Общее количество документов и обращений" + Environment.NewLine);

                int index = 1;
                foreach (ExecutorItem executor in executorItems)
                {
                    sw.Write(index++.ToString() + new string(' ', countLength - (index.ToString().Length - 1)) + "\t");
                    sw.Write(executor.Executor.InitialsFullName + new string(' ', firstTitle.Length - executor.Executor.InitialsFullName.Length) + "\t");
                    sw.Write(executor.RkkCount.ToString() + new string(' ', secondTitle.Length - executor.RkkCount.ToString().Length) + "\t");
                    sw.Write(executor.AppealCount.ToString() + new string(' ', thirdTitle.Length - executor.AppealCount.ToString().Length) + '\t');
                    sw.Write((executor.Sum).ToString() + '\t' + Environment.NewLine);
                }

                sw.WriteLine(Environment.NewLine + "Дата составления справки: " + DateTime.Now.ToString("dd.MM.yyyy"));
            }
        }
    }
}
