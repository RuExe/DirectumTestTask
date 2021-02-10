using System;

namespace DirectumTestTask
{
    class Executor
    {
        private string Name { get; }

        private string Surname { get; }

        private string Patronymic { get; }

        public Executor(string name, string surname, string patronymic)
        {
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
        }

        public string InitialsFullName => String.Join(" ", Surname, Name[0], Patronymic[0]);
    }
}
