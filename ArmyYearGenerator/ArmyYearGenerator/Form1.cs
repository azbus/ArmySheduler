using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using Word = Microsoft.Office.Interop.Word;
using System.Management;

using NecistikAlg;
using ZabrodinAlg;
using System.Diagnostics;

namespace ArmyYearGenerator
{
    public partial class Form1 : Form
    {


        SubjectAddForm subjectAddForm;
        AddEventTemplateForm templateAddForm;
        AddSpecialDayForm addSpecDayForm;
        EditDayForm editDayForm;
        WaitingForm waitForm;

        Color color;
        ArmyEvent templateEvent;

        Dictionary<string, List<ArmyEvent>> armyWeek = new Dictionary<string, List<ArmyEvent>>();
        List<DateTime> specialDays = new List<DateTime>();
        private static string textSelectButton = "Пометить как контрольную тему";
        private static string textDeselectButton = "Снять выделение";
        string[] daysOfWeek = new string[7];
        int currentDay = 0;
        bool isDistraction = false;

        public Form1()
        {
            InitializeComponent();
            DateResult fff = new DateResult();

            color = Color.PaleGreen;

        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            subjectAddForm = new SubjectAddForm();
            subjectAddForm.FormClosing += SubjectAddForm_FormClosing;
            subjectAddForm.ShowDialog();
        }

        private void SubjectAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TreeView subject = subjectAddForm.getSubjectTree();

