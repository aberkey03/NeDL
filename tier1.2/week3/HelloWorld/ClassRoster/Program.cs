using System;

namespace ClassRoster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Andrew", "Berkey");
            Console.WriteLine(person1);

            Instructor instructor1 = new Instructor("Danielle", "Alesi", "email@email.com");
            Console.WriteLine(instructor1);

            Student student1 = new Student("Student", "Testerson", "13");
            Console.WriteLine(student1);
        }
    }
}
