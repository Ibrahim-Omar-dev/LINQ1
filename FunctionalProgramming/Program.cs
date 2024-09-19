using System.Runtime.InteropServices;

namespace FunctionalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            RunExtensionFunctional01();
            RunExtensionFunctional02();
        }
        private static void RunExtensionFunctional02()
        {
            var list=Repository.LoadEmployees();
            var q1=from employee in list
                   where employee.FirstName.ToLowerInvariant().StartsWith("m")
                   select employee;
            //q1.Print("Start with m");

            var q1_1 = list.Where(x => x.FirstName.ToLowerInvariant().StartsWith("m"));
           // q1_1.Print("Start with m");

            var q2=from employee in list
                   where employee.LastName.ToLowerInvariant().StartsWith("ju")
                   select employee;
            //q2.Print("Employees with last name starts with 'ju'");

            var q2_1 = list.Where(x => x.LastName.ToLowerInvariant().StartsWith("ju"));
            //q2_1.Print("Employees with last name starts with 'ju'");

            var q3=from employee in list
                   where employee.Department.ToLowerInvariant()=="hr"
                   select employee;
            //q3.Print("Employees in 'HR' department");

            var q3_1 = list.Where(x => x.Department.ToLowerInvariant() == "hr");
            q3_1.Print("Employees in 'HR' department");

        }

        private static void RunExtensionFunctional01()
        {
            var list = Repository.LoadEmployees();
            //Func<Employee, bool> predicate = e => e.FirstName.ToLowerInvariant().StartsWith("m")&&e.Gender=="male";
            //var q0 = ExtensionFunction.Filter(list, predicate);
            //ExtensionFunction.Print(q0, "Employees with first name starts with 'm' and male");


            //var q1 = ExtensionFunction.Filter(list, e => e.FirstName.ToLowerInvariant().StartsWith("m"));
            //ExtensionFunction.Print(q1, "employees with first name starts with 'm'");

            //var q2 = ExtensionFunction.Filter(list, e => e.LastName.ToLowerInvariant().StartsWith("ju"));
            //ExtensionFunction.Print(q2, "Employees with last name starts with 'ju'");

            var q3 = ExtensionFunction.Filter(list, e => e.Department.ToLowerInvariant() == "hr");
            ExtensionFunction.Print(q3, "Employees in 'HR' department");

            //var q4 = ExtensionFunction.Filter(list, e => e.Gender.ToLowerInvariant() == "female");
            //ExtensionFunction.Print(q4, "Female employees");

            //var q5 = ExtensionFunction.Filter(list, e => e.HireDate.Year == 2018);
            //ExtensionFunction.Print(q5, "Employees hired in '2018'");

            //var q6 = ExtensionFunction.Filter(list, e => e.HasPensionPlan);
            //ExtensionFunction.Print(q6, "Employees with Pension Plan");

            //var q7 = ExtensionFunction.Filter(list, e => !e.HasHealthInsurance);
            //ExtensionFunction.Print(q7, "Employees without Health insurance");

            //var q8 = ExtensionFunction.Filter(list, e => e.Salary == 107000);
            //ExtensionFunction.Print(q8, "Employees with Salary = $107000");

            //var q9 = ExtensionFunction.Filter(list, e => e.Salary > 107000);
            //ExtensionFunction.Print(q9, "Employees with Salary > $107000");

            //var q10 = ExtensionFunction.Filter(list, e => e.Salary < 107000);
            //ExtensionFunction.Print(q10, "Employees with Salary < $107000");

            //var q11 = ExtensionFunction.Filter(list, e => e.Salary < 107000 && e.Gender == "female");
            //ExtensionFunction.Print(q11, "Employees with Salary < $107000 and female");

        }


    }
}
