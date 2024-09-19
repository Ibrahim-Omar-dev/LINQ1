

namespace EqualityOperations
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            //RunMethod1();
            //RunMethod2();
            //RunMethod3();
            RunMethod4();
            RunMethod5();

        }
        public static void RunMethod1()
        {
            var q1 = QuestionBank.PickOne();
            var q2 = QuestionBank.PickOne();
            var q3 = QuestionBank.PickOne();

            var list1=new List<Question>(new[]{ q1,q2,q3});
            var list2=new List<Question>(new[]{ q1,q2,q3});

            var equal = list1.SequenceEqual(list2);
            Console.WriteLine($"quiz#1 and quiz#2 {(equal ? "are" : "are not")} equal");//true
        }
        public static void RunMethod2()
        {
            var list = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4));
            var quiz1 = list;
            var quiz2 = list;

            var equal = quiz1.SequenceEqual(quiz2);
            Console.WriteLine($"quiz#1 and quiz#2 {(equal ? "are" : "are not")} equal");//true
        }
        public static void RunMethod3()
        {
            var list1 = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4));
            var list2 = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4));


            var equal = list1.SequenceEqual(list2);
            Console.WriteLine($"quiz#1 and quiz#2 {(equal ? "are" : "are not")} equal");//true
        }

        public static void RunMethod4()
        {
            var quiz1 = QuestionBank.Randomize(3);
            var quiz2 = QuestionBank.Randomize(2);
            var quiz3=quiz1.Concat(quiz2);
            foreach (var item in quiz3)
            {
                Console.WriteLine(item);
            }

        }
        public static void RunMethod5()
        {
            var quiz1 = QuestionBank.Randomize(3);
            var quiz2 = QuestionBank.Randomize(2);
            var quiz3=quiz1.Select(q=>q.Title).Concat(quiz2.Select(q=>q.Title));
            foreach (var item in quiz3)
            {
                Console.WriteLine(item);
            }

        }
    }
}
