using System;
using System.Collections.Generic;

namespace Abschlussabgabe{
    class Datas
    {
        public static void createDatas(Generator generator)
        {
            /*Dozent Waldowski = new Dozent("Michael", "Waldowski", new int[2] { 4, 5 });
                dozenten.Add(Waldowski); //0
                Dozent DellOro = new Dozent("Fridl", "Dell'Oro", new int[2] { 1, 2 });
                dozenten.Add(DellOro); //1 */
                Dozent Eisenbigler = new Dozent("Dirk", "Eisenbigler", new int[2] {3,4});
                generator.allDozenten.Add(Eisenbigler);  //2
                Dozent Reusch = new Dozent("Matthias", "Reusch", new int[2] { 2, 3 });
                generator.allDozenten.Add(Reusch); //3
                Dozent Herbstreit = new Dozent("Achim", "Herbstreit", new int[2] { 4, 5 });
                generator.allDozenten.Add(Herbstreit); //4
                Dozent Schneider = new Dozent("Thomas", "Schneider", new int[2] { 3, 5 });
                generator.allDozenten.Add(Schneider); //5
                Dozent Hottong = new Dozent("Nikolaus", "Hottong", new int[2] { 1, 2 });
                generator.allDozenten.Add(Hottong); //6
                Dozent Dittler = new Dozent("Ullrich", "Dittler", new int[2] { 1, 5 });
                generator.allDozenten.Add(Dittler); //7
                Dozent Fries = new Dozent("Christian", "Fries", new int[2] { 2, 5 });
                generator.allDozenten.Add(Fries); //8
                Dozent Eberle = new Dozent("Christoph", "Eberle", new int[2] { 1, 2 });
                generator.allDozenten.Add(Eberle); //9
                
                Studium MIB1 = new Studium("MIB1", 35); 
                generator.allStudys.Add(MIB1); //0
                Studium MIB4 = new Studium("MIB4", 12);
                generator.allStudys.Add(MIB4); //1
                
                //courses.Add(new Course("GDV", "Grafische Datenverarbeitung", Waldowski, MIB4, new List<Conditions> { Conditions.Normal }));
                //courses.Add(new Course("SWD", "Softwaredesign", DellOro, MIB4, new List<Conditions> { Conditions.Computer }));
                generator.allCourses.Add(new Course("MedTechPra", "Medientechnik Praktikum", Hottong, MIB1, new List<Conditions>(){Conditions.Fernsehstudio}));
                generator.allCourses.Add(new Course("PGR", "Programmieren", Eisenbigler, MIB1, new List<Conditions>(){Conditions.Normal}));
                generator.allCourses.Add(new Course("AT", "Audiotechnik", Reusch, MIB1, new List<Conditions>(){Conditions.Normal}));
                generator.allCourses.Add(new Course("BWL", "Grundlagen der Betriebswirtschaftslehre", Herbstreit, MIB1, new List<Conditions>(){Conditions.Normal}));
                generator.allCourses.Add(new Course("PGR PR", "Programmieren Praktikum", Eisenbigler, MIB1, new List<Conditions>(){Conditions.Normal}));
                generator.allCourses.Add(new Course("BWL PR", "Grundlagen der Betriebswirtschaftslehre Praktikum", Herbstreit, generator.allStudys[0], new List<Conditions>(){Conditions.Normal}));
                generator.allCourses.Add(new Course("MatMedInf1", "Mathematik in Medien und Informatik 1", Schneider, MIB1, new List<Conditions>(){Conditions.Vorlesungssaal}));
                generator.allCourses.Add(new Course("VideoTech", "Videotechnik", Hottong, MIB1, new List<Conditions>(){Conditions.Normal}));
                generator.allCourses.Add(new Course("MedPsych", "Medienpsychologie", Dittler, MIB1, new List<Conditions>(){Conditions.Vorlesungssaal}));
                generator.allCourses.Add(new Course("PhysMedInf", "Physik in Medien und Informatik", Schneider, MIB1, new List<Conditions>(){Conditions.Vorlesungssaal}));
                generator.allCourses.Add(new Course("MINT-Pra", "MINT-Praktikum", Schneider, MIB1, new List<Conditions>(){Conditions.Vorlesungssaal}));
                generator.allCourses.Add(new Course("GrMedGest", "Grundlagen Mediengestaltung", Fries, MIB1, new List<Conditions>(){Conditions.Vorlesungssaal}));
                generator.allCourses.Add(new Course("GrMedGestPra", "Grundlagen Mediengestaltung Praktikum", Eberle, MIB1, new List<Conditions>(){Conditions.Normal}));

            /*rooms.Add(new Room("I0.01", 35, new List<Conditions> { Conditions.Normal }));
                rooms.Add(new Room("L1.01", 35, new List<Conditions> { Conditions.Computer }));
                rooms.Add(new Room("L1.06a", 40, new List<Conditions> { Conditions.Normal })); */
                generator.allRooms.Add(new Room("N0.03", 40, new List<Conditions> { Conditions.Fernsehstudio }));
                generator.allRooms.Add(new Room("I0.15", 90, new List<Conditions> { Conditions.Vorlesungssaal }));
                generator.allRooms.Add(new Room("I0.16", 90, new List<Conditions> { Conditions.Vorlesungssaal }));
                generator.allRooms.Add(new Room("L2.07a", 40, new List<Conditions> { Conditions.Computer }));
                generator.allRooms.Add(new Room("I0.14", 40, new List<Conditions> { Conditions.Vorlesungssaal }));
                generator.allRooms.Add(new Room("I1.20", 40, new List<Conditions> { Conditions.Normal }));
                generator.allRooms.Add(new Room("I2.21", 40, new List<Conditions> { Conditions.Normal }));
                generator.allRooms.Add(new Room("I0.17", 90, new List<Conditions> { Conditions.Vorlesungssaal }));
                generator.allRooms.Add(new Room("I0.13", 40, new List<Conditions> { Conditions.Normal }));

        }
    }
}