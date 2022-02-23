using System;

namespace MyConnsoleApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var student = new
            {
                Id = 1,
                Name = "Rabi",
                Address = "Jnk",
                Gender = "Male"
            };
            var student2 = new
            {
                Id = 2,
                Name = "Rabi",
                Address = "Jnk",
                Gender = "Male"
            };
            var student3 = new Student(3, "Raju", "GMMM", "Male");


            List<Student> s;
            Dictionary<int, Student> dict;



            Console.WriteLine(student);
        }
    };

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        public Student(int id, string name, string address, string gender)//constructor 
        {
            Id = id;
            Name = name;
            Address = address;
            Gender = gender;
        }
    }
}