using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Course
    {

        public Course(string name, string description, Dozent dozent, List<Studium> togetherWith, List<Conditions> conditions)
        {
            this.name = name;
            this.description = description;
            this.dozent = dozent;
            this.togetherWith = togetherWith;
            this.conditions = conditions;

        }

        public string name;
        public string description;
        public Dozent dozent;
        public List<Studium> togetherWith;
        public List<Conditions> conditions; 
    }
}