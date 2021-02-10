using System.Collections.Generic;
using System.IO;

namespace DirectumTestTask
{
    class Parser
    {
        public static List<Executor> Parse(string path)
        {
            List<Executor> result = new List<Executor>();

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] temp = line.Split('\t');
                    if (temp[0] == "Климов Сергей Александрович")
                    {
                        string[] fields = temp[1].Replace("(Отв.)", "").Split();

                        string surname = fields[0];
                        string[] test = fields[1].Split('.');
                        string name = test[0];
                        string patronymic = test[1];
                        result.Add(new Executor(name, surname, patronymic));
                    }
                    else
                    {
                        string[] fields = temp[0].Split();
                        string surname = fields[0];
                        string name = fields[1];
                        string patronymic = fields[2];
                        result.Add(new Executor(name, surname, patronymic));
                    }
                }
            }

            return result;
        }
    }
}
