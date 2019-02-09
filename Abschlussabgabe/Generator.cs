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
            Random rnd = new Random();

            List<Course> tempCourses = new List<Course>();
            foreach(Course copyCourse in courses)
                tempCourses.Add(copyCourse);

            foreach (Room room in rooms)
            {
                int numberOfDay = 0;
                foreach (Day day in room.roomTimetable.weekdays)
                {
                    if (day == null)
                        continue;

                    if (courses.Count == 0)
                        continue;

                    Course course = getPossibleCourse(rnd, tempCourses, room, numberOfDay);

                    if (course == null)
                        continue;

                    day.blocksOnDay[block].course = course;
                    course.dozent.personalTimetable.weekdays[numberOfDay].blocksOnDay[block].course = course;
                    foreach (Studium studium in course.participants)
                    {
                        if (studium.timetable.weekdays[numberOfDay].blocksOnDay[block].course != null)
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
            Course course = courses[0];
            while (i != 1)
            {
                if ((tempCourses == null) || (tempCourses.Count == 0))
                    return null;

                //random = rnd.Next(tempCourses.Count);
                //course = courses[random];
                if (room.compareWithCourse(course) && course.dozent.hasTime(numberOfDay))
                {
                    i = 1;
                }
                else tempCourses.Remove(course);
            }
            return course;
        }


    }
}