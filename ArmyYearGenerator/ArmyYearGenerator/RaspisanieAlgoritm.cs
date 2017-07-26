using NecistikAlg;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmyYearGenerator;

namespace ZabrodinAlg
{
    public class RaspisanieAlgoritm
    {
        public static void FillDaysFromSubjs(List<Subject> subjs, ref List<ILikeWorkingDay> days)

        {
            subjs = cutLongSubjects(subjs, 3);
            int daysCount = days.Count;
            subjs = subjs.OrderBy(x => x.getFrequence(daysCount)).ToList();//Сортировка LinQ по frequence

            int priorityDay;
            double minPriorityKoef;

            minPriorityKoef = GetMinPriorityKoef(days);

            for (int i = 0; i < subjs.Count; i++)
            {
                Subject thisSubj = subjs[i];
                priorityDay = GetPriorityDay(days);

                while (!thisSubj.lessons[thisSubj.lessons.Count - 1].isAdded)
                {
                    int ObXodFlag = 0;
                    bool failFlag = false;

                    while (days[priorityDay].getPriority() > minPriorityKoef ||
                        days[priorityDay].AddLectureFromSubject(thisSubj, true) != 0)
                    {
                        priorityDay = (priorityDay + 1) % daysCount;
                        ObXodFlag++;

                        if (ObXodFlag == daysCount)
                        {
                            minPriorityKoef += 0.1;
                            ObXodFlag = 0;
                            if (minPriorityKoef > 1)
                            {
                                failFlag = true;
                                break;

                            }
                        }
                    }
                    if (!failFlag)
                    {
                        days[priorityDay].AddLectureFromSubject(thisSubj, false);
                        priorityDay = (priorityDay + thisSubj.getFrequence(daysCount)) % daysCount;
                    }
                    else
                    {
                        thisSubj.MarkLessonLikeUnAdd();
                        priorityDay = (priorityDay + thisSubj.getFrequence(daysCount)) % daysCount;
                    }
                    minPriorityKoef = GetMinPriorityKoef(days);
                }
            }

        }

        public static void FillDataResultFromFP(Subject subjFP, ref DateResult dateResult)
        {
            List<ILikeWorkingDay> days = new List<ILikeWorkingDay>();

            foreach (var thisDay in dateResult.All_days)
            {
                foreach (var thisDict in thisDay.Dict)
                {
                    if (thisDict.name == "ФП")
                    {
                        days.Add(new WorkingDay(thisDay.Name, thisDict.lessons.Count()));
                    }
                }
            }

            int daysCount = days.Count;

            int priorityDay;
            double minPriorityKoef;

            minPriorityKoef = GetMinPriorityKoef(days);


            Subject thisSubj = subjFP;

            priorityDay = GetPriorityDay(days);

            while (!thisSubj.lessons[thisSubj.lessons.Count - 1].isAdded)
            {
                int ObXodFlag = 0;
                bool failFlag = false;

                while (days[priorityDay].getPriority() > minPriorityKoef ||
                    days[priorityDay].AddLectureFromSubject(thisSubj, true) != 0)
                {
                    priorityDay = (priorityDay + 1) % daysCount;
                    ObXodFlag++;

                    if (ObXodFlag == daysCount)
                    {
                        minPriorityKoef += 0.1;
                        ObXodFlag = 0;
                        if (minPriorityKoef > 1)
                        {
                            failFlag = true;
                            break;

                        }
                    }
                }
                if (!failFlag)
                {
                    days[priorityDay].AddLectureFromSubject(thisSubj, false);
                    priorityDay = (priorityDay + thisSubj.getFrequence(daysCount)) % daysCount;
                }
                else
                {
                    thisSubj.MarkLessonLikeUnAdd();
                    priorityDay = (priorityDay + thisSubj.getFrequence(daysCount)) % daysCount;
                }
                minPriorityKoef = GetMinPriorityKoef(days);
            }

            FillDaysBySamPo(ref days);

            int flag = 0;
            foreach (var thisDay in dateResult.All_days)
            {
                for (int i = 0; i < thisDay.Dict.Count; i++)
                {
                    var thisSubj2 = thisDay.Dict[i];
                    if (thisSubj2.name == "ФП")
                    {

                        List<Lesson> newLessons = ((WorkingDay)days[flag]).hours.ToList();

                        for (int j = 0; j < newLessons.Count; j++)
                        {

                            newLessons[j].startTime = thisSubj2.lessons[j].startTime;
                            newLessons[j].endTime = thisSubj2.lessons[j].endTime;
                        }

                        thisDay.Dict.Remove(thisSubj2);
                        flag++;
                        thisDay.Dict.Insert(i, new Subject("ФП", newLessons));
                    }
                }
            }

        }

