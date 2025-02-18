using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    internal class StudentHelper
    {
        public static List<Student> GetStudent()
        {
            var students = new List<Student>();

            students.Add(new Student("Clara", "Östberg", "Kalmar", 2));
            students.Add(new Student("Felix", "Fransson", "Örebro", 1));
            students.Add(new Student("William", "Wester", "Halmstad", 3));
            students.Add(new Student("Greta", "Gustafsson", "Linköping", 2));
            students.Add(new Student("Natalie", "Nilsson", "Borås", 1));
            students.Add(new Student("Clara", "Dahl", "Uppsala", 3));
            students.Add(new Student("Zacharias", "Zetterström", "Falun", 2));
            students.Add(new Student("Amanda", "Åberg", "Borlänge", 3));
            students.Add(new Student("Quentin", "Qvist", "Karlstad", 1));
            students.Add(new Student("Emma", "Ek", "Västerås", 2));
            students.Add(new Student("Charlie", "Carlsson", "Malmö", 3));
            students.Add(new Student("Marcus", "Magnusson", "Gävle", 1));
            students.Add(new Student("Tilda", "Törnqvist", "Södertälje", 2));
            students.Add(new Student("Ulf", "Ulander", "Luleå", 3));
            students.Add(new Student("Rebecca", "Rydberg", "Täby", 1));
            students.Add(new Student("Xander", "Xen", "Skövde", 2));
            students.Add(new Student("Petra", "Persson", "Sundsvall", 3));
            students.Add(new Student("Isak", "Ivarsson", "Jönköping", 1));
            students.Add(new Student("Karl", "Karlsson", "Lund", 2));
            students.Add(new Student("Johanna", "Jonsson", "Norrköping", 3));
            students.Add(new Student("Alice", "Andersson", "Stockholm", 1));
            students.Add(new Student("Bob", "Berg", "Göteborg", 2));
            students.Add(new Student("Yasmine", "Yngve", "Karlskrona", 3));
            students.Add(new Student("Oskar", "Olsson", "Eskilstuna", 1));
            students.Add(new Student("Benjamin", "Äng", "Trollhättan", 2));
            students.Add(new Student("Samuel", "Svensson", "Växjö", 3));
            students.Add(new Student("Hugo", "Holm", "Helsingborg", 1));
            students.Add(new Student("Lina", "Larsson", "Umeå", 2));
            students.Add(new Student("Vera", "Viklund", "Kristianstad", 3));
            students.Add(new Student("Tobias", "Nyberg", "Luleå", 1));
            students.Add(new Student("Nour", "Ibrahim", "Spånga", 3));

            return students;
        }
    }
}

