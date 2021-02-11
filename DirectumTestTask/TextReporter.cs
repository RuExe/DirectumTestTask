using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace DirectumTestTask
{
    class TextReporter
    {
        public static void Report(List<ExecutorItem> executorItems)
        {
            string fileName = "Тестовое задание - результат работы программы.txt";
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.Write("№ \t");
                sw.Write("Ответственный исполнитель \t");
                sw.Write("Количество неисполненных входящих документов \t");
                sw.Write("Количество неисполненных письменных обращений граждан \t");
                sw.Write("Общее количество документов и обращений");
                sw.WriteLine();

                foreach (ExecutorItem item in executorItems)
                {
                    sw.Write(item.Executor.InitialsFullName + '\t');
                    sw.Write(item.RkkCount.ToString() + '\t');
                    sw.Write(item.AppealCount.ToString() + '\t');
                    sw.Write((item.RkkCount + item.AppealCount).ToString() + '\t');
                    sw.WriteLine();
                }
            }
        }
    }
}
