using System;
using System.Collections.Generic;

namespace Abschlussabgabe
{
    class Datas
    {
        public static void createDatas(Generator generator)
        {
            Dozent Waldowski = new Dozent("Michael", "Waldowski", new int[2] { 4, 5 });
            generator.allDozenten.Add(Waldowski); //0


        }
    }
}