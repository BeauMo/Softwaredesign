using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Dozent
    {
        public Dozent(string name, string prename, int[] blockedDays)
        {
            this.name = name;
            this.prename = prename;
            this.personalTimetable = new Timetable();
            this.blockedDays = blockedDays;
        }

        public string name;
        public string prename;
        public Timetable personalTimetable; 
        public int[] blockedDays;

        public bool hasTime(int numberOfDay){
            foreach(int blockedDay in blockedDays)
            {
                if(numberOfDay+1 == blockedDay){
                    return false;
                }
            }
            return true;
        }
        
    }
}