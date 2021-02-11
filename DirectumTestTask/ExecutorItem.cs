using System;

namespace DirectumTestTask
{
    class ExecutorItem
    {
        public Executor Executor { get; }

        public int RkkCount { get; }

        public int AppealCount { get; }

        public ExecutorItem(Executor executor, int rkk, int appeals)
        {
            this.Executor = executor;
            this.RkkCount = rkk;
            this.AppealCount = appeals;
        }
    }
}
