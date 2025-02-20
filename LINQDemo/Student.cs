using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    internal class Student : Person
    {
        public int StudyGroup { get; set; }

        public Student(string firstName, string lastName, string city, int studyGroup)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
            StudyGroup = studyGroup;
        }

        public override string? ToString()
        {
            return $"First Name: {FirstName} - Last Name: {LastName} => Class: {StudyGroup}";
            ;
        }
    }
}
