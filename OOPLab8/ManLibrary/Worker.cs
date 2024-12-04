using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManLibrary
{
    public class Worker : Man
    {
        public string Position { get; set; }

        public Worker() : base() { }

        public Worker(string name, int age, double weight, string gender, string position)
            : base(name, age, weight, gender) 
        {
            Position = position;
        }


        public Worker(Worker other) : base(other)
        {
            Position = other.Position;
        }

        public void ChangePosition(string newPosition) => Position = newPosition;

        public override void ShowInfo()
        {
            base.ShowInfo(); 
            Console.WriteLine($"Посада: {Position}");
        }
    }

}
