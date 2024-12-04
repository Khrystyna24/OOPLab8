using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManLibrary
{
    public class Student : Man
    {
        public int YearOfStudy { get; set; }

        public Student() : base() { }

        public Student(string name, int age, double weight, string gender, int yearOfStudy)
            : base(name, age, weight, gender) 
        {
            YearOfStudy = yearOfStudy;
        }

        public Student(Student other) : base(other)
        {
            YearOfStudy = other.YearOfStudy;
        }

        public void ChangeYearOfStudy(int newYear) => YearOfStudy = newYear;

        public override void ShowInfo()
        {
            base.ShowInfo(); 
            Console.WriteLine($"Рік навчання: {YearOfStudy}");
        }
    }

}
