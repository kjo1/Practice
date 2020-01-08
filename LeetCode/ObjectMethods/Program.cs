using System;

namespace ObjectMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John", "Computer Science", 3.6);
            Student student2 = new Student("Jane", "Business", 2.3);

            Console.WriteLine(student1.HasHonours());
            Console.WriteLine(student2.HasHonours());
        }
    }
}
