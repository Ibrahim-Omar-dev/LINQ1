using SortedData;

namespace Quantifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunAny();
            //RunAll();
            RunContain();
        }
        private static void RunAny()
        {
            var emps = Repository.LoadEmployees();
            bool q1 = emps.Any(x => x.Name.StartsWith("jac", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(q1);
            var q1_1 = from e in emps
                       where e.Name.Any(x => x.ToString().StartsWith("j", StringComparison.OrdinalIgnoreCase))
                       select e;
            foreach (var item in q1_1)
            {
                Console.WriteLine(item.Name);
            }
            var q2 = emps.Any(x => x.Salary < 100);
            Console.WriteLine(q2);
        }
        private static void RunAll()
        {
            var emps = Repository.LoadEmployees();

            var q1 = emps.All(e => e.Skills.Any(x => x.Contains("C#")));
            Console.WriteLine(q1);

            var q2 = emps.All(e => !string.IsNullOrWhiteSpace(e.Email));
            Console.WriteLine(q2);
        }
        private static void RunContain()
        {
            var employees = Repository.LoadEmployees();


            // if any employee contains 'ee' in his/her name

            var e1 = employees.ToArray()[0];
            var result1 = employees.Contains(e1);
            Console.WriteLine($"find if any employee contains " +
                $"'{e1.Email}' in his/her name result: {result1}");

            var e2 = new Employee { Email = "Cole.Cochran02@example.com" };
            var result2 = employees.Contains(e2);
            Console.WriteLine($"find if any employee contains " +
                $"'{e2.Email}' in his/her name result: {result2}");

        }
    }
}
