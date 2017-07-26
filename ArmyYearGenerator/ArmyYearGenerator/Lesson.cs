using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabrodinAlg
{
    public class Lesson
    {
        public int hoursOfThisLecture;

        public bool isAdded;

        public bool isCannotAdd;

        public String name;

        public String subjectName;

        public DateTime startTime;
        public DateTime endTime;

        public Lesson(String name, int newLectHours)
        {
            hoursOfThisLecture = newLectHours;
            this.name = name;
            isAdded = false;
            isCannotAdd = false;

        }

        public Lesson(String name, int newLectHours, DateTime start, DateTime end)
        {
            hoursOfThisLecture = newLectHours;
            this.name = name;
            isAdded = false;
            isCannotAdd = false;
            startTime = start;
            endTime = end;
        }
        public override string ToString()
        {
            return this.name;
        }
    }

}
