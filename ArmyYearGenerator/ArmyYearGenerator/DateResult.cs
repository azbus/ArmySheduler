using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NecistikAlg;

namespace ArmyYearGenerator
{
    public class DateResult
    {
        public List<WorkingDayWithoutLec> All_days { get; set; }

        public DateResult()
        {
            All_days = new List<WorkingDayWithoutLec>();
        }
        public DateResult(List<WorkingDayWithoutLec> new_all_days)
        {
            All_days = new_all_days;
        }

        //Расчёт для диапазона в котором даты диапазона присланны в массиве, в формате {день, месяц, год}
        public void FunctionDateResult(WorkingWeek our_week, int[] start, int[] end)
        {
            DateTime start_date = new DateTime(start[2], start[1], start[0]);
            DateTime end_date = new DateTime(end[2], end[1], end[0]);
            FunctionDateResult(our_week, start_date, end_date);
        }
        public void FunctionDateResult(WorkingWeek our_week, int[] start, DateTime end)
        {
            DateTime start_date = new DateTime(start[2], start[1], start[0]);
            FunctionDateResult(our_week, start_date, end);
        }
        public void FunctionDateResult(WorkingWeek our_week, DateTime start, int[] end)
        {
            DateTime end_date = new DateTime(end[2], end[1], end[0]);
            FunctionDateResult(our_week, start, end_date);
        }

        //Расчёт для нормального диапазона
        public void FunctionDateResult(WorkingWeek our_week, DateTime start, DateTime end)
        {
            DateTime start_date = start;
            DateTime end_date = end;
            DateTime cur_date = start;

            //перенос стандартных выходных в специальные дни
            moving_hollidays_in_special_days(start_date);

            All_days = new List<WorkingDayWithoutLec>();
            WorkingDayWithoutLec buf_inform;

            while (cur_date.CompareTo(end_date) != 1)
            {
                buf_inform = new WorkingDayWithoutLec();

                if (cur_date.IsSpecialDay())
                {
                    buf_inform.Day = cur_date;
                    buf_inform.SetDict(cur_date.get_special_day());
                }
                else
                {
                    buf_inform.Day = cur_date;
                    buf_inform.SetDict(our_week.Work_week[cur_date.DayOfWeek.ToString()]);
                }
             
                All_days.Add(buf_inform);
                //Перейти к следующему дню
                cur_date = cur_date.AddDays(1);
            }
        }

        //Общее кол-во часов за день
        public int getAllDaysCount()
        {
            int result = 0;
            foreach (var d in All_days)
            {
                result = result + d.getAllCounters();
            }
            return result;
        }

        public int getAllDaysCountByObj(string obj)
        {
            int result = 0;
            foreach (var dict in All_days)
            {
                foreach (var d in dict.Dict)
                {
                    if (d.name.Equals(obj))
                    {
                        result = result + d.lessons.Count;
                    }
                }

            }
            return result;
        }

        public bool moving_hollidays_in_special_days(DateTime start_date)
        {
            foreach(var day in HolidayDetector.True_holidays)
            {
                for(int i = 0; i < 2 ; i++)
                {
                    DateTime buf_day = new DateTime(start_date.Year + i, day.Month, day.Day);
                    string[] days = new string[1];
                    SpecialDays.add_special_day(buf_day, new List<ArmyEvent>(new[] { new ArmyEvent("По плану выходных и праздничных дней", days, buf_day, buf_day.AddDays(1)) }));
                }
            }
            return true;
        }
    }
}
