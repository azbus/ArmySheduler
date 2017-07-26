namespace ArmyYearGenerator
{
    partial class AddEventTemplateForm
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
            this.checkedDaysOfWeek = new System.Windows.Forms.CheckedListBox();
            this.maskedTextBoxStartTime = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxEndTime = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddTemplate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxEventName = new System.Windows.Forms.ComboBox();
            this.comboBoxHours = new System.Windows.Forms.ComboBox();
            this.labelHour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedDaysOfWeek
            // 
            this.checkedDaysOfWeek.FormattingEnabled = true;
            this.checkedDaysOfWeek.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"});
            this.checkedDaysOfWeek.Location = new System.Drawing.Point(12, 119);
            this.checkedDaysOfWeek.Name = "checkedDaysOfWeek";
            this.checkedDaysOfWeek.Size = new System.Drawing.Size(120, 109);
            this.checkedDaysOfWeek.TabIndex = 0;
            // 
            // maskedTextBoxStartTime
            // 
            this.maskedTextBoxStartTime.Location = new System.Drawing.Point(247, 119);
            this.maskedTextBoxStartTime.Mask = "00:00";
            this.maskedTextBoxStartTime.Name = "maskedTextBoxStartTime";
            this.maskedTextBoxStartTime.Size = new System.Drawing.Size(34, 20);
            this.maskedTextBoxStartTime.TabIndex = 1;
            this.maskedTextBoxStartTime.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxEndTime
            // 
            this.maskedTextBoxEndTime.Location = new System.Drawing.Point(247, 145);
            this.maskedTextBoxEndTime.Mask = "00:00";
            this.maskedTextBoxEndTime.Name = "maskedTextBoxEndTime";
            this.maskedTextBoxEndTime.Size = new System.Drawing.Size(34, 20);
            this.maskedTextBoxEndTime.TabIndex = 2;
            this.maskedTextBoxEndTime.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Время начала";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Время окончания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Название события";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дни недели";
            // 
            // buttonAddTemplate
            // 
            this.buttonAddTemplate.Location = new System.Drawing.Point(12, 280);
            this.buttonAddTemplate.Name = "buttonAddTemplate";
            this.buttonAddTemplate.Size = new System.Drawing.Size(313, 59);
            this.buttonAddTemplate.TabIndex = 8;
            this.buttonAddTemplate.Text = "Добавить";
            this.buttonAddTemplate.UseVisualStyleBackColor = true;
            this.buttonAddTemplate.Click += new System.EventHandler(this.buttonAddTemplate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 345);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(313, 33);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxEventName
            // 
            this.comboBoxEventName.FormattingEnabled = true;
            this.comboBoxEventName.Location = new System.Drawing.Point(12, 25);
            this.comboBoxEventName.Name = "comboBoxEventName";
            this.comboBoxEventName.Size = new System.Drawing.Size(268, 21);
            this.comboBoxEventName.TabIndex = 11;
            this.comboBoxEventName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxHours
            // 
            this.comboBoxHours.FormattingEnabled = true;
            this.comboBoxHours.Items.AddRange(new object[] {
            "1 час",
            "2 час",
            "3 час",
            "4 час",
            "5 час",
            "6 час",
            "7 час",
            "8 час"});
            this.comboBoxHours.Location = new System.Drawing.Point(12, 64);
            this.comboBoxHours.Name = "comboBoxHours";
            this.comboBoxHours.Size = new System.Drawing.Size(268, 21);
            this.comboBoxHours.TabIndex = 12;
            this.comboBoxHours.Visible = false;
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(9, 49);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(71, 13);
            this.labelHour.TabIndex = 13;
            this.labelHour.Text = "Час занятий";
            this.labelHour.Visible = false;
            // 
            // AddEventTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 384);
            this.ControlBox = false;
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.comboBoxHours);
            this.Controls.Add(this.comboBoxEventName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddTemplate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxEndTime);
            this.Controls.Add(this.maskedTextBoxStartTime);
            this.Controls.Add(this.checkedDaysOfWeek);
            this.Name = "AddEventTemplateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление шаблона события";
            this.Load += new System.EventHandler(this.AddEventTemplateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedDaysOfWeek;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartTime;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEndTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddTemplate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxEventName;
        private System.Windows.Forms.ComboBox comboBoxHours;
        private System.Windows.Forms.Label labelHour;
    }
}