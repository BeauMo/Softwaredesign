using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Dozent
    {
        public Dozent(string name, string prename, List<Course>course, int[] blockedDays)
        {
            this.name = name;
            this.prename = prename;
            this.personalTimetable = new Timetable();
            this.courses = new List<Course>();
        }

        public string name;
        public string prename;
        public List<Course> courses;
        public Timetable personalTimetable; 
        
    }
}