using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //DoApproach1();
            //DoApproach2();

        }

        // private static void DoApproach1()
        // {
        //     Student student = new Student("Juan", "Perez", 40789567, "sistemas");
        //     student.Study();

        //     Employee employee = new Employee("John", "Doe", 50142789, "programmer");
        //     employee.Work();

        //     StudentAndEmployee student1 = new StudentAndEmployee("Osvaldo", "Olmos", 25000687, "programmer", "sistemas");
        //     student1.Work();
        //     student1.Study();

        //     ArrayList students = new ArrayList();
        //     students.Add(student);
        //     students.Add(student1);
        //     students.Add(employee);

        //     Course course = new Course(students);
        // }
        private static void DoApproach2()
        {
            Student student = new Student("Juan", "Perez", 40789567, "sistemas");
            student.Study();

            Employee employee = new Employee("John", "Doe", 50142789, "programmer");
            employee.Work();

            StudentAndEmployee student1 = new StudentAndEmployee("Osvaldo", "Olmos", 25000687, "programmer", "sistemas");
            student1.Work();
            student1.Study();

            List<IStudent> students = new List<IStudent>();
            students.Add(student);
            students.Add(student1);
            //students.Add(employee);

            Course course = new Course(students);
        }

    }
}
