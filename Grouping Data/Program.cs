using ShareData;

namespace Grouping_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunGroupBy();
            RunToLookup();
        }
        private static void RunGroupBy()
        {
            var employee = Repository.LoadEmployees();
            var q1=employee.GroupBy(x=>x.Salary);
            foreach (var item in q1)
            {
                item.Print($"Employee in '{item.Key}' Salary");
            }
            var q1_1 = from e in employee
                       group e by e.Salary;
            foreach (var item in q1_1)
            {
                item.Print($"Employee in '{item.Key}' salary");
            }
        }private static void RunToLookup()
        {
            var employee = Repository.LoadEmployees();
            var q1=employee.ToLookup(x=>x.Salary);
            foreach (var item in q1)
            {
                item.Print($"Employee in '{item.Key}' Salary");
            }
        }
    }
}
