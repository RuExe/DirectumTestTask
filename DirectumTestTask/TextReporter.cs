using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace DirectumTestTask
{
    class TextReporter
    {
        public static void Report(List<ExecutorItem> executorItems)
        {
            string fileName = "Тестовое задание - результат работы программы.txt";

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                int rkkCount = executorItems.Sum(item => item.RkkCount);
                int appealCount = executorItems.Sum(item => item.AppealCount);
                sw.WriteLine("Не исполнено в срок " + (rkkCount + appealCount) + " документов, из них:");
                sw.WriteLine("- количество неисполненных входящих документов: " + rkkCount + ";");
                sw.WriteLine("- количество неисполненных письменных обращений граждан: " + appealCount + "." + System.Environment.NewLine);

                sw.Write("№ \t");
                sw.Write("Ответственный исполнитель \t");
                sw.Write("Количество неисполненных входящих документов \t");
                sw.Write("Количество неисполненных письменных обращений граждан \t");
                sw.Write("Общее количество документов и обращений" + System.Environment.NewLine);

                int index = 1;
                foreach (ExecutorItem item in executorItems)
                {
                    sw.Write(index++.ToString() + '\t');
                    sw.Write(item.Executor.InitialsFullName + '\t');
                    sw.Write(item.RkkCount.ToString() + '\t');
                    sw.Write(item.AppealCount.ToString() + '\t');
                    sw.Write((item.RkkCount + item.AppealCount).ToString() + '\t' + System.Environment.NewLine);
                }

                sw.WriteLine(System.Environment.NewLine + "Дата составления справки: " + DateTime.Now.ToString("dd.MM.yyyy"));
            }
        }
    }
}
