using System;

namespace Abschlussabgabe
{
    class Timetable
    {
        public Timetable()
        {
            this.weekdays = new Day[5]{new Day(1),new Day(2),new Day(3),new Day(4),new Day(5)};
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