using System;
using System.Linq;

namespace Laba4
{
    class Program
    {
        private static void Main(string[] args)
        {
            Student[] students =
            {
            new Student("Исаев Н.А", "20ИТ17", new int[] {5,5,5,5,5 }),
            new Student("Брыкин С.С", "20ИТ20", new int[] {4,5,4,5,4}),
            new Student("Акимов И.А.", "19ИТ21", new int[] {3,5,4,5,2}),
            new Student("Серебряков Г.Р.", "21ИТ24", new int[]{5,5,5,3,4}),
            new Student("Шведов Н.А.", "20ИТ17", new int[]{2,3,4,5,5}),
            new Student("Бураев А.С.", "20ПТ11", new int[]{5,4,3,2,2}),
            new Student("Липунцов В.А", "18ПТ16", new int[]{3,3,3,2,5})
        };
            foreach (Student student in students)
            {
                student.Print();
            }
            Console.WriteLine();
            var sortedStudents = students.OrderBy(s => s.AvgGrade);
            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
        }
    }
    struct Student
    {
        string surname;
        string group;
        int[] grades;
        double avgGrade;

        public Student(string surname, string group, int[] grades)
        {
            this.surname = surname;
            this.group = group;
            this.grades = grades;
            avgGrade = grades.Average();
        }
        public double AvgGrade
        {
            get { 
                return avgGrade; 
                }
        }
        public void Print()
        {
            Console.WriteLine("ФИО" + surname + "группа" + group + "средний балл:" + avgGrade);
        }
    }
  

}