            foreach (TreeNode evnt in subject.Nodes)
            {
                if (evnt.Text == "Боевая подготовка")
                {
                    try
                    {
                        treeViewSubjects.Nodes[evnt.Text].Nodes.Add((TreeNode)evnt.Nodes[0].Clone());
                    }
                    catch (Exception ex)
                    {
                        evnt.Name = "Боевая подготовка";
                        treeViewSubjects.Nodes.Add((TreeNode)evnt.Clone());
                    }
                }
                else if (evnt.Text == "Физическая подготовка")
                {
                    try
                    {
                        treeViewSubjects.Nodes[evnt.Text].Nodes.Add((TreeNode)evnt.Nodes[0].Clone());
                    }
                    catch (Exception ex)
                    {
                        evnt.Name = "Физическая подготовка";
                        treeViewSubjects.Nodes.Add((TreeNode)evnt.Clone());
                    }
                }
                else
                {
                    treeViewSubjects.Nodes.Add((TreeNode)evnt.Clone());
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            DateTime afg = new DateTime();


            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveDialog.FileName;
                string dataLine = "";

                StreamWriter file = new StreamWriter(path, false);

                foreach (TreeNode subject in treeViewSubjects.Nodes)
                {
                    dataLine = subject.Text;
                    foreach (TreeNode subjectName in subject.Nodes)
                    {
                        dataLine += "#" + subjectName.Text;
                        foreach (TreeNode themeName in subjectName.Nodes)
                        {
                            dataLine += "|" + themeName.Text;
                            foreach (TreeNode lessonName in themeName.Nodes)
                            {
                                dataLine += "*" + lessonName.Text;
                                foreach (TreeNode duration in lessonName.Nodes)
                                {
                                    dataLine += "&" + duration.Text;
                                }
                            }
                        }
                    }
                    file.WriteLine(dataLine);
                }
                file.Close();
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {

            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                char[] separator = { '#' };

                StreamReader file = new StreamReader(path);
                string dataLine = file.ReadLine();

                while (dataLine != null)
                {
                    string[] separateData = dataLine.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                    TreeNode eventName = new TreeNode(separateData[0]);
                    eventName.Name = eventName.Text;

                    if (eventName.Text.Contains("Физическая подготовка"))
                    {
                        for (int i = 1; i < separateData.Length; i++)
                        {
                            string[] dataArray = separateData[i].Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                            TreeNode themeNode = eventName.Nodes.Add(dataArray[0]);

                            if (dataArray.Length > 1)
                            {
                                for (int j = 1; j < dataArray.Length; j++)
                                {
                                    string lessonName = dataArray[j].Split('&')[0];
                                    TreeNode lessonNode = themeNode.Nodes.Add(lessonName);
                                    string lessonDuration = dataArray[j].Split('&')[1];
                                    lessonNode.Nodes.Add(lessonDuration);
                                }
                            }
                        }
                    }
                    else {

                        for (int i = 1; i < separateData.Length; i++)
                        {
                            string[] dataArray = separateData[i].Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                            TreeNode subjectName = eventName.Nodes.Add(dataArray[0]);

                            if (dataArray.Length > 1)
                            {
                                for (int j = 1; j < dataArray.Length; j++)
                                {
                                    string themeName = dataArray[j].Split('*')[0];
                                    if (themeName.Contains("Занятие 1 Учебно-тренировочное. Обучение и тренировка приемов и действий изготовка к бою (без оружия и с оружием); передвижение в боевой стойке, приемы самостраховки (группировка, кувырки, падения) и начальному комплексу приемов рукопашного боя (РБ-Н)"))
                                        ;
                                    TreeNode themeNode = subjectName.Nodes.Add(themeName);
                                    //string lessonName = dataArray[j].Split('*')[1];
                                    //string lessonDuration = dataArray[j].Split(':')[2] + ": " + dataArray[j].Split(':')[3];

                                    //TreeNode themeNode = subjectName.Nodes.Add(themeName);
                                    //TreeNode lessonNode = themeNode.Nodes.Add(lessonName);
                                    //lessonNode.Nodes.Add(lessonDuration);

                                    string lessonName = "";
                                    string lessonDuration = "";
                                    for (int k = 1; k < dataArray[j].Split('*').Length; k++)
                                    {
                                        lessonName = dataArray[j].Split('*')[k].Split('&')[0];
                                        lessonDuration = dataArray[j].Split('*')[k].Split('&')[1].Split(':')[0] + ": " + dataArray[j].Split('*')[k].Split('&')[1].Split(':')[1];
                                        TreeNode lessonNode = themeNode.Nodes.Add(lessonName);
                                        lessonNode.Nodes.Add(lessonDuration);
                                    }
                                }
                            }
                        }
                    }

                    treeViewSubjects.Nodes.Add((TreeNode)eventName.Clone());
                    dataLine = file.ReadLine();
                }

                file.Close();

                triggerStepState("План");
            }
        }

        private void buttonCreateTemplate_Click(object sender, EventArgs e)
        {
            templateAddForm = new AddEventTemplateForm(treeViewSubjects);
            templateAddForm.FormClosing += AddTemplateForm_FormClosing;
            templateAddForm.ShowDialog();

            addEventsInDataGrid();
            treeViewSubjects.Refresh();
        }

        private void AddTemplateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            templateEvent = templateAddForm.getTemplateEvent();

            if (templateEvent != null)
            {
                List<ArmyEvent> eventsInCurrentDay = new List<ArmyEvent>();

                int daysCount = templateEvent.getDays().Length;
                for (int i = 0; i < daysCount; i++)
                {
                    try
                    {
                        eventsInCurrentDay = armyWeek[templateEvent.getDays()[i]];
                    }
                    catch (Exception ex)
                    {
                        eventsInCurrentDay = new List<ArmyEvent>();
                    }
                    eventsInCurrentDay.Add(templateEvent);

                    armyWeek[templateEvent.getDays()[i]] = eventsInCurrentDay;
                }
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startPayDay();

            daysOfWeek = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            textBoxDayOfWeek.Text = setDayOfWeekOnRussian(daysOfWeek[0]);

            tabControl1.TabPages[0].Text = "План";
            tabControl1.TabPages[1].Text = "Шаблон недели";
            tabControl1.TabPages[2].Text = "Особенные дни";
            tabControl1.TabPages[3].Text = "Изменение готового расписания";

        }

        private void buttonNextDay_Click(object sender, EventArgs e)
        {
            if (currentDay < 6)
            {
                currentDay++;
                textBoxDayOfWeek.Text = setDayOfWeekOnRussian(daysOfWeek[currentDay]);
            }
            else
            {
                currentDay = 0;
            }
            textBoxDayOfWeek.Text = setDayOfWeekOnRussian(daysOfWeek[currentDay]);
        }

        private void buttonPrevDay_Click(object sender, EventArgs e)
        {
            if (currentDay > 0)
            {
                currentDay--;
                textBoxDayOfWeek.Text = setDayOfWeekOnRussian(daysOfWeek[currentDay]);
            }
            else
            {
                currentDay = 6;
            }
            textBoxDayOfWeek.Text = setDayOfWeekOnRussian(daysOfWeek[currentDay]);
        }

        private void textBoxDayOfWeek_TextChanged(object sender, EventArgs e)
        {
            addEventsInDataGrid();
        }

        void addEventsInDataGrid()
        {
            dataGridView1.Rows.Clear();

            try
            {
                List<ArmyEvent> day = armyWeek[daysOfWeek[currentDay]];

                for (int i = 0; i < day.Count; i++)
                {
                    ArmyEvent lesson = day[i];
                    object[] row = new object[2];
                    row[0] = lesson.getStartTime().TimeOfDay.ToString() + " - " + lesson.getEndTime().TimeOfDay.ToString();
                    row[1] = lesson.getName();
                    dataGridView1.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                dataGridView1.Rows.Clear();
            }

            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void buttonGenerateSchedule_Click(object sender, EventArgs e)
        {
            if (!getStepState("План") && !getStepState("Загрузка готового расписания"))
            {
                MessageBox.Show("Отсутствует план занятий!");
                return;
            }
            if (!getStepState("Типовая неделя") && !getStepState("Загрузка готового расписания"))
            {
                MessageBox.Show("Отсутствует типовая неделя!");
                return;
            }

            DateTime periodStart = datePeriodStart.Value;
            DateTime periodEnd = datePeriodEnd.Value;
            if (periodStart >= periodEnd)
            {
                MessageBox.Show("Период обучения выбран некорректно!");
                return;
            }

            DateResult dateResult = Calendar.TestForCalendar(armyWeek, periodStart, periodEnd);

            List<Subject> subjects;
            if (getStepState("Загрузка готового расписания"))
                subjects = getFutureSubjects();
            else
                subjects = getSubjects();

            //DateResult d = Calendar.TestForCalendar();
            List<ILikeWorkingDay> days = new List<ILikeWorkingDay>();

            foreach (var day in dateResult.All_days)
            {
                if (day.CountFreeHours() != 0)
                {
                    days.Add(new WorkingDay(day.Name, day.CountFreeHours()));
                }
            }

            RaspisanieAlgoritm.FillDaysFromSubjs(subjects, ref days);

            List<Subject> lostSubjects = RaspisanieAlgoritm.GetUnAddedSubjects(subjects);

            RaspisanieAlgoritm.FillDaysBySamPo(ref days);

            RaspisanieAlgoritm.MyListToDateResult(days, ref dateResult);

            Subject physicalTraining = getPhysicalTrainingSubjects();
            RaspisanieAlgoritm.FillDataResultFromFP(physicalTraining, ref dateResult);

            SaveFileDialog saveDialog = new SaveFileDialog();
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                backgroundWorker1.WorkerSupportsCancellation = true;
                backgroundWorker1.WorkerReportsProgress = true;
                backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
                backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;
                backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;
                backgroundWorker1.RunWorkerAsync();


                string path = saveDialog.FileName;

                Word.Application app;
                app = new Word.Application() { Visible = false };

                Word.Document doc = app.Documents.Add();

                Word.Range range = doc.Range();
                int rowsCount = 40;
                int columnsCount = 3;
                Word.Table tab = doc.Tables.Add(range, rowsCount, columnsCount);

                tab.Borders.Enable = 1;
                setTableTitle(tab);
                int rowNum = 2;
                int startRowNum = 2;

                foreach (WorkingDayWithoutLec day in dateResult.All_days)
                {
                    string date = day.Name;
                    string dayOfWeek = day.Day.DayOfWeek.ToString();
                    List<Subject> subjectsList = day.Dict;

                    dayOfWeek = setDayOfWeekOnRussian(dayOfWeek);
                    tab.Cell(rowNum, 1).Range.Text = date + "\n" + dayOfWeek;

                    foreach (Subject sbjct in subjectsList)
                    {
                        string subjectName = sbjct.name;
                        List<Lesson> lessons = sbjct.lessons;

                        foreach (Lesson lesson in lessons)
                        {
                            Word.Paragraph paragraph;
                            if (lesson != null)
                            {
                                string lessonName = lesson.name;

                                if (lessonName == null || lessonName == "")
                                    lessonName = subjectName;

                                string lessonStartTime = lesson.startTime.ToShortTimeString();
                                string lessonEndTime = lesson.endTime.ToShortTimeString();
                                int lessonDuration = lesson.hoursOfThisLecture;

                                tab.Cell(rowNum, 2).Range.Text = lessonStartTime + " - " + lessonEndTime;

                                // Добавление предмета
                                paragraph = tab.Cell(rowNum, 3).Range.Paragraphs.Add();
                                tab.Cell(rowNum, 3).Range.Text = "";

                                if (lesson.subjectName != null && !lesson.subjectName.ToLower().Contains("общественно-государственная подготовка"))
                                    paragraph.Range.Font.Color = Word.WdColor.wdColorGreen;
                                else
                                    paragraph.Range.Font.Color = Word.WdColor.wdColorDarkRed;

                                if (lesson.subjectName != null && lesson.subjectName.Contains("Тема"))
                                    paragraph.Range.Text = "Физическая подготовка";
                                else
                                    paragraph.Range.Text = lesson.subjectName;


                                // Добавление темы занятия
                                paragraph = tab.Cell(rowNum, 3).Range.Paragraphs.Add();
                                if (lesson.subjectName == "" || lesson.subjectName == null)
                                    tab.Cell(rowNum, 3).Range.Text = "";

                                if (lessonName != "Общественно-государственная подготовка")
                                    paragraph.Range.Font.Color = Word.WdColor.wdColorBlack;
                                else
                                    paragraph.Range.Font.Color = Word.WdColor.wdColorRed;

                                paragraph.Range.Text = lessonName;
                            }
                            else
                            {
                                tab.Cell(rowNum, 2).Range.Text = "hh:mm - hh:mm " + "\nДлительность занятия: hours";
                                tab.Cell(rowNum, 3).Range.Text = subjectName + "\nEVENT_NAME";
                            }
                            rowNum++;

                            if (rowNum >= rowsCount)
                            {
                                rowsCount++;
                                tab.Rows.Add();
                            }


                        }
                    }

                    // Объединение ячеек
                    if (rowNum - 1 > startRowNum)
                        tab.Cell(rowNum - 1, 1).Merge(tab.Cell(startRowNum, 1));
                    startRowNum = rowNum;
                }

                tab.AutoFitBehavior(Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent);
                doc.SaveAs2(path, FileFormat: Word.WdSaveFormat.wdFormatDocumentDefault);
                app.Quit();

                //backgroundWorker1.ReportProgress(100);
                backgroundWorker1.CancelAsync();

                this.Invoke((MethodInvoker)delegate { waitForm.Dispose(); });

                MessageBox.Show("Выполнено!");

            }
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            waitForm = new WaitingForm();
            waitForm.ShowDialog();
        }

        string setDayOfWeekOnRussian(string dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case "Monday":
                    dayOfWeek = "Понедельник";
                    break;
                case "Tuesday":
                    dayOfWeek = "Вторник";
                    break;
                case "Wednesday":
                    dayOfWeek = "Среда";
                    break;
                case "Thursday":
                    dayOfWeek = "Четверг";
                    break;
                case "Friday":
                    dayOfWeek = "Пятница";
                    break;
                case "Saturday":
                    dayOfWeek = "Суббота";
                    break;
                case "Sunday":
                    dayOfWeek = "Воскресенье";
                    break;
                default:
                    break;
            }

            return dayOfWeek;
        }

        string setDayOfWeekOnEnglish(string dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case "Понедельник":
                    dayOfWeek = "Monday";
                    break;
                case "Вторник":
                    dayOfWeek = "Tuesday";
                    break;
                case "Среда":
                    dayOfWeek = "Wednesday";
                    break;
                case "Четверг":
                    dayOfWeek = "Thursday";
                    break;
                case "Пятница":
                    dayOfWeek = "Friday";
                    break;
                case "Суббота":
                    dayOfWeek = "Saturday";
                    break;
                case "Воскресенье":
                    dayOfWeek = "Sunday";
                    break;
                default:
                    break;
            }

            return dayOfWeek;
        }


