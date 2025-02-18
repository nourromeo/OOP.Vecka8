namespace LINQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            students = StudentHelper.GetStudent();
            Console.WriteLine("how meny students in the list:");
            Console.WriteLine(students.Count);
            Console.WriteLine();

            // LINQ Query sytnax
            var studentQueryLINQ = from student in students
                                   orderby student.FirstName
                                   select student;

            // LINQ Method syntax
            var studentMethodLINQ = students.Where(s => s.StudyGroup == 3)
                .OrderBy(s => s.FirstName)
                .ThenBy(s => s.LastName);

            Console.WriteLine("Students who study in group 3:");

            foreach (var student in studentMethodLINQ)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.StudyGroup);
            }
            Console.WriteLine();


            var studentGroupByLINQ = students.GroupBy(s => s.City)
                .OrderBy(s => s.Key);

            Console.WriteLine("Students city list:");
            foreach (var city in studentGroupByLINQ)
            {
                Console.WriteLine(city.Key);
            }



        }
    }
}
