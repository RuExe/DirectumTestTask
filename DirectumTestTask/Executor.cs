using System;
using System.Collections.Generic;
using System.Text;

namespace DirectumTestTask
{
    class Executor
    {
        private string name;
        private string lastname;
        private string patronymic;

        public Executor(string name, string lastname, string patronymic)
        {
            this.name = name;
            this.lastname = lastname;
            this.patronymic = patronymic;
        }

        public string Name => name;

        public string Lastname => lastname;

        public string Patronymic => patronymic;

        public string InitialsFullName
        {
            get { return String.Join(" ", lastname, name[0], patronymic[0]); }
        }
    }
}
