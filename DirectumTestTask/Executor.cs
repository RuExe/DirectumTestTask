using System;
using System.Collections.Generic;
using System.Text;

namespace DirectumTestTask
{
    class Executor
    {
        private string name;
        public Executor(string name)
        {
            this.name = name;
        }

        public string Name => name;
    }
}
