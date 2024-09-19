using DataShare2;

namespace joinOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RunJoin();   
            RunGroupJoin();
        }
        private static void RunJoin()
        {
            var employee = Repository.LoadEmployees();
            var departments = Repository.LoadDepartment();

            var result = employee.Join(departments
                , emp => emp.DepartmentId, dept => dept.Id,
                (emp, dept) => new { emp.FullName, dept.Name }
                );
            foreach (var item in result)
            {
                Console.WriteLine($"{item.FullName} => {item.Name}");
            }
            Console.WriteLine("================================================");
            var result2 = from emp in employee
                          join dept in departments on emp.DepartmentId equals dept.Id
                          select new { emp.FullName, dept.Name };

            foreach (var item in result2)
            {
                Console.WriteLine($"{item.FullName} => {item.Name}");
            }

        }
        private static void RunGroupJoin()
        {
            var employee = Repository.LoadEmployees();
            var departments = Repository.LoadDepartment();

            var result = departments.GroupJoin
                (employee,
                  dept => dept.Id,
                  emp => emp.DepartmentId,
                  (dept, emps) => new
                  {
                      Department = dept.Name,
                      Employees = emps
                  });
            foreach (var group in result)
            {
                Console.WriteLine();
                Console.WriteLine($"********************** {group.Department} ***********************");
                Console.WriteLine();
                foreach (var item in group.Employees)
                {
                    Console.WriteLine($"{item.FullName}");
                }
            }
        }
    }

}

