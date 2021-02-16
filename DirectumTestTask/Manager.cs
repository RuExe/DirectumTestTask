using System.Linq;
using System.Collections.Generic;

namespace DirectumTestTask
{
    class Manager
    {
        public List<ExecutorItem> Result(string rkkPath, string appealPath)
        {
            List<Executor> rkkList = Parser.Parse(rkkPath);
            List<Executor> appealList = Parser.Parse(appealPath);

            var rkkResult = rkkList
                .GroupBy(executor => executor.InitialsFullName)
                .Select(group => new { Executor = group.First(), Count = group.Count(), SecondCount = 0 });

            var appealResult = appealList
                .GroupBy(executor => executor.InitialsFullName)
                .Select(group => new { Executor = group.First(), Count = 0, SecondCount = group.Count() });

            return rkkResult
                .Concat(appealResult)
                .GroupBy(executor => executor.Executor.InitialsFullName)
                .Select(group => new ExecutorItem(group.First().Executor, group.Sum(item => item.Count), group.Sum(item => item.SecondCount)))
                .ToList();
        }

        public List<ExecutorItem> ResultOrderDescBySurname(string rkkPath, string appealPath)
        {
            return Result(rkkPath, appealPath).OrderByDescending(item => item.Executor.Surname).ToList();
        }

        public List<ExecutorItem> ResultOrderDescByRkkCount(string rkkPath, string appealPath)
        {
            return Result(rkkPath, appealPath).OrderByDescending(item => item.RkkCount).ToList();
        }

        public List<ExecutorItem> ResultOrderDescByAppealCount(string rkkPath, string appealPath)
        {
            return Result(rkkPath, appealPath).OrderByDescending(item => item.AppealCount).ToList();
        }

        public List<ExecutorItem> ResultOrderDescBySum(string rkkPath, string appealPath)
        {
            return Result(rkkPath, appealPath).OrderByDescending(item => item.Sum).ToList();
        }
    }
}
