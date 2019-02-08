using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class WPM : Course
    {
        public WPM(string name, string description, int time, Dozent dozent, List<Conditions> conditions)
        {
            this.name = name;
            this.description = description;
            this.time = time;
            this.dozent = dozent;
            this.togetherWith = new List<Studium>();
            this.conditions = conditions; 
        }
        public int time;
    }
}