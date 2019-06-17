// using System;
// using System.Collections;

// namespace OOP_Interfaces
// {
//     public abstract class Person
//     {
//         public Person(string name, string lastName, int iD)
//         {
//             this.Name = name;
//             this.LastName = lastName;
//             this.ID = iD;

//         }
//         protected string Name { get; }
//         protected string LastName { get; }
//         protected int ID { get; }

//         public override string ToString()
//         {
//             return $"[ {Name} {LastName} - ID: {ID} ]";
//         }
//     }

//     public class Student : Person
//     {
//         public Student(string name, string lastName, int iD, string carreer) : base(name, lastName, iD)
//         {
//             Carreer = carreer;
//         }

//         public string Carreer { get; set; }

//         public void Study()
//         {
//             Console.WriteLine($"{this} esta estudiando");
//         }

//     }

//     public class Employee : Person
//     {
//         public Employee(string name, string lastName, int iD, string position) : base(name, lastName, iD)
//         {
//             Position = position;
//         }

//         public string Position { get; set; }

//         public void Work()
//         {
//             Console.WriteLine($"{this} esta trabajando");
//         }

//     }

//     public class StudentAndEmployee : Employee
//     {
//         public string Career { get; set; }
//         public StudentAndEmployee(string name, string lastName, int iD, string position, string career) : base(name, lastName, iD, position)
//         {
//             Career = career;
//         }

//         public void Study()
//         {
//             Console.WriteLine($"{this} esta estudiando");
//         }
//     }

//     public class Course
//     {
//         private ArrayList students;

//         public Course(ArrayList students)
//         {
//             this.students =students;
//         }

//     }
// }