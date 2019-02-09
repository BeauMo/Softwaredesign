using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Program
    {
        public static List<Studium> studys = new List<Studium>();
        public static List<Course> courses = new List<Course>();
        public static List<Dozent> dozenten = new List<Dozent>();
        public static List<Room> rooms = new List<Room>();
        public static List<WPM> wpms = new List<WPM>();
        public static Settings settings;

        static void Main(string[] args)
        {
            newElements();
            Generator generator = new Generator(rooms, studys, dozenten, courses, wpms);
            createTimetables(generator);

            rooms[0].roomTimetable.show();
        }

        public static void createTimetables(Generator generator)
        {
            foreach (int block in settings.orderBlocks)
            {
                generator.fillBlock(block);
            }


        }
        public static void newElements()
        {
            dozenten.Add(new Dozent("Michael", "Waldowski", new List<Course>(), new int[2]{4,5}));
            courses.Add( new Course
            (
                "GDV",
                "Grafische Datenverarbeitung",
                dozenten[0],
                new List<Studium>(),
                new List<Conditions> { Conditions.Normal }
            )
            );
            rooms.Add(new Room("I.01", 30, new List<Conditions>{Conditions.Normal}));

            studys.Add(new Studium("MIB4", 12));

            settings = new Settings(new int[6] { 2, 3, 4, 1, 5, 6 }, 5, 2, 3, true);

        }
    }
}

