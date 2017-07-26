namespace ArmyYearGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeViewSubjects = new System.Windows.Forms.TreeView();
            this.buttonAddSubject = new System.Windows.Forms.Button();
            this.buttonGenerateSchedule = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.datePeriodStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateTemplate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxDayOfWeek = new System.Windows.Forms.TextBox();
            this.buttonPrevDay = new System.Windows.Forms.Button();
            this.buttonNextDay = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonPlanIsReady = new System.Windows.Forms.Button();
            this.buttonAddTheme = new System.Windows.Forms.Button();
            this.buttonControlLabel = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonEditDay = new System.Windows.Forms.Button();
            this.buttonSaveTemplateWeek = new System.Windows.Forms.Button();
            this.buttonLoadTemplateWeek = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAddSpecDay = new System.Windows.Forms.Button();
            this.calendarForSpecDays = new System.Windows.Forms.MonthCalendar();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonReset = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonLoadSchedule = new System.Windows.Forms.Button();
            this.treeViewPassLessons = new System.Windows.Forms.TreeView();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.datePeriodEnd = new System.Windows.Forms.DateTimePicker();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewSubjects
            // 
            this.treeViewSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewSubjects.LabelEdit = true;
            this.treeViewSubjects.Location = new System.Drawing.Point(7, 15);
            this.treeViewSubjects.Name = "treeViewSubjects";
            this.treeViewSubjects.Size = new System.Drawing.Size(646, 271);
            this.treeViewSubjects.TabIndex = 0;
            this.treeViewSubjects.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSubjects_AfterSelect);
            // 
            // buttonAddSubject
            // 
            this.buttonAddSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddSubject.Location = new System.Drawing.Point(7, 292);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(115, 23);
            this.buttonAddSubject.TabIndex = 1;
            this.buttonAddSubject.Text = "Добавить событие";
            this.buttonAddSubject.UseVisualStyleBackColor = true;
            this.buttonAddSubject.Click += new System.EventHandler(this.buttonAddSubject_Click);
            // 
            // buttonGenerateSchedule
            // 
            this.buttonGenerateSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerateSchedule.Location = new System.Drawing.Point(780, 348);
            this.buttonGenerateSchedule.Name = "buttonGenerateSchedule";
            this.buttonGenerateSchedule.Size = new System.Drawing.Size(138, 73);
            this.buttonGenerateSchedule.TabIndex = 2;
            this.buttonGenerateSchedule.Text = "Сгенерировать расписание";
            this.buttonGenerateSchedule.UseVisualStyleBackColor = true;
            this.buttonGenerateSchedule.Click += new System.EventHandler(this.buttonGenerateSchedule_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(420, 292);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(115, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить список";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoad.Location = new System.Drawing.Point(541, 292);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(115, 23);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Загрузить список";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // datePeriodStart
            // 
            this.datePeriodStart.Location = new System.Drawing.Point(753, 125);
            this.datePeriodStart.Name = "datePeriodStart";
            this.datePeriodStart.Size = new System.Drawing.Size(165, 20);
            this.datePeriodStart.TabIndex = 5;
            this.datePeriodStart.Value = new System.DateTime(2016, 12, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "События";
            // 
            // buttonCreateTemplate
            // 
            this.buttonCreateTemplate.Location = new System.Drawing.Point(6, 320);
            this.buttonCreateTemplate.Name = "buttonCreateTemplate";
            this.buttonCreateTemplate.Size = new System.Drawing.Size(109, 23);
            this.buttonCreateTemplate.TabIndex = 8;
            this.buttonCreateTemplate.Text = "Создать шаблон";
            this.buttonCreateTemplate.UseVisualStyleBackColor = true;
            this.buttonCreateTemplate.Click += new System.EventHandler(this.buttonCreateTemplate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(6, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(647, 275);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Время занятий";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "События";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 450;
            // 
            // textBoxDayOfWeek
            // 
            this.textBoxDayOfWeek.Location = new System.Drawing.Point(270, 11);
            this.textBoxDayOfWeek.Name = "textBoxDayOfWeek";
            this.textBoxDayOfWeek.ReadOnly = true;
            this.textBoxDayOfWeek.Size = new System.Drawing.Size(109, 20);
            this.textBoxDayOfWeek.TabIndex = 10;
            this.textBoxDayOfWeek.TextChanged += new System.EventHandler(this.textBoxDayOfWeek_TextChanged);
            // 
            // buttonPrevDay
            // 
            this.buttonPrevDay.Location = new System.Drawing.Point(218, 13);
            this.buttonPrevDay.Name = "buttonPrevDay";
            this.buttonPrevDay.Size = new System.Drawing.Size(46, 23);
            this.buttonPrevDay.TabIndex = 11;
            this.buttonPrevDay.Text = "<<";
            this.buttonPrevDay.UseVisualStyleBackColor = true;
            this.buttonPrevDay.Click += new System.EventHandler(this.buttonPrevDay_Click);
            // 
            // buttonNextDay
            // 
            this.buttonNextDay.Location = new System.Drawing.Point(385, 13);
            this.buttonNextDay.Name = "buttonNextDay";
            this.buttonNextDay.Size = new System.Drawing.Size(46, 23);
            this.buttonNextDay.TabIndex = 12;
            this.buttonNextDay.Text = ">>";
            this.buttonNextDay.UseVisualStyleBackColor = true;
            this.buttonNextDay.Click += new System.EventHandler(this.buttonNextDay_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(667, 409);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.buttonPlanIsReady);
            this.tabPage1.Controls.Add(this.buttonAddTheme);
            this.tabPage1.Controls.Add(this.buttonControlLabel);
            this.tabPage1.Controls.Add(this.treeViewSubjects);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonAddSubject);
            this.tabPage1.Controls.Add(this.buttonLoad);
            this.tabPage1.Controls.Add(this.buttonSave);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(659, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(-125, 32);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(906, 405);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 18;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(210, 308);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 28);
            this.button6.TabIndex = 20;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonPlanIsReady
            // 
            this.buttonPlanIsReady.Location = new System.Drawing.Point(541, 350);
            this.buttonPlanIsReady.Name = "buttonPlanIsReady";
            this.buttonPlanIsReady.Size = new System.Drawing.Size(115, 27);
            this.buttonPlanIsReady.TabIndex = 19;
            this.buttonPlanIsReady.Text = "Готовность";
            this.buttonPlanIsReady.UseVisualStyleBackColor = true;
            this.buttonPlanIsReady.Click += new System.EventHandler(this.buttonPlanIsReady_Click);
            // 
            // buttonAddTheme
            // 
            this.buttonAddTheme.Location = new System.Drawing.Point(210, 342);
            this.buttonAddTheme.Name = "buttonAddTheme";
            this.buttonAddTheme.Size = new System.Drawing.Size(111, 38);
            this.buttonAddTheme.TabIndex = 18;
            this.buttonAddTheme.Text = "Добавить тему";
            this.buttonAddTheme.UseVisualStyleBackColor = true;
            this.buttonAddTheme.Click += new System.EventHandler(this.buttonAddTheme_Click);
            // 
            // buttonControlLabel
            // 
            this.buttonControlLabel.Enabled = false;
            this.buttonControlLabel.Location = new System.Drawing.Point(6, 342);
            this.buttonControlLabel.Name = "buttonControlLabel";
            this.buttonControlLabel.Size = new System.Drawing.Size(198, 38);
            this.buttonControlLabel.TabIndex = 17;
            this.buttonControlLabel.Text = "Пометить как контрольную тему";
            this.buttonControlLabel.UseVisualStyleBackColor = true;
            this.buttonControlLabel.Click += new System.EventHandler(this.buttonControlLabel_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.buttonEditDay);
            this.tabPage2.Controls.Add(this.buttonSaveTemplateWeek);
            this.tabPage2.Controls.Add(this.buttonLoadTemplateWeek);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.buttonNextDay);
            this.tabPage2.Controls.Add(this.buttonCreateTemplate);
            this.tabPage2.Controls.Add(this.buttonPrevDay);
            this.tabPage2.Controls.Add(this.textBoxDayOfWeek);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(659, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(544, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 31);
            this.button3.TabIndex = 20;
            this.button3.Text = "Готовность";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonEditDay
            // 
            this.buttonEditDay.Location = new System.Drawing.Point(121, 320);
            this.buttonEditDay.Name = "buttonEditDay";
            this.buttonEditDay.Size = new System.Drawing.Size(109, 23);
            this.buttonEditDay.TabIndex = 15;
            this.buttonEditDay.Text = "Изменить день";
            this.buttonEditDay.UseVisualStyleBackColor = true;
            this.buttonEditDay.Click += new System.EventHandler(this.buttonEditDay_Click);
            // 
            // buttonSaveTemplateWeek
            // 
            this.buttonSaveTemplateWeek.Location = new System.Drawing.Point(429, 320);
            this.buttonSaveTemplateWeek.Name = "buttonSaveTemplateWeek";
            this.buttonSaveTemplateWeek.Size = new System.Drawing.Size(109, 23);
            this.buttonSaveTemplateWeek.TabIndex = 14;
            this.buttonSaveTemplateWeek.Text = "Сохранить";
            this.buttonSaveTemplateWeek.UseVisualStyleBackColor = true;
            this.buttonSaveTemplateWeek.Click += new System.EventHandler(this.buttonSaveTemplateWeek_Click);
            // 
            // buttonLoadTemplateWeek
            // 
            this.buttonLoadTemplateWeek.Location = new System.Drawing.Point(544, 320);
            this.buttonLoadTemplateWeek.Name = "buttonLoadTemplateWeek";
            this.buttonLoadTemplateWeek.Size = new System.Drawing.Size(109, 23);
            this.buttonLoadTemplateWeek.TabIndex = 13;
            this.buttonLoadTemplateWeek.Text = "Загрузить";
            this.buttonLoadTemplateWeek.UseVisualStyleBackColor = true;
            this.buttonLoadTemplateWeek.Click += new System.EventHandler(this.buttonLoadTemplateWeek_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.buttonAddSpecDay);
            this.tabPage3.Controls.Add(this.calendarForSpecDays);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(659, 383);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(538, 335);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 45);
            this.button4.TabIndex = 20;
            this.button4.Text = "Готовность";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "Добавить праздничный день";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Показать добавленные дни";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAddSpecDay
            // 
            this.buttonAddSpecDay.Location = new System.Drawing.Point(6, 314);
            this.buttonAddSpecDay.Name = "buttonAddSpecDay";
            this.buttonAddSpecDay.Size = new System.Drawing.Size(114, 48);
            this.buttonAddSpecDay.TabIndex = 1;
            this.buttonAddSpecDay.Text = "Добавить контрольный день";
            this.buttonAddSpecDay.UseVisualStyleBackColor = true;
            this.buttonAddSpecDay.Click += new System.EventHandler(this.buttonAddSpecDay_Click);
            // 
            // calendarForSpecDays
            // 
            this.calendarForSpecDays.CalendarDimensions = new System.Drawing.Size(4, 2);
            this.calendarForSpecDays.Location = new System.Drawing.Point(-9, 9);
            this.calendarForSpecDays.Name = "calendarForSpecDays";
            this.calendarForSpecDays.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonReset);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.buttonLoadSchedule);
            this.tabPage4.Controls.Add(this.treeViewPassLessons);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(659, 383);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(174, 333);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(101, 35);
            this.buttonReset.TabIndex = 21;
            this.buttonReset.Text = "Сбросить";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(538, 350);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 27);
            this.button5.TabIndex = 20;
            this.button5.Text = "Готовность";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonLoadSchedule
            // 
            this.buttonLoadSchedule.Location = new System.Drawing.Point(6, 333);
            this.buttonLoadSchedule.Name = "buttonLoadSchedule";
            this.buttonLoadSchedule.Size = new System.Drawing.Size(138, 35);
            this.buttonLoadSchedule.TabIndex = 17;
            this.buttonLoadSchedule.Text = "Загрузить готовое расписание";
            this.buttonLoadSchedule.UseVisualStyleBackColor = true;
            this.buttonLoadSchedule.Click += new System.EventHandler(this.buttonLoadSchedule_Click);
            // 
            // treeViewPassLessons
            // 
            this.treeViewPassLessons.Location = new System.Drawing.Point(6, 23);
            this.treeViewPassLessons.Name = "treeViewPassLessons";
            this.treeViewPassLessons.Size = new System.Drawing.Size(647, 304);
            this.treeViewPassLessons.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHelp.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.ForeColor = System.Drawing.Color.White;
            this.buttonHelp.Location = new System.Drawing.Point(732, 15);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(186, 45);
            this.buttonHelp.TabIndex = 14;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // datePeriodEnd
            // 
            this.datePeriodEnd.Location = new System.Drawing.Point(753, 151);
            this.datePeriodEnd.Name = "datePeriodEnd";
            this.datePeriodEnd.Size = new System.Drawing.Size(165, 20);
            this.datePeriodEnd.TabIndex = 15;
            this.datePeriodEnd.Value = new System.DateTime(2017, 4, 30, 0, 0, 0, 0);
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(753, 106);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(94, 13);
            this.labelPeriod.TabIndex = 16;
            this.labelPeriod.Text = "Период обучения";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "План",
            "Типовая неделя",
            "Дни контрольных занятий",
            "Загрузка готового расписания"});
            this.checkedListBox1.Location = new System.Drawing.Point(732, 192);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.checkedListBox1.Size = new System.Drawing.Size(186, 94);
            this.checkedListBox1.TabIndex = 17;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 432);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.datePeriodEnd);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.datePeriodStart);
            this.Controls.Add(this.buttonGenerateSchedule);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AYG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewSubjects;
        private System.Windows.Forms.Button buttonAddSubject;
        private System.Windows.Forms.Button buttonGenerateSchedule;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.DateTimePicker datePeriodStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateTemplate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxDayOfWeek;
        private System.Windows.Forms.Button buttonPrevDay;
        private System.Windows.Forms.Button buttonNextDay;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSaveTemplateWeek;
        private System.Windows.Forms.Button buttonLoadTemplateWeek;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonAddSpecDay;
        private System.Windows.Forms.MonthCalendar calendarForSpecDays;
        private System.Windows.Forms.DateTimePicker datePeriodEnd;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonEditDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button buttonControlLabel;
        private System.Windows.Forms.Button buttonAddTheme;
        private System.Windows.Forms.Button buttonLoadSchedule;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TreeView treeViewPassLessons;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button buttonPlanIsReady;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonReset;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

