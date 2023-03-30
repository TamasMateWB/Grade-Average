using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Average
{
    internal class Student
    {
        List<int> grades = new List<int>();
        int gradesSum = 0;
        decimal gradesAvg = 0;
        public string name = "";

        public Student() { }

        public Student(string name, List<int> grades)
        {
            this.name = name;
            this.grades = grades;
        }

        public int GetGradesSum()
        {
            gradesSum = 0;
            foreach (int grade in grades)
            {
                gradesSum += grade;
            }
            return gradesSum;
        }

        public decimal GetGradesAvg()
        {
            gradesAvg = 0;
            try
            {
                gradesSum = GetGradesSum();
            }
            catch
            {
                gradesSum = 0;
            }
            gradesAvg = gradesSum / grades.Count;
            return gradesAvg;
        }
    }
}
