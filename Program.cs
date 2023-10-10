using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19__Class_Methods
{
    internal class student
    {
        public double weight;
        public string name;
        public int age;

        public student(double aWeight, string aName, int aAge)
        {
            weight = aWeight;
            name = aName;
            age = aAge;
        }
        public  bool IsObese()
        {
            if (weight > 60)
            {
                return true;
            }
            else return false;
	

	
	

	}
        static void Main(string[] args)
        {
            student student1 = new student(70, "John", 15);
            student student2 = new student(40, "Tim", 10);

            Console.WriteLine(student1.IsObese());
            Console.WriteLine(student2.IsObese());

            Console.ReadLine();

        }
    }
}
