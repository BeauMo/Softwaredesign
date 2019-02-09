using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Generator
    {
        public Generator(List<Room> rooms, List<Studium> studys, List<Dozent> dozenten, List<Course> courses, List<WPM> wpms)
        {
            this.rooms = rooms;
            this.studys = studys;
            this.dozenten = dozenten;
            this.courses = courses;
            this.wpms = wpms;
        }

        public List<Room> rooms;

        public List<Studium> studys;

        public List<Dozent> dozenten;

        public List<Course> courses;

        public List<WPM> wpms;

        public void fillBlock(int block)
        {
            int numberOfDay = 0;
            Random rnd = new Random();
            //Check ob man damit nicht auch courses ändert
            List<Course> tempCourses = this.courses;
            foreach(Room room in rooms)
            {
                numberOfDay = 1;
                foreach(Day day in room.roomTimetable.weekdays)
                {
                    Course course = getPossibleCourse(rnd, tempCourses, room, numberOfDay);

                    if(course == null)
                        continue;

                    Block dayBlock = day.blocksOnDay[block];
                    dayBlock.course = course;
                    day.blocksOnDay[block].course = course;
                    course.dozent.personalTimetable.weekdays[numberOfDay].blocksOnDay[block].course = course;
                    foreach(Studium studium in course.participants)
                    {
                        if(studium.timetable.weekdays[numberOfDay].blocksOnDay[block].course != null)
                            courses.Add(studium.timetable.weekdays[numberOfDay].blocksOnDay[block].course);
                        studium.timetable.weekdays[numberOfDay].blocksOnDay[block].course = course;
                    }
                    courses.Remove(course);
                    numberOfDay++;
                }

            }
        }

        private Course getPossibleCourse(Random rnd, List<Course> tempCourses, Room room, int numberOfDay)
        {
            int i = 0;
            int random;
            Course course = null;
            while(i != 1)
            {
                if ( (tempCourses == null) || (tempCourses.Count == 0 ) )
                    return null;
                
                random = rnd.Next(tempCourses.Count);
                course = courses[random];
                if(room.compareWithCourse(course) && course.dozent.hasTime(numberOfDay)){
                    i = 1;
                }
                else tempCourses.RemoveAt(random);
            }
            return course;
        }

        
    }
}