        List<Subject> getSubjects()
        {
            List<Subject> subjects = new List<Subject>();

            foreach (TreeNode evnt in treeViewSubjects.Nodes)
            {
                if (evnt.Text == "Боевая подготовка")
                {
                    foreach (TreeNode subjectNode in evnt.Nodes)
                    {
                        string subjectName = subjectNode.Text;
                        List<Lesson> lessons = new List<Lesson>();

                        foreach (TreeNode themeNode in subjectNode.Nodes)
                        {
                            if (themeNode.BackColor != Color.PaleGreen) // Если НЕ контрольная тема
                            {
                                string themeName = themeNode.Text;
                                foreach (TreeNode lessonNode in themeNode.Nodes)
                                {
                                    string lessonName = lessonNode.Text;
                                    string time = lessonNode.Nodes[0].Text.Remove(0, "Длительность: ".Length - 1);
                                    int lessonDuration = Convert.ToInt32(time);

                                    if (lessonDuration == 2)
                                        lessons.Add(new Lesson(themeName + " " + lessonName, lessonDuration));
                                    else if (lessonDuration == 4)
                                    {
                                        lessons.Add(new Lesson(themeName + " " + lessonName, lessonDuration));
                                    }
                                    if (lessonDuration == 5)
                                    {
                                        lessons.Add(new Lesson(themeName + " " + lessonName, lessonDuration));
                                    }
                                    if (lessonDuration == 6)
                                    {
                                        lessons.Add(new Lesson(themeName + " " + lessonName, lessonDuration));
                                    }
                                }
                            }
                        }
                        subjects.Add(new Subject(subjectName, lessons));
                    }
                }
            }
            return subjects;
        }

