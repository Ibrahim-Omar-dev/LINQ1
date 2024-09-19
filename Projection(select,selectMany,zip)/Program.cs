using FunctionalProgramming;

namespace Projection_select_selectMany_zip_
{
    public class Program
    {
        static void Main(string[] args)
        {
            //RunSelect();
            // RunSelectMany();
            RunZip();
        }
        public static void RunSelect()
        {
            var employee=Repository.LoadEmployees();
            List<string> words = new() { "i", "love", "I","asp.net", "core" };

            var reslut = words.Select(x => x.ToUpperInvariant()).Distinct();

            var result01=(from word in words
                         select word.ToUpperInvariant()).Distinct();
            foreach (var item in result01)
            {
                Console.WriteLine(item);
            }
            foreach (var word in reslut)
            {
                Console.WriteLine(word);
            }
            
        }
        public static void RunSelectMany()
        {
            var employee=Repository.LoadEmployees();
            string[] sentences = {
                "I love asp.net core",
                "I like sql server also",
                "in general i love programming"
            };
            var result=sentences.SelectMany(x=>x.Split(' '));   
            foreach(var sent in result)
            {
                Console.WriteLine(sent);
            }
            Console.WriteLine("-------------------------------------------");
            var result01=from words in sentences
                         from word in words.Split(" ")
                         select word;
            foreach (var item in result01)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===============================================");
            var result02 = employee.SelectMany(x => x.Skills).Distinct();
            foreach (var skills in result02)
            {
                Console.WriteLine(skills);
            }
            Console.WriteLine("-------------------------------------------------");
            var result03=(from emp in employee
                         from skill in emp.Skills
                         select skill).Distinct();
            foreach (var item in result03)
            {
                Console.WriteLine(item);
            }

        }
        public static void RunZip()
        {
            string[] colorName = { "Red", "Green", "Blue" };
            string[] colorHEX = { "FF0000", "00FF00", "0000FF", "extra" };
            //var colors = colorName.Zip(colorHEX, (name, hex) => $"{name} ({hex})");
            var colors=colorName.Zip(colorHEX);
            foreach (var item in colors)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------");
            var colors01 = from color in colorName.Zip(colorHEX)
                           select $"{color.First} {color.Second}";
            foreach (var item in colors01)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========================================");
            var employee = Repository.LoadEmployees().ToArray() ;
            var firstThreeEmps = employee[..3];
            var lastThreeEmps = employee[^3..];
            var teams=firstThreeEmps.Zip(lastThreeEmps,(first,last)=>
            $"{first.FullName} with {last.FullName}");
            foreach (var team in teams)
            {
                Console.WriteLine(team);
            }
            Console.WriteLine("--------------------------------------------");
            var teams01 = from team in firstThreeEmps.Zip(lastThreeEmps)
                          select $"{team.First.FullName} with {team.Second.FullName}";

            foreach (var team in teams01)
                Console.WriteLine(team);

        }
    }
}
