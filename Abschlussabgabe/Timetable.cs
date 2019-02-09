using System;

namespace Abschlussabgabe
{
    class Timetable
    {
        public Timetable()
        {
            this.weekdays = new Day[5]{new Day(),new Day(),new Day(),new Day(),new Day()};
        }
        public Day[] weekdays;

        public void show()
        {
            for(int i = 0; i <= 5; i++)
            {
                foreach(Day day in weekdays)
                {
                    if(day.blocksOnDay[i].course != null)
                        Console.Write(day.blocksOnDay[i].course.name + "    ");
                    else Console.Write("Frei    ");
                }
                Console.WriteLine();
            }
        }
    }

}