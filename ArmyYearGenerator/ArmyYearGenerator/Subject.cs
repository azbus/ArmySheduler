using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabrodinAlg
{
    public class Subject
    {
        public string name;
        public List<Lesson> lessons;

        public Subject()
        {

        }
        public Subject(string subjectName, List<Lesson> lessons)
        {
            name = subjectName;
            this.lessons = lessons;
        }
        public int getFrequence(int daysCount)
        {
            return daysCount / this.lessons.Count;
        }
        public void MarkLessonLikeUnAdd()
        {

            Lesson firsLectureForAdding = null;

            for (int i = 0; i < this.lessons.Count; i++)
            {
                if (this.lessons[i].isAdded == false)
                {
                    firsLectureForAdding = this.lessons[i];


                    break;
                }
            }

            firsLectureForAdding.isCannotAdd = true;
            firsLectureForAdding.isAdded = true;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
