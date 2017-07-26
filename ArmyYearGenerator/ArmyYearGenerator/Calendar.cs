using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZabrodinAlg;

using ArmyYearGenerator;

namespace NecistikAlg
{
   public class Calendar
    {
        public static DateResult TestForCalendar()
        {
            WorkingWeek our_week = new WorkingWeek();
            DateTime sp_d = new DateTime(2017, 2, 7);

            our_week.Work_week["Monday"] = new List<ArmyEvent>(new[] { new ArmyEvent("ФП", null, sp_d, sp_d) });
            our_week.Work_week["Tuesday"] = new List<ArmyEvent>(new[] { new ArmyEvent("ФП", null, sp_d, sp_d) });
            our_week.Work_week["Wednesday"] = new List<ArmyEvent>(new[] { new ArmyEvent("ФП", null, sp_d, sp_d) });
            our_week.Work_week["Thursday"] = new List<ArmyEvent>(new[] { new ArmyEvent("ФП", null, sp_d, sp_d) });
            our_week.Work_week["Friday"] = new List<ArmyEvent>(new[] { new ArmyEvent("ФП", null, sp_d, sp_d) ,  new ArmyEvent("БП", null, sp_d, sp_d) , new ArmyEvent("БП", null, sp_d, sp_d), new ArmyEvent("БП", null, sp_d, sp_d), new ArmyEvent("БП", null, sp_d, sp_d), new ArmyEvent("БП", null, sp_d, sp_d), new ArmyEvent("ОГП", null, sp_d, sp_d), new ArmyEvent("ОГП", null, sp_d, sp_d) });
            our_week.Work_week["Saturday"] = new List<ArmyEvent>(new[] { new ArmyEvent("ФП", null, sp_d, sp_d), new ArmyEvent("БП", null, sp_d, sp_d), new ArmyEvent("ФП", null, sp_d, sp_d), new ArmyEvent("БП", null, sp_d, sp_d) } );
            our_week.Work_week["Sunday"] = new List<ArmyEvent>();

            DateResult test2;

            test2 = new DateResult();
            int[] start = { 1, 2, 2017 };
            int[] end = { 14, 2, 2017 };
            test2.FunctionDateResult(our_week, start, end);

            Console.WriteLine();
            Console.WriteLine(test2.All_days.Count);
            Console.WriteLine();
            Console.WriteLine(test2.getAllDaysCount());
            Console.WriteLine();
            Console.WriteLine(test2.getAllDaysCountByObj("БП"));
            Console.WriteLine();

            foreach (var test in test2.All_days)
            {
                Console.WriteLine();
                Console.WriteLine(test.Name);
                Console.WriteLine(test.CountFreeHours());
            }
            Console.WriteLine();
            return test2;

        }

        public static DateResult TestForCalendar(Dictionary<string, List<ArmyEvent>> armyWeek, DateTime start, DateTime end)
        {
            WorkingWeek our_week = new WorkingWeek(armyWeek);
            DateResult test2;

            test2 = new DateResult();

            test2.FunctionDateResult(our_week, start, end);

            Console.WriteLine();
            Console.WriteLine(test2.All_days.Count);
            Console.WriteLine();
            Console.WriteLine(test2.getAllDaysCount());
            Console.WriteLine();
            Console.WriteLine(test2.getAllDaysCountByObj("БП"));
            Console.WriteLine();

            foreach (var test in test2.All_days)
            {
                Console.WriteLine();
                Console.WriteLine(test.Name);
                Console.WriteLine(test.CountFreeHours());
            }
            Console.WriteLine();
            return test2;

        }
    }
}




public class WorkingWeek
{
    public WorkingWeek()
    {
        Work_week = new Dictionary<string, List<ArmyEvent>>();
    }
    public WorkingWeek(Dictionary<string, List<ArmyEvent>> armyWeek)
    {
        Work_week = new Dictionary<string, List<ArmyEvent>>();
        Work_week["Monday"] = new List<ArmyEvent>();
        Work_week["Tuesday"] = new List<ArmyEvent>();
        Work_week["Wednesday"] = new List<ArmyEvent>();
        Work_week["Thursday"] = new List<ArmyEvent>();
        Work_week["Friday"] = new List<ArmyEvent>();
        Work_week["Saturday"] = new List<ArmyEvent>();
        Work_week["Sunday"] = new List<ArmyEvent>();

        foreach (var armyDay in armyWeek)
        {
            Work_week[armyDay.Key] = armyDay.Value;
        }
    }

