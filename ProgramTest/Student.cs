﻿using System;
namespace ProgramTest
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;


        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;

        }

        // Declare method
        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }
}