        public static void FillDaysBySamPo(ref List<ILikeWorkingDay> days)
        {
            foreach (var thisDay in days)
            {
                thisDay.FillWithSamPo();
            }
        }

        private static int GetPriorityDay(List<ILikeWorkingDay> days)
        {
            int priorityDay = 0;

            double tmpPriorityKoef = 1;
            double minPriorityKoef = (double)days[0].CountNoFreeHours() / (double)days[0].CountAllHours();

            for (int i = 0; i < days.Count; i++)
            {
                tmpPriorityKoef = (double)days[i].CountNoFreeHours() / (double)days[i].CountAllHours();
                if (tmpPriorityKoef < minPriorityKoef) { minPriorityKoef = tmpPriorityKoef; priorityDay = i; }

            }

            return priorityDay;
        }
        private static double GetMinPriorityKoef(List<ILikeWorkingDay> days)
        {
            return days.Min(x => x.getPriority());
        }
        public static void MyListToDateResult(List<ILikeWorkingDay> days, ref DateResult d)
        {
            int flag = 0;
            foreach (var thisDay in d.All_days)
            {
                for (int i = 0; i < thisDay.Dict.Count; i++)
                {
                    var thisSubj = thisDay.Dict[i];
                    if (thisSubj.name == "БП")
                    {

                        List<Lesson> newLessons = ((WorkingDay)days[flag]).hours.ToList();

                        for (int j = 0; j < newLessons.Count; j++)
                        {

                            newLessons[j].startTime = thisSubj.lessons[j].startTime;
                            newLessons[j].endTime = thisSubj.lessons[j].endTime;
                        }

                        thisDay.Dict.Remove(thisSubj);
                        flag++;
                        thisDay.Dict.Insert(i, new Subject("БП", newLessons));
                    }
                }
            }
        }
        public static List<Lesson> GetUnAddedLessons(List<Subject> subjs)
        {
            List<Lesson> output = new List<Lesson>();
            foreach (var thisSubj in subjs)
            {
                foreach (var thisLesson in thisSubj.lessons)
                {
                    if (thisLesson.isCannotAdd)
                    {
                        output.Add(thisLesson);
                    }

                }
            }

            return output;
        }

        public static List<Subject> GetUnAddedSubjects(List<Subject> subjs)
        {
            List<Subject> output = new List<Subject>();
            foreach (var thisSubj in subjs)
            {

                List<Lesson> lessons = new List<Lesson>();

                foreach (var thisLesson in thisSubj.lessons)
                {
                    if (thisLesson.isCannotAdd)
                    {
                        lessons.Add(thisLesson);
                    }

                }
                Subject currentSubj = new Subject(thisSubj.name, lessons);
                output.Add(currentSubj);
            }

            return output;
        }

