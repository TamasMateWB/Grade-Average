﻿using Grade_Average;
using System.Diagnostics;

// --------
// Copied 
// --------

/*
// initialize variables - graded assignments 

int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

Console.WriteLine("Sums:" + Environment.NewLine);

Console.WriteLine("Sophia: " + sophiaSum);
Console.WriteLine("Nicolas: " + nicolasSum);
Console.WriteLine("Zahirah: " + zahirahSum);
Console.WriteLine("Jeong: " + jeongSum);

Console.WriteLine(Environment.NewLine + "Averages:" + Environment.NewLine);

decimal sophiaScore = sophiaSum / currentAssignments;
decimal nicolasScore = nicolasSum / currentAssignments;
decimal zahirahScore = zahirahSum / currentAssignments;
decimal jeongScore = jeongSum / currentAssignments;

Console.WriteLine("Sophia: " + sophiaScore);
Console.WriteLine("Nicolas: " + nicolasScore);
Console.WriteLine("Zahirah: " + zahirahScore);
Console.WriteLine("Jeong: " + jeongScore);

Console.WriteLine(Environment.NewLine + "Decimal Averages with Grades:" + Environment.NewLine);

sophiaScore = (decimal)sophiaSum / currentAssignments;
nicolasScore = (decimal)nicolasSum / currentAssignments;
zahirahScore = (decimal)zahirahSum / currentAssignments;
jeongScore = (decimal)jeongSum / currentAssignments;

Console.WriteLine("Student\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");
*/



// -----
// Own
// -----


// declare
Student student1 = new("student1", new List<int> { 3, 4, 5, 6, 7 });
Student student2 = new("student2", new List<int> { 1, 2, 3, 4, 5 });
Student student3 = new("student3", new List<int> { 6, 7, 8, 9, 10 });
List<Student> students = new List<Student> { student1, student2, student3 };

// fancy print
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Name\t\tGrades\t\tSum\tAverage");
foreach (Student student in students)
{
    // name
    Console.Write(student.name + "\t");
    // grades
    foreach(int grade in student.grades)
    {
        Console.Write(grade + " ");
    }
    Console.Write("\t");
    // sum
    Console.Write(student.GetGradesSum() + "\t");
    // avg
    Console.Write(student.GetGradesAvg());
    // new line
    Console.WriteLine();
}

// print avg
Console.WriteLine("" + Environment.NewLine + "Name\t\tAverage");
Console.WriteLine(student1.name + ": \t" + student1.GetGradesAvg());
Console.WriteLine(student2.name + ": \t" + student2.GetGradesAvg());
Console.WriteLine(student3.name + ": \t" + student3.GetGradesAvg());