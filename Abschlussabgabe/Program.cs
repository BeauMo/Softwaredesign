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
            Console.WriteLine();
            studys[0].timetable.show();
            Console.WriteLine();
            dozenten[0].personalTimetable.show();
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
            dozenten.Add(new Dozent("Michael", "Waldowski", new int[2] { 4, 5 }));
            dozenten.Add(new Dozent("Dirk", "Eisenbigler", new int[2] {3,4}));
            dozenten.Add(new Dozent("Fridl", "Dell'Oro", new int[2] { 1, 2 }));
            studys.Add(new Studium("MIB4", 12));
            studys.Add(new Studium("MIB1", 35));
            courses.Add(new Course("GDV", "Grafische Datenverarbeitung", dozenten[0], new List<Studium>(){studys[0]}, new List<Conditions> { Conditions.Normal }));
            courses.Add(new Course("SWD", "Softwaredesign", dozenten[2], new List<Studium>(){studys[0]}, new List<Conditions> { Conditions.Computer }));
            courses.Add(new Course("PGR", "Programmieren", dozenten[1], new List<Studium>(){studys[1]}, new List<Conditions>(){Conditions.Normal}));
            rooms.Add(new Room("I0.01", 30, new List<Conditions> { Conditions.Normal }));
            rooms.Add(new Room("L1.01", 30, new List<Conditions> { Conditions.Computer }));
            rooms.Add(new Room("L1.06a", 40, new List<Conditions> { Conditions.Normal }));

            settings = new Settings(new int[6] { 2, 3, 4, 1, 5, 6 }, 5, 2, 3);

        }
    }
}

