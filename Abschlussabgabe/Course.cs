using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Course
    {

        public Course(string name, string description, Dozent dozent, List<Studium> participants, List<Conditions> conditions)
        {
            this.name = name;
            this.description = description;
            this.dozent = dozent;
            this.participants = participants;
            this.conditions = conditions;

        }

        public Course(){}

        public string name;
        public string description;
        public Dozent dozent;
        public List<Studium> participants;
        public List<Conditions> conditions; 
    }
}