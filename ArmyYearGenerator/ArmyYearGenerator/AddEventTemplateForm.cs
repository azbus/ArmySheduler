using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArmyYearGenerator
{
    public partial class AddEventTemplateForm : Form
    {
        ArmyEvent templateEvent;
        string[] events;
        public AddEventTemplateForm()
        {
            InitializeComponent();
        }
        public AddEventTemplateForm(TreeView tree)
        {
            InitializeComponent();

            events = new string[tree.Nodes.Count];
            for (int i = 0; i < tree.Nodes.Count; i++)
            {
                events[i] = tree.Nodes[i].Text;
            }
        }

        private void buttonAddTemplate_Click(object sender, EventArgs e)
        {
            int countCheckedItems = checkedDaysOfWeek.CheckedItems.Count;
            string[] days = new string[countCheckedItems];

            DateTime startTime = Convert.ToDateTime(maskedTextBoxStartTime.Text);
            DateTime endTime = Convert.ToDateTime(maskedTextBoxEndTime.Text);

            for (int i = 0; i < countCheckedItems; i++)
            {
                days[i] = checkedDaysOfWeek.CheckedItems[i].ToString();
            }

            if (comboBoxEventName.SelectedItem.ToString() == "Боевая подготовка")
            {
                templateEvent = new ArmyEvent("БП", days, startTime, endTime);
            }
            else if (comboBoxEventName.SelectedItem.ToString().Contains("Физическая подготовка"))
            {
                templateEvent = new ArmyEvent("ФП", days, startTime, endTime);
            }
            else
                templateEvent = new ArmyEvent(comboBoxEventName.SelectedItem.ToString(), days, startTime, endTime);

            Close();
        }

        public ArmyEvent getTemplateEvent()
        {
            return this.templateEvent;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            templateEvent = null;
            Close();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEventName.SelectedItem.ToString() == "Боевая подготовка")
            {
                comboBoxHours.Show();
                labelHour.Show();

            }
            else
            {
                comboBoxHours.Hide();
                labelHour.Hide();
            }
        }

        private void AddEventTemplateForm_Load(object sender, EventArgs e)
        {
            comboBoxEventName.Items.AddRange(events);

            string[] daysOfWeek = new string[] 
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            checkedDaysOfWeek.Items.Clear();
            checkedDaysOfWeek.Items.AddRange(daysOfWeek);
        }
    }
}
