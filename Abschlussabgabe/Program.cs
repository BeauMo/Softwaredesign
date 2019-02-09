using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Program
    {
        private static List<Studium> studys;
        private static List<Course> courses;
        private static List<Dozent> dozenten;
        private static List<Room> rooms;
        private static List<WPM> wpms;
        private static Settings settings;

        static void Main(string[] args)
        {
            /*newElements();
            Generator generator = new Generator(rooms, studys, dozenten, courses, wpms);
            createTimetables(generator);*/
            test test = new test();
            test.list = new List<int>{1,2,3,4,5};

            List<int> list = new List<int>();

            foreach(int i in test.list)
                list.Add(i);

            list.Remove(3);
            foreach(int s in list)
                Console.Write(s + ", ");
            Console.WriteLine();
            foreach(int s in test.list)
                Console.Write(s + ", ");
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
            Dozent d1 = new Dozent("Michael", "Waldowski", new List<Course>(), new int[2]{4,5});
            Course kurs = new Course
            (
                "GDV",
                "Grafische Datenverarbeitung",
                d1,
                new List<Studium>(),
                new List<Conditions> { Conditions.Normal }
            );

            settings = new Settings(new int[6] { 2, 3, 4, 1, 5, 6 }, 5, 2, 3, true);

        }
    }
}

