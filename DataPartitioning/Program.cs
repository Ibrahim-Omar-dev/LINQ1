using ShareData;
using System.Drawing;
namespace DataPartitioning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunSkip();
            //RunTake();
            //RunChunk();
            RunPagination();
        }
        public static void RunSkip()
        {
            var emps = Repository.LoadEmployees();
            var q1 = emps.Skip(10);
            //q1.Print("skip first 10 element in list");
            var q2=emps.SkipWhile(e=>e.Salary != 214400);
            //q2.Print("skip while salary does not equal 214,400");
            var q3=emps.SkipLast(10);
            q3.Print("skip last 10 elements");
            Console.ReadKey();
        }
        public static void RunTake()
        {
            var emps = Repository.LoadEmployees();
            var q1 = emps.Take(10);
            //q1.Print("skip first 10 element in list");
            var q2 = emps.TakeWhile(e => e.Salary != 214400);
            //q2.Print("skip while salary does not equal 214,400");
            var q3 = emps.TakeLast(10);
            q3.Print("skip last 10 elements");
            Console.ReadKey();
        }
        public static void RunChunk()
        {
            var emps = Repository.LoadEmployees();
            var q1=emps.Chunk(15).ToList();
            for (int i = 0; i < q1.Count(); i++)
            {
                q1[i].Print($"Chunk #{i + 1}");
            }
        }
        //Pagination Example Real use case
        public static void RunPagination()
        {
            var page = 1;
            var size = 10;
            Console.WriteLine("result per page:");
            if (int.TryParse(Console.ReadLine(), out int resultPerPage))
            {
                size = resultPerPage;
            }
            Console.WriteLine("page No.:");
            if (int.TryParse(Console.ReadLine(), out int pageNo))
            {
                page = pageNo;
            }
            var emps = Repository.LoadEmployees();
            var result= emps.Paginate(page,size);

            int resultCount=result.Count();
            int startRecord=(page-1) * size+1;
            int endRecord=resultCount < size
                ?startRecord + resultCount -1
                : size * (page - 1) + size;
            result.Print($"showing employees {startRecord} - {endRecord}");
        }
    }
}
