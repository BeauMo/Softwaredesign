using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Studium
    {
        public Studium(string name, int students, Timetable timetable)
        {
            this.name = name;
            this.students = students;
            this.timetable = timetable;
        }

        public string name;

        public List<Course> courses;

        public int students;

        public Timetable timetable; 
        
    }
}