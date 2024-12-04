using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManLibrary
{
    public class Man
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Gender { get; set; }

        public Man() { }

        public Man(string name, int age, double weight, string gender)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Gender = gender;
        }

        public Man(Man other)
        {
            Name = other.Name;
            Age = other.Age;
            Weight = other.Weight;
            Gender = other.Gender;
        }

        public void ChangeAge(int newAge) => Age = newAge;

        public void ChangeWeight(double newWeight) => Weight = newWeight;

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Ім'я: {Name}, Вік: {Age}, Вага: {Weight}, Стать: {Gender}");
        }
    }

}
