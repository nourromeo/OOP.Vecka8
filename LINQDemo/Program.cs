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

            // method to collect only students in group 3, then sort it by first Name.
            StudentOrderBy(students);

            // method to sort students by their study group and then sort them by first name.
            StudentsGroupBy(students);

        }
        private static void StudentsGroupBy(List<Student> students)
        {
            var studentGroupByLINQ = students.GroupBy(s => s.StudyGroup)
                .OrderBy(s => s.Key).ThenBy(s => s.Key);

            Console.WriteLine("Students city list:");
            foreach (var city in studentGroupByLINQ)
            {
                Console.WriteLine(city.Key);
                foreach(var student in city.OrderBy(s => s.FirstName))
                {
                    Console.WriteLine(student);
                }
            }
        }
        private static void StudentOrderBy(List<Student> students)
        {
            // LINQ Method syntax
            var studentMethodLINQ = students.Where(s => s.StudyGroup == 3)
                .OrderBy(s => s.FirstName)
                .ThenBy(s => s.LastName);

            Console.WriteLine("Students who study in group 3:");
            foreach (var student in studentMethodLINQ.OrderBy(s => s.LastName))
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
    }
}
