using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Abschlussabgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator generator = new Generator();
            jsonRead(generator);
            Settings settings = new Settings(new int[6] { 2, 3, 4, 1, 5, 6 }, 5, 2, 3);

            foreach(Studium studium in generator.allStudys)
            {
                Console.WriteLine(studium.name);
            }
            //Datas.createDatas(generator);

            jsonWrite(generator);

            createTimetables(generator, settings);

            Console.WriteLine(generator.allStudys[1].name + ":");
            generator.allStudys[1].timetable.show();

            // Console.WriteLine();
            // Console.WriteLine(generator.allDozenten[6].prename);
            // generator.allDozenten[6].timetable.show();

            // Console.WriteLine();
            // Console.WriteLine();
            // Console.WriteLine("Nicht gesetzte Kure:");
            // foreach (Course course in generator.allCourses)
            //     Console.Write(course.name + " ,");
        }

        public static void createTimetables(Generator generator, Settings settings)
        {
            generator.createEmptyTimetables();
            
            foreach (int block in settings.orderBlocks)
            {
                generator.fillBlock(block - 1);
            }


        }

        public static void jsonWrite(Generator generator)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects,
                Formatting = Formatting.Indented,
            };

            string JStudys = JsonConvert.SerializeObject(generator.allStudys,settings);
            string JRooms = JsonConvert.SerializeObject(generator.allRooms,settings);
            string JCourses = JsonConvert.SerializeObject(generator.allCourses,settings);
            string JDozenten = JsonConvert.SerializeObject(generator.allDozenten,settings);
            string JWpms = JsonConvert.SerializeObject(generator.allWpms,settings);

            using (StreamWriter sw = new StreamWriter("Studiengänge.json",false)){sw.WriteLine(JStudys);}
            using (StreamWriter sw = new StreamWriter("Räume.json",false)){sw.WriteLine(JRooms);}
            using (StreamWriter sw = new StreamWriter("Kurse.json",false)){sw.WriteLine(JCourses);}
            using (StreamWriter sw = new StreamWriter("Dozenten.json",false)){sw.WriteLine(JDozenten);}
            using (StreamWriter sw = new StreamWriter("WPMs.json",false)){sw.WriteLine(JWpms);}

        }

        public static void jsonRead(Generator generator)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects,
                Formatting = Formatting.Indented,
            };
            
            generator.allStudys = JsonConvert.DeserializeObject<List<Studium>>(File.ReadAllText("Studiengänge.json"), settings);
            generator.allRooms = JsonConvert.DeserializeObject<List<Room>>(File.ReadAllText("Räume.json"), settings);
            generator.allCourses = JsonConvert.DeserializeObject<List<Course>>(File.ReadAllText("Kurse.json"), settings);
            generator.allDozenten = JsonConvert.DeserializeObject<List<Dozent>>(File.ReadAllText("Dozenten.json"), settings);
            generator.allWpms = JsonConvert.DeserializeObject<List<WPM>>(File.ReadAllText("WPMs.json"), settings);
        }
    }
}

