using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Generator
    {
        public Generator(List<Room> rooms, List<Studium> studys, List<Dozent> dozenten, List<Course> courses)
        {
            this.rooms = rooms;
            this.studys = studys;
            this.dozenten = dozenten;
            this.courses = courses;
        }

        public List<Room> rooms;

        public List<Studium> studys;

        public List<Dozent> dozenten;

        public List<Course> courses;

        public void fillBlock(int block)
        {
            Random rnd = new Random();
            List<Room> tempRooms = this.rooms;
            foreach(Room room in rooms)
            {
                foreach(Day day in room.roomTimetable.weekdays){
                    List<Condition> conditions = room.roomConditions;
                    Block b = day.blocksOnDay[block];
                }

            }
        }

        
    }
}