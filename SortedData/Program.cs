namespace SortedData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunOrderBy();
            RunComparerEmployee();
        }
        public static void RunOrderBy()
        {
            string[] fruits =
               { "apricot", "orange", "banana", "mango",
                "apple", "grape", "strawberry" };
            var fruitsorderby = from f in fruits
                                orderby f descending
                                select f;
            fruitsorderby.Print("Fruites DESC (query Syntax)");
            Console.WriteLine("----------------------------------------");
            var fruitsorderby01 = fruits.OrderByDescending(f => f);
            fruitsorderby01.Print("Fruites DESC (Method Syntax)");

            var orderedFruitsAscLength = fruits.OrderBy(f => f.Length);
            orderedFruitsAscLength.Print("Fruites DESC (Method Syntax)");

            var orderedFruitsAscLength01=from f in fruits
                                         orderby f.Length 
                                         select f;
            orderedFruitsAscLength01.Print("Fruites DESC (query Syntax)");

        }

        public static void RunComparerEmployee()
        {
            var emp=Repository.LoadEmployees();
            var sortedEmps = emp.OrderBy(e => e, new EmployeeComparer());
            sortedEmps.Print("sorted employees");
        }
    }
}