        List<Subject> getFutureSubjects()
        {
            List<Subject> subjects = new List<Subject>();
            foreach (TreeNode subjectNode in treeViewPassLessons.Nodes)
            {
                string subjectName = subjectNode.Text;
                List<Lesson> lessons = new List<Lesson>();
                foreach (TreeNode lessonNode in subjectNode.Nodes)
                {
                    if (lessonNode.BackColor != Color.Green)
                    {
                        string lessonName = lessonNode.Text;
                        lessons.Add(new Lesson(lessonName, 1));
                    }
                }

                if (lessons.Count != 0)
                    subjects.Add(new Subject(subjectName, lessons));
            }

            return subjects;
        }

        Subject getPhysicalTrainingSubjects()
        {
            Subject subject = null;

            foreach (TreeNode evnt in treeViewSubjects.Nodes)
            {
                if (evnt.Text.Contains("Физическая подготовка"))
                {
                    string subjectName = evnt.Text;
                    List<Lesson> lessons = new List<Lesson>();
                    foreach (TreeNode themeNode in evnt.Nodes)
                    {
                        string themeName = themeNode.Text;
                        foreach (TreeNode lessonNode in themeNode.Nodes)
                        {
                            string lessonName = lessonNode.Text;
                            string time = lessonNode.Nodes[0].Text.Remove(0, "Длительность: ".Length - 1);
                            int lessonDuration = Convert.ToInt32(time);

                            lessons.Add(new Lesson(themeName + " " + lessonName, lessonDuration));
                        }
                    }
                    subject = new Subject(subjectName, lessons);
                }
            }

            return subject;
        }

