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
    public partial class AddSpecialDayForm : Form
    {
        TreeView subjectTree;
        List<ArmyEvent> events = new List<ArmyEvent>();

        DateTime startTime;
        DateTime endTime;
        public AddSpecialDayForm()
        {
            InitializeComponent();
        }

        public AddSpecialDayForm(TreeView tree)
        {
            InitializeComponent();

            subjectTree = tree;
        }

        private void buttonAddTemplate_Click(object sender, EventArgs e)
        {
            string[] row = new string[3];
            string eventName = comboBoxEvents.SelectedItem.ToString();
            string eventTheme = textBox1.Text;

            startTime = Convert.ToDateTime(maskedTextBoxStartTime.Text);
            endTime = Convert.ToDateTime(maskedTextBoxEndTime.Text);

            row[0] = maskedTextBoxStartTime.Text;
            row[1] = maskedTextBoxEndTime.Text;

            if (textBox1.Visible)
                row[2] = eventName + " " + eventTheme;
            else
                row[2] = eventName + " " + comboBoxControlThemes.SelectedItem.ToString();

            dataGridView1.Rows.Add(row);
        }

        private void AddSpecialDayForm_Load(object sender, EventArgs e)
        {
            foreach (TreeNode eventNode in subjectTree.Nodes)
            {
                if (eventNode.Text == "Боевая подготовка")
                {
                    foreach (TreeNode subjectNode in eventNode.Nodes)
                    {
                        comboBoxEvents.Items.Add(subjectNode.Text);
                    }
                }
                else
                {
                    comboBoxEvents.Items.Add(eventNode.Text);
                }
            }
        }

        public List<ArmyEvent> getSpecialDay()
        {
            return events;
        }



        private void comboBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxControlThemes.Items.Clear();

            if (comboBoxEvents.SelectedItem.ToString() != "Инструктаж" && comboBoxEvents.SelectedItem.ToString() != "Огневая подготовка")
            {
                textBox1.Text = "Контрольные занятия";

                labelControlTheme.Hide();
                comboBoxControlThemes.Hide();

                textBox1.Show();
                label2.Show();
            }
            else if (comboBoxEvents.SelectedItem.ToString() == "Огневая подготовка")
            {
                foreach (TreeNode eventNode in subjectTree.Nodes)
                {
                    if (eventNode.Text == "Боевая подготовка")
                    {
                        foreach (TreeNode subjectNode in eventNode.Nodes)
                        {
                            if (subjectNode.Text == "Огневая подготовка")
                            {
                                labelControlTheme.Show();
                                comboBoxControlThemes.Show();

                                textBox1.Hide();
                                label2.Hide();

                                foreach (TreeNode themeNode in subjectNode.Nodes)
                                {
                                    if (themeNode.BackColor == Color.PaleGreen)
                                        comboBoxControlThemes.Items.Add(themeNode.Text);
                                }
                            }

                        }
                    }
                }

                textBox1.Text = "";
            }
            else
            {
                textBox1.Text = "";

                labelControlTheme.Hide();
                comboBoxControlThemes.Hide();

                textBox1.Show();
                label2.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string name = (string) row.Cells[2].Value;
                string[] days = new string[] {"Monday"};
                DateTime start = Convert.ToDateTime(row.Cells[0].Value);
                DateTime end = Convert.ToDateTime(row.Cells[1].Value);

                if (name != null)
                {
                    events.Add(new ArmyEvent(name, days, start, end));
                }
            }

            this.Close();
        }
    }
}
