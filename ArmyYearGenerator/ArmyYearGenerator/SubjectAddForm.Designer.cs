namespace ArmyYearGenerator
{
    partial class SubjectAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSubjectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.treeViewThemes = new System.Windows.Forms.TreeView();
            this.numericUpDownCountThemes = new System.Windows.Forms.NumericUpDown();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAddLesson = new System.Windows.Forms.Button();
            this.buttonDelet = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonControlLabel = new System.Windows.Forms.Button();
            this.pictureHelpBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxCombat = new System.Windows.Forms.CheckBox();
            this.buttonAddTheme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountThemes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHelpBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название предмета";
            // 
            // textBoxSubjectName
            // 
            this.textBoxSubjectName.Location = new System.Drawing.Point(183, 12);
            this.textBoxSubjectName.Name = "textBoxSubjectName";
            this.textBoxSubjectName.Size = new System.Drawing.Size(196, 20);
            this.textBoxSubjectName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество тем по предмету";
            this.label2.Visible = false;
            // 
            // treeViewThemes
            // 
            this.treeViewThemes.Location = new System.Drawing.Point(13, 67);
            this.treeViewThemes.Name = "treeViewThemes";
            this.treeViewThemes.ShowNodeToolTips = true;
            this.treeViewThemes.Size = new System.Drawing.Size(570, 286);
            this.treeViewThemes.TabIndex = 4;
            this.treeViewThemes.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
            this.treeViewThemes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeViewThemes.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // numericUpDownCountThemes
            // 
            this.numericUpDownCountThemes.Location = new System.Drawing.Point(183, 38);
            this.numericUpDownCountThemes.Name = "numericUpDownCountThemes";
            this.numericUpDownCountThemes.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownCountThemes.TabIndex = 6;
            this.numericUpDownCountThemes.Visible = false;
            this.numericUpDownCountThemes.ValueChanged += new System.EventHandler(this.numericUpDownCountThemes_ValueChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(13, 360);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(96, 23);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAddLesson
            // 
            this.buttonAddLesson.Location = new System.Drawing.Point(244, 389);
            this.buttonAddLesson.Name = "buttonAddLesson";
            this.buttonAddLesson.Size = new System.Drawing.Size(111, 23);
            this.buttonAddLesson.TabIndex = 8;
            this.buttonAddLesson.Text = "Добавить занятие";
            this.buttonAddLesson.UseVisualStyleBackColor = true;
            this.buttonAddLesson.Click += new System.EventHandler(this.buttonAddLesson_Click);
            // 
            // buttonDelet
            // 
            this.buttonDelet.Location = new System.Drawing.Point(115, 360);
            this.buttonDelet.Name = "buttonDelet";
            this.buttonDelet.Size = new System.Drawing.Size(96, 23);
            this.buttonDelet.TabIndex = 9;
            this.buttonDelet.Text = "Удалить";
            this.buttonDelet.UseVisualStyleBackColor = true;
            this.buttonDelet.Click += new System.EventHandler(this.buttonDelet_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(406, 359);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(177, 34);
            this.buttonAccept.TabIndex = 10;
            this.buttonAccept.Text = "Применить";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(406, 399);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(177, 28);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonControlLabel
            // 
            this.buttonControlLabel.Enabled = false;
            this.buttonControlLabel.Location = new System.Drawing.Point(13, 389);
            this.buttonControlLabel.Name = "buttonControlLabel";
            this.buttonControlLabel.Size = new System.Drawing.Size(198, 38);
            this.buttonControlLabel.TabIndex = 12;
            this.buttonControlLabel.Text = "Пометить как контрольную тему";
            this.buttonControlLabel.UseVisualStyleBackColor = true;
            this.buttonControlLabel.Click += new System.EventHandler(this.buttonControlLabel_Click);
            // 
            // pictureHelpBox
            // 
            this.pictureHelpBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureHelpBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureHelpBox.Location = new System.Drawing.Point(423, 47);
            this.pictureHelpBox.Name = "pictureHelpBox";
            this.pictureHelpBox.Size = new System.Drawing.Size(46, 17);
            this.pictureHelpBox.TabIndex = 13;
            this.pictureHelpBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "- Контрольная тема";
            // 
            // checkBoxCombat
            // 
            this.checkBoxCombat.AutoSize = true;
            this.checkBoxCombat.Location = new System.Drawing.Point(385, 14);
            this.checkBoxCombat.Name = "checkBoxCombat";
            this.checkBoxCombat.Size = new System.Drawing.Size(124, 17);
            this.checkBoxCombat.TabIndex = 15;
            this.checkBoxCombat.Text = "Боевая подготовка";
            this.checkBoxCombat.UseVisualStyleBackColor = true;
            // 
            // buttonAddTheme
            // 
            this.buttonAddTheme.Location = new System.Drawing.Point(244, 359);
            this.buttonAddTheme.Name = "buttonAddTheme";
            this.buttonAddTheme.Size = new System.Drawing.Size(111, 23);
            this.buttonAddTheme.TabIndex = 16;
            this.buttonAddTheme.Text = "Добавить тему";
            this.buttonAddTheme.UseVisualStyleBackColor = true;
            this.buttonAddTheme.Click += new System.EventHandler(this.buttonAddTheme_Click);
            // 
            // SubjectAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(595, 429);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAddTheme);
            this.Controls.Add(this.checkBoxCombat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureHelpBox);
            this.Controls.Add(this.buttonControlLabel);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.buttonDelet);
            this.Controls.Add(this.buttonAddLesson);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.numericUpDownCountThemes);
            this.Controls.Add(this.treeViewThemes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSubjectName);
            this.Controls.Add(this.label1);
            this.Name = "SubjectAddForm";
            this.ShowIcon = false;
            this.Text = "Добавление события";
            this.Load += new System.EventHandler(this.SubjectAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountThemes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHelpBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSubjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeViewThemes;
        private System.Windows.Forms.NumericUpDown numericUpDownCountThemes;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAddLesson;
        private System.Windows.Forms.Button buttonDelet;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonControlLabel;
        private System.Windows.Forms.PictureBox pictureHelpBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxCombat;
        private System.Windows.Forms.Button buttonAddTheme;
    }
}