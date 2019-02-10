using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Studium
    {
        public Studium(string name, int students)
        {
            this.name = name;
            this.students = students;
        }

        public string name;

        public int students;

        public Timetable timetable; 
        
        public bool hasTime(int numberOfDay, int block)
        {
            if(timetable.week[numberOfDay].blocksPerDay[block].course == null)
                return true;
            else return false;
        }
    }
}