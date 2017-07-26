using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmyYearGenerator
{
    public partial class EditDayForm : Form
    {
        List<ArmyEvent> eventsList;
        string dayOfWeek;
        public EditDayForm(List<ArmyEvent> armyDay, string day)
        {
            InitializeComponent();
            eventsList = armyDay;

            foreach (ArmyEvent evnt in armyDay)
            {
                boxEvents.Items.Add(evnt.getStartTime().ToShortTimeString() + "|" + evnt.getEndTime().ToShortTimeString() + "|" + evnt.getName());
            }

            dayOfWeek = day;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {          
            object[] values = new object[boxEvents.CheckedItems.Count];

            for (int i = 0; i < boxEvents.CheckedItems.Count; i++)
            {
                values[i] = boxEvents.CheckedItems[i];
            }

            for (int i = 0; i < values.Length; i++)
            {
                boxEvents.Items.Remove(values[i]);
            }

            
            
        }

        //public List<ArmyEvent> getListEvents()
        //{
        //    return eventsList;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            ArmyEvent evnt;
            eventsList.Clear();

            foreach (var value in boxEvents.Items)
            {
                string line = value.ToString();
                string[] splitedLine = line.Split(new char[] { '|' });

                evnt = new ArmyEvent(splitedLine[2], new string[] { dayOfWeek }, Convert.ToDateTime(splitedLine[0]), Convert.ToDateTime(splitedLine[1]));
                eventsList.Add(evnt);
            }

            Close();
        }
    }
}