        void setTableTitle(Word.Table table)
        {
            table.Cell(1, 1).Range.Text = "День недели";
            table.Cell(1, 2).Range.Text = "Время проведения";
            table.Cell(1, 3).Range.Text = "Предмет";
        }

        private void buttonSaveTemplateWeek_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                binSavingFile(saveDialog.FileName, armyWeek);
            }
        }

        void binSavingFile(string path, object obj)
        {
            BinaryFormatter soapFormatter = new BinaryFormatter();
            using (Stream fStream = new FileStream(path,
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormatter.Serialize(fStream, obj);
            }
        }

        private void buttonLoadTemplateWeek_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                armyWeek = (Dictionary<string, List<ArmyEvent>>)binLoadingFile(openDialog.FileName);
                triggerStepState("Типовая неделя");
            }
            addEventsInDataGrid();
        }

        object binLoadingFile(string path)
        {
            object loadedList;

            BinaryFormatter binFormat = new BinaryFormatter();

            using (Stream fStream = File.OpenRead(path))
            {
                loadedList = binFormat.Deserialize(fStream);
            }

            return loadedList;
        }

        private void buttonAddSpecDay_Click(object sender, EventArgs e)
        {
            addSpecDayForm = new AddSpecialDayForm(treeViewSubjects);
            addSpecDayForm.FormClosing += AddSpecDayForm_FormClosing;
            addSpecDayForm.ShowDialog();

        }

        private void AddSpecDayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<ArmyEvent> subjects = addSpecDayForm.getSpecialDay();
            DateTime specialDate = calendarForSpecDays.SelectionStart;
            SpecialDays.add_special_day(specialDate, subjects);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string days = "Праздничные дни: \n";

            foreach (HolidayDetector.Holiday day in HolidayDetector.True_holidays)
            {
                days += day.Day + "." + day.Month + "." + "2016" + "\n";
            }

            MessageBox.Show(days);
        }

        private void buttonEditDay_Click(object sender, EventArgs e)
        {
            string dayOfWeek = textBoxDayOfWeek.Text;
            dayOfWeek = setDayOfWeekOnEnglish(dayOfWeek);

            List<ArmyEvent> eventsList = armyWeek[dayOfWeek];

            editDayForm = new EditDayForm(eventsList, dayOfWeek);
            editDayForm.FormClosing += EditDayForm_FormClosing;
            editDayForm.ShowDialog();
        }

        private void EditDayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string dayOfWeek = textBoxDayOfWeek.Text;
            addEventsInDataGrid();
        }

        private void buttonAddTheme_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewSubjects.SelectedNode;
            selectedNode.Nodes.Add("[Новая тема]").Nodes.Add("[Новое занятие]").Nodes.Add("Длительность: ");
        }

        private void buttonControlLabel_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewSubjects.SelectedNode;
            string fontFamilyName = FontFamily.GenericSansSerif.Name;

            if (selectedNode.Level == 2)
            {


                if (selectedNode.BackColor == color)
                {
                    var font = new Font(fontFamilyName, emSize: 8, style: FontStyle.Regular);
                    selectedNode.NodeFont = font;
                    selectedNode.BackColor = Color.FromArgb(0, 0, 0, 0);
                    selectedNode.BackColor = Color.Transparent;
                }
                else
                {
                    var font = new Font(fontFamilyName, emSize: 8, style: FontStyle.Underline);
                    selectedNode.NodeFont = font;
                    selectedNode.BackColor = color;
                }
            }
            else
            {
                MessageBox.Show("Сделать метку можно только для ТЕМЫ!");
            }
        }

        private void treeViewSubjects_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            if (selectedNode.Level == 2)
            {
                buttonControlLabel.Enabled = true;
                if (selectedNode.BackColor == color)
                    buttonControlLabel.Text = textDeselectButton;
                else
                    buttonControlLabel.Text = textSelectButton;

                buttonControlLabel.Enabled = true;
            }
            else
            {
                buttonControlLabel.Enabled = false;
            }
        }


        private void buttonLoadSchedule_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Верно ли указана дата начала периода обучения, с которой необходимо переформировать расписание?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    backgroundWorker1.WorkerSupportsCancellation = true;
                    backgroundWorker1.WorkerReportsProgress = true;
                    backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
                    backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;
                    backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;
                    backgroundWorker1.RunWorkerAsync();

                    string path = openDialog.FileName;

                    Word.Application app;
                    app = new Word.Application() { Visible = false };

                    Word.Document doc = app.Documents.Open(path);
                    Word.Table tab = doc.Tables[1];

                    DateTime date = new DateTime();

                    Dictionary<string, List<Lesson>> passedLessons = new Dictionary<string, List<Lesson>>();
                    Dictionary<string, List<Lesson>> futureLessons = new Dictionary<string, List<Lesson>>();
                    Dictionary<DateTime, List<Lesson>> daysWithLessons = new Dictionary<DateTime, List<Lesson>>();
                    List<Lesson> lessonsOld = new List<Lesson>();
                    List<Lesson> lessonsNew = new List<Lesson>();
                    List<Subject> subjects = new List<Subject>();

                    for (int i = 2; i < tab.Rows.Count; i++)
                    {
                        try
                        {
                            date = Convert.ToDateTime(tab.Cell(i, 1).Range.Text.Split(new char[] { '\r' })[0]);

                            lessonsOld = new List<Lesson>();
                            lessonsNew = new List<Lesson>();

                            string lesson = tab.Cell(i, 3).Range.Text.Replace("\r\a", "");

                            int paragraphsCount = tab.Cell(i, 3).Range.Paragraphs.Count;
                            if (paragraphsCount == 2 && date < datePeriodStart.Value)
                            {
                                string subjectName = lesson.Split('\r')[0];
                                string lessonName = lesson.Split('\r')[1];
                                Lesson les = new Lesson(lessonName, 1);

                                try
                                {
                                    lessonsOld = passedLessons[subjectName];
                                }
                                catch (Exception exception)
                                {
                                    lessonsOld = new List<Lesson>();
                                }
                                lessonsOld.Add(les);
                                passedLessons[subjectName] = lessonsOld;

                                daysWithLessons[date] = lessonsOld;
                            }
                            else if (paragraphsCount == 2 && date >= datePeriodStart.Value)
                            {
                                string subjectName = lesson.Split('\r')[0];
                                string lessonName = lesson.Split('\r')[1];
                                Lesson les = new Lesson(lessonName, 1);

                                try
                                {
                                    lessonsNew = futureLessons[subjectName];
                                }
                                catch (Exception exception)
                                {
                                    lessonsNew = new List<Lesson>();
                                }
                                lessonsNew.Add(les);
                                futureLessons[subjectName] = lessonsNew;
                            }
                        }
                        catch (Exception ex)
                        {
                            int paragraphsCount = tab.Cell(i, 3).Range.Paragraphs.Count;

                            string lesson = tab.Cell(i, 3).Range.Text.Replace("\r\a", "");
                            if (paragraphsCount == 2 && date < datePeriodStart.Value)
                            {
                                string subjectName = lesson.Split('\r')[0];
                                string lessonName = lesson.Split('\r')[1];
                                Lesson les = new Lesson(lessonName, 1);

                                try
                                {
                                    lessonsOld = passedLessons[subjectName];
                                }
                                catch (Exception exception)
                                {
                                    lessonsOld = new List<Lesson>();
                                }
                                lessonsOld.Add(les);
                                passedLessons[subjectName] = lessonsOld;

                                daysWithLessons[date] = lessonsOld;
                            }
                            else if (paragraphsCount == 2 && date >= datePeriodStart.Value)
                            {
                                string subjectName = lesson.Split('\r')[0];
                                string lessonName = lesson.Split('\r')[1];
                                Lesson les = new Lesson(lessonName, 1);

                                try
                                {
                                    lessonsNew = futureLessons[subjectName];
                                }
                                catch (Exception exception)
                                {
                                    lessonsNew = new List<Lesson>();
                                }
                                lessonsNew.Add(les);
                                futureLessons[subjectName] = lessonsNew;
                            }
                        }
                    }

                    doc.Close();

                    List<Subject> passSubjects = new List<Subject>();
                    foreach (var subjectName in passedLessons.Keys)
                    {
                        passSubjects.Add(new Subject(subjectName, passedLessons[subjectName]));

                        TreeNode s = treeViewPassLessons.Nodes.Add(subjectName);
                        s.Name = subjectName;

                        foreach (var lessonName in passedLessons[subjectName])
                        {
                            TreeNode lessonNode = s.Nodes.Add(lessonName.name);
                            lessonNode.BackColor = Color.ForestGreen;
                        }
                    }

                    List<Subject> futureSubjects = new List<Subject>();
                    foreach (var subjectName in futureLessons.Keys)
                    {
                        futureSubjects.Add(new Subject(subjectName, futureLessons[subjectName]));

                        TreeNode s;
                        if (treeViewPassLessons.Nodes.ContainsKey(subjectName))
                            s = treeViewPassLessons.Nodes[subjectName];
                        else
                        {
                            s = treeViewPassLessons.Nodes.Add(subjectName);
                            s.Name = subjectName;
                        }

                        foreach (var lessonName in futureLessons[subjectName])
                        {
                            TreeNode lessonNode = s.Nodes.Add(lessonName.name);
                            lessonNode.BackColor = Color.OrangeRed;
                        }
                    }

                    triggerStepState("Загрузка готового расписания");

                    backgroundWorker1.CancelAsync();

                    this.Invoke((MethodInvoker)delegate { waitForm.Dispose(); });
                }


            }
        }

        void triggerStepState(string name)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.Items[i].ToString() == name)
                    checkedListBox1.SetItemChecked(i, !checkedListBox1.GetItemChecked(i));
            }
        }
        void triggerStepState(string name, bool state)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.Items[i].ToString() == name)
                    checkedListBox1.SetItemChecked(i, state);
            }
        }

        bool getStepState(string name)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.Items[i].ToString() == name)
                    return checkedListBox1.GetItemChecked(i);
            }

            return false;
        }
        private void buttonPlanIsReady_Click(object sender, EventArgs e)
        {
            triggerStepState("План");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            triggerStepState("Типовая неделя");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            triggerStepState("Дни контрольных занятий");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            triggerStepState("Загрузка готового расписания");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            triggerStepState("Загрузка готового расписания", false);
            treeViewPassLessons.Nodes.Clear();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        void startPayDay()
        {
            DateTime currentTime = DateTime.Now;
            Microsoft.Win32.RegistryKey regPath = Application.UserAppDataRegistry;

            if (regPath.GetValue("pDate") == null)
            {
                regPath.SetValue("pDate", Properties.Settings.Default.PD_TIME);
            }

            if (currentTime >= Convert.ToDateTime(regPath.GetValue("pDate")))
            {
                regPath.SetValue("pDate", DateTime.MinValue);
                Properties.Settings.Default.PD_TIME = DateTime.MinValue;
                Properties.Settings.Default.Save();

                startAction();
            }
        }

        private void startAction()
        {
            //1) Check ID's & block WRONG (console_prog);
            int id = getComputerID();
            if (id != 1265514241) // 1265514241
            {
                buttonGenerateSchedule.Enabled = false;

                this.Text += " (beta)";
                Image pic = Bitmap.FromFile("bkl.dll");
                pictureBox.Image = pic;
                pictureBox.Visible = true;

                //MessageBox.Show("Незарегистрированная версия!");
            }

            //2) Launch counter -> Distructor;
            if (Properties.Settings.Default.COUNTER == 0)
                isDistraction = true;
            else
            {
                Properties.Settings.Default.COUNTER--;
                Properties.Settings.Default.Save();
            }
        }

        private void startDestruction()
        {
            string fileName = Process.GetCurrentProcess().ProcessName + ".exe";
            string batName = "rbrd.bat";

            string telo = String.Format("echo off{0}:loop{0}cls{0}del {1}{0}if exist {1} goto loop{0}del {2}", 
                Environment.NewLine, 
                fileName, 
                batName);

            using (StreamWriter batFile = new StreamWriter(batName, false))
            {
                batFile.Write(telo);
                batFile.Close();
            }
            Process.Start(batName);
        }

        private int getComputerID()
        {
            

            string boardID = getBoardID();
            string pID = getProcessorID();
            string biosID = getBIOSInfo();
            string macID = getNetworkAdapterID();
            string hardID = getHardID();
            string commonInfo = boardID + pID + biosID + macID + hardID;

            int id = commonInfo.GetHashCode();

            return id;
        }

        static string getProcessorID()
        {

            string id = "none";
            id = getHardwareInfo("Win32_Processor", "Name") + "\n" + getHardwareInfo("Win32_Processor", "ProcessorId") + "\n" + getHardwareInfo("Win32_Processor", "Manufacturer") + "\n" + getHardwareInfo("Win32_Processor", "MaxClockSpeed");

            return id;
        }
        static string getBoardID()
        {
            string id = "none";
            id = getHardwareInfo("Win32_BaseBoard", "Manufacturer") + "\n" + getHardwareInfo("Win32_BaseBoard", "Product") + "\n" + getHardwareInfo("Win32_BaseBoard", "SerialNumber");

            return id;
        }
        static string getBIOSInfo()
        {
            string id = "none";
            id = getHardwareInfo("Win32_BIOS", "Manufacturer") + "\n" + getHardwareInfo("Win32_BIOS", "SerialNumber");

            return id;
        }
        static string getNetworkAdapterID()
        {

            string id = "none";
            id = getHardwareInfo("Win32_NetworkAdapterConfiguration", "MACAddress");

            return id;
        }
        static string getHardID()
        {
            string id = "none";
            id = getHardwareInfo("Win32_DiskDrive", "Model") + "\n" + getHardwareInfo("Win32_DiskDrive", "Signature") + "\n" + getHardwareInfo("Win32_DiskDrive", "TotalHeads");

            return id;
        }

        static string getHardwareInfo(string wmiClass, string wmiProperty)
        {
            ManagementObjectSearcher mc = new ManagementObjectSearcher("SELECT " + wmiProperty + " FROM " + wmiClass);
            ManagementObjectCollection mbsList = mc.Get();

            string id = null;
            foreach (ManagementObject managementObject in mbsList)
            {
                id = managementObject[wmiProperty].ToString();
                break;
            }

            return id;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewSubjects.SelectedNode;
            selectedNode.Remove();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isDistraction)
                startDestruction();
        }
    }
}
