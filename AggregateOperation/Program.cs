
using EqualityOperations;

namespace AggregateOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunAggregate();
            //RunCount();
        }
        private static void RunAggregate()
        {

            var names = new[] { "Ali", "Salem", "Abeer", "Reem", "Jalal" };
            var result = names.Aggregate((a, b) => $"{a} , {b}");
            Console.WriteLine(result);
        }
        
    }
}
