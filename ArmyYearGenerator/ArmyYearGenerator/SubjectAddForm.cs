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
    public partial class SubjectAddForm : Form
    {
        TreeNode subject;
        TreeNode subjectEvent;
        Color color;
        private static string textSelectButton = "Пометить как контрольную тему";
        private static string textDeselectButton = "Снять выделение";

        private static string templateTextForTheme = "Тема ";
        private static string templateTextForLesson = "Занятие ";
        private static string templateTextForDuration = "Длительность: ";

        public SubjectAddForm()
        {
            InitializeComponent();
        }

        private void numericUpDownCountThemes_ValueChanged(object sender, EventArgs e)
        {
            treeViewThemes.Nodes.Clear();

            int countThemes = Convert.ToInt32(numericUpDownCountThemes.Value);
            for (int i = 1; i <= countThemes; i++)
            {
                TreeNode addedNode = treeViewThemes.Nodes.Add("Тема " + i);
                addedNode.ToolTipText = "Номер и название темы по предмету";
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //MessageBox.Show("Kuda tikaesh pidar");
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            treeViewThemes.LabelEdit = true;

            TreeNode selectedNode = treeViewThemes.SelectedNode;

            // Тема
            if (selectedNode.Level == 0)
                selectedNode.Text = selectedNode.Text.Remove(0, templateTextForTheme.Length + 1);

            // Занятие
            else if (selectedNode.Level == 1)
                selectedNode.Text = selectedNode.Text.Remove(0, templateTextForLesson.Length + 1);

            // Длительность
            else if (selectedNode.Level == 2)
                selectedNode.Text = selectedNode.Text.Remove(0, templateTextForDuration.Length);

            selectedNode.BeginEdit();
        }

        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            e.CancelEdit = true;

            int themeNumber = (selectedNode.Index + 1);
            if (e.Label != null)
            {
                if (selectedNode.Level == 0)
                    selectedNode.Text = "Тема " + themeNumber + " " + e.Label;
                else if (selectedNode.Level == 1)
                    selectedNode.Text = "Занятие " + themeNumber + " " + e.Label;
                else if (selectedNode.Level == 2)
                    selectedNode.Text = templateTextForDuration + e.Label;
            }
            else
            {
                if (selectedNode.Level == 0)
                    selectedNode.Text = "Тема " + themeNumber  + selectedNode.Text;
                else if (selectedNode.Level == 1)
                    selectedNode.Text = "Занятие " + themeNumber  + selectedNode.Text;
                else if (selectedNode.Level == 2)
                    selectedNode.Text = templateTextForDuration + selectedNode.Text;
            }

            treeViewThemes.LabelEdit = false;
            treeViewThemes.Update();
        }

        private void buttonAddLesson_Click(object sender, EventArgs e)
        {
            if (treeViewThemes.SelectedNode != null)
            {
                TreeNode theme = treeViewThemes.SelectedNode;
                TreeNode lesson = theme.Nodes.Add("Занятие " + (theme.Nodes.Count + 1));
                lesson.ToolTipText = "Номер и название занятия";

                TreeNode hours = lesson.Nodes.Add(templateTextForDuration);
                hours.ToolTipText = "Длительность занятия в часах";

                theme.ExpandAll();
            }
        }

        private void buttonDelet_Click(object sender, EventArgs e)
        {
            TreeNode selectedTheme = treeViewThemes.SelectedNode;
            selectedTheme.Remove();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            /// @Azbus
            /// Make method for checking lesson durations

            if (textBoxSubjectName.Text == "")
            {
                MessageBox.Show("Введите название предмета!");
                return;
            }
            subject = new TreeNode(textBoxSubjectName.Text);
            TreeNode[] themes = new TreeNode[treeViewThemes.Nodes.Count];

            for (int i = 0; i < treeViewThemes.Nodes.Count; i++)
            {
                themes[i] = (TreeNode) treeViewThemes.Nodes[i].Clone();
            }
            
            subject.Nodes.AddRange(themes);

            treeViewThemes.Nodes.Clear();
            if (checkBoxCombat.Checked)
            {

                subjectEvent = new TreeNode("Боевая подготовка");
                subjectEvent.Nodes.Add(subject);
                subjectEvent.Name = "Боевая подготовка";

                treeViewThemes.Nodes.Add(subjectEvent);
            }
            else
            {
                subject.Name = subject.Text;
                treeViewThemes.Nodes.Add(subject);
            }

            

            Close();
        }

        public TreeView getSubjectTree()
        {
            return treeViewThemes;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            treeViewThemes.Nodes.Clear();
        }

        private void SubjectAddForm_Load(object sender, EventArgs e)
        {
            color = Color.PaleGreen;
            pictureHelpBox.BackColor = color;
        }

        private void buttonControlLabel_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewThemes.SelectedNode;   
            string fontFamilyName = FontFamily.GenericSansSerif.Name;

            if (selectedNode.Level == 0)
            {


                if (selectedNode.BackColor == color)
                {
                    var font = new Font(fontFamilyName, emSize: 8, style: FontStyle.Regular);
                    selectedNode.NodeFont = font;
                    selectedNode.BackColor = Color.FromArgb(0, 0, 0, 0);
                }
                else
                {
                    var font = new Font(fontFamilyName, emSize: 8, style: FontStyle.Underline);
                    selectedNode.NodeFont = font;
                    selectedNode.BackColor = color;
                }

                if (buttonControlLabel.Text == textDeselectButton)
                    buttonControlLabel.Text = textSelectButton;
                else if (buttonControlLabel.Text == textSelectButton)
                    buttonControlLabel.Text = textDeselectButton;
            }
            else
            {
                MessageBox.Show("Сделать метку можно только для ТЕМЫ!");
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            if (selectedNode.Level == 0)
            {
                buttonControlLabel.Enabled = true;
                if (selectedNode.BackColor == color)
                    buttonControlLabel.Text = textDeselectButton;
                else
                    buttonControlLabel.Text = textSelectButton;

                buttonAddLesson.Enabled = true;
            }
            else
            {
                buttonControlLabel.Enabled = false;
                buttonAddLesson.Enabled = false;
            }
        }

        private void buttonAddTheme_Click(object sender, EventArgs e)
        {
            int themesCount = treeViewThemes.Nodes.Count + 1;
            bool isEmpty = true;
            TreeNode addedNode;

            for (int i = 1; i <= themesCount; i++)
            {
                isEmpty = true;
                addedNode = new TreeNode("Тема " + i);

                foreach (TreeNode node in treeViewThemes.Nodes)
                {
                    if (addedNode.Text == node.Text.Substring(0,6))
                        isEmpty = false;
                }

                if (isEmpty)
                {
                    addedNode.ToolTipText = "Номер и название темы по предмету";
                    treeViewThemes.Nodes.Add(addedNode);
                }

            }

                treeViewThemes.Sort();

        }
    }
}