        private static List<Subject> cutLongSubjects(List<Subject> subjs, int maxLength)
        {
            List<Subject> outPut = subjs.Select(x =>
            {
                Subject forOut = new Subject(x.name, new List<Lesson>());

                foreach (var thisLesson in x.lessons)
                {
                    if (thisLesson.hoursOfThisLecture >= maxLength)
                    {
                        List<Lesson> insertLessons = new List<Lesson>();
                        int i = 0;
                        while (true)
                        {

                            if (i + 2 <= thisLesson.hoursOfThisLecture)
                            {
                                insertLessons.Add(new Lesson(thisLesson.name, 2, thisLesson.endTime, thisLesson.startTime));
                                i = i + 2;
                            }
                            else if (i + 1 <= thisLesson.hoursOfThisLecture)
                            {
                                insertLessons.Add(new Lesson(thisLesson.name, 1, thisLesson.endTime, thisLesson.startTime));
                                i = i + 1;
                            }
                            else break;
                        }

                        int lessonIndex = x.lessons.IndexOf(thisLesson);
                        forOut.lessons.InsertRange(lessonIndex, insertLessons);
                    }
                    else
                    {
                        forOut.lessons.Add(thisLesson);
                    }
                }
                return forOut;
            }).ToList();


            return outPut;
        }
    }
    public interface ILikeWorkingDay2
    {

        String Name { get; }
        int CountFreeHours();



    }
    public interface ILikeWorkingDay : ILikeWorkingDay2
    {
        int AddLectureFromSubject(Subject newSubject, bool checkOnly);
        String Print();
        double getPriority();
        int CountNoFreeHours();
        int CountAllHours();

        void FillWithSamPo();

    }
    public class WorkingDay : ILikeWorkingDay
    {
        public string Name { get; set; }
        public Lesson[] hours;
        public WorkingDay(String newName, int hoursCount)
        {
            hours = new Lesson[hoursCount];
            Name = newName;
        }
        public int CountFreeHours()
        {
            int output = 0;

            foreach (var thisHour in this.hours)
            {
                if (thisHour == null) { output++; }
            }

            return output;
        }
        public int CountNoFreeHours()
        {
            int output = 0;

            foreach (var thisHour in this.hours)
            {
                if (thisHour != null) { output++; }
            }

            return output;
        }

        public void FillWithSamPo()
        {
            int firstNullHour = -1;

            for (int j = 0; j < hours.Length; j++)
            {
                if (hours[j] == null)
                {
                    firstNullHour = j;
                    break;
                }
            }
            if (firstNullHour != -1)
            {
                for (int i = firstNullHour; i < hours.Length; i++)
                {
                    hours[i] = new Lesson("Самостоятельная подготовка", 1);
                }
            }
        }
        public int AddLectureFromSubject(Subject newSubject, bool checkOnly)
        {

            int freeHours = this.CountFreeHours();

            Lesson firsLectureForAdding = null;

            for (int i = 0; i < newSubject.lessons.Count; i++)
            {
                if (newSubject.lessons[i].isAdded == false)
                {
                    firsLectureForAdding = newSubject.lessons[i];



                    break;
                }
            }


            if (freeHours >= firsLectureForAdding.hoursOfThisLecture)
            {
                if (!checkOnly)
                {

                    int firstNullHour = 0;

                    for (int j = 0; j < hours.Length; j++)
                    {
                        if (hours[j] == null)
                        {
                            firstNullHour = j;
                            break;
                        }
                    }


                    for (int i = 0; i < firsLectureForAdding.hoursOfThisLecture; i++)
                    {
                        Lesson L = new Lesson(firsLectureForAdding.name, firsLectureForAdding.hoursOfThisLecture);
                        hours[firstNullHour] = L;
                        hours[firstNullHour].subjectName = newSubject.name;

                        firstNullHour++;
                    }
                    firsLectureForAdding.isAdded = true;
                }
                return 0;
            }
            else return 1;

        }
        public String Print()
        {
            String output = "";

            for (int i = 0; i < hours.Length; i++)
            {
                if (hours[i] != null)
                {
                    output += i + ": " + hours[i].name + ";\n";
                }
                else output += i + ": **************************" + ";\n";
            }

            return output;
        }
        public double getPriority()
        {
            double output = (double)this.CountNoFreeHours() / (double)this.hours.Length;
            return output;
        }
        public override string ToString()
        {
            return this.Name;
        }
        public int CountAllHours()
        {
            return hours.Length;
        }

    }

}