    public Dictionary<string, List<ArmyEvent>> Work_week { get; set; }
}

static class SpecialDays
{

    static public Dictionary<DateTime, List<ArmyEvent>> special_days = new Dictionary<DateTime, List<ArmyEvent>>();

    static public bool add_special_day(this DateTime date, List<ArmyEvent> subj)
    {
        if (!date.IsSpecialDay())
        {
            special_days[date] = subj;
            return true;
        }
        else
        {
            return false;
        }
        
    }

    static public bool del_special_day(this DateTime date)
    {
        foreach (var hol in special_days)
        {
            if (hol.Key.CompareTo(date) == 0)
            {
                special_days.Remove(hol.Key);
                return true;
            }
        }
        return false;
    }

    static public List<ArmyEvent> get_special_day(this DateTime date)
    {
        return special_days[date];
    }

    static public bool IsSpecialDay(this DateTime date)
    {
        foreach (var hol in special_days)
        {
            if (hol.Key.CompareTo(date) == 0) return true;
        }
        return false;
    }
    static public bool add_holiday_as_special(this DateTime day)
    {
        string[] days = new string[1];
        return add_special_day(day, new List<ArmyEvent>(new[] { new ArmyEvent("По плану выходных и праздничных дней", days, day, day.AddDays(1)) }));
    }
}

static class HolidayDetector
{
    //Класс выходного дня
    public class Holiday
    {
        public int Day { get; set; }
        public int Month { get; set; }
    }

    static public List<Holiday> True_holidays = new List<Holiday>(
        new[] {
            new Holiday() { Day = 23, Month = 2 },
            new Holiday() { Day = 8, Month = 3 },
            new Holiday() { Day = 1, Month = 5 },
            new Holiday() { Day = 9, Month = 5 },
            new Holiday() { Day = 4, Month = 11 },
            new Holiday() { Day = 1, Month = 1 },
            new Holiday() { Day = 2, Month = 1 },
            new Holiday() { Day = 3, Month = 1 },
            new Holiday() { Day = 4, Month = 1 },
            new Holiday() { Day = 5, Month = 1 },
            new Holiday() { Day = 6, Month = 1 },
            new Holiday() { Day = 7, Month = 1 },
            new Holiday() { Day = 8, Month = 1 },
            new Holiday() { Day = 9, Month = 1 },
            new Holiday() { Day = 10, Month = 1 }
        });

    static public bool add_holiday(this DateTime day)
    {
        return day.add_holiday_as_special();
    }
}

//Класс для работы с днём недели
public class WorkingDayWithoutLec : ILikeWorkingDay2
{
    //public String name;
    public DateTime Day { get; set; }

    //public List<WorkingSub> Dict { get; set; }
    public List<Subject> Dict { get; set; }

    //Конструктор дня по умолчанию
    public WorkingDayWithoutLec()
    {
        Day = DateTime.Now;
    }

    //Общее кол-во часов за день
    public int getAllCounters()
    {
        int result = 0;
        foreach (var d in Dict)
        {
            result = result + d.lessons.Count;
        }
        return result;
    }

    public string Name
    {
        get
        {
            return Day.ToString("dd.MM.yyyy"); ;
        }
    }

    public int CountFreeHours()
    {
        foreach (var d in Dict)
        {
            if (d.name.Equals("БП"))
            {
                return d.lessons.Count;
            }
        }
        return 0;
    }

    public bool SetDict(List<ArmyEvent> old_dict)
    {
        List<Subject> buf_dict = new List<Subject>();
        foreach(var subj in old_dict)
        {
            List<Lesson> lessons = new List<Lesson>();
            foreach (var buf_subj in old_dict)
            {
                if (subj.getName().Equals(buf_subj.getName()))
                {
                    Lesson buf_lesson = new Lesson("", 1, buf_subj.getStartTime(), buf_subj.getEndTime());
                    lessons.Add(buf_lesson);
                }
            }

            Subject buf_subject = new Subject(subj.getName(), lessons);
            if (!IsInDict(buf_subject, buf_dict))
            {
                buf_dict.Add(buf_subject);
            }
        }
        this.Dict = buf_dict;
        return true;
    }

    private bool IsInDict(Subject test, List<Subject> Dict)
    {
        foreach (var res in Dict)
        {
            if (res.name.Equals(test.name)) return true;
        }
        return false;
    }
}
public interface ILikeWorkingDay2
{

    String Name { get; }
    int CountFreeHours();


}