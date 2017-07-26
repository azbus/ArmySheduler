namespace ArmyYearGenerator
{
    partial class AddSpecialDayForm
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
            this.comboBoxEvents = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxEndTime = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxStartTime = new System.Windows.Forms.MaskedTextBox();
            this.buttonAddTemplate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxControlThemes = new System.Windows.Forms.ComboBox();
            this.labelControlTheme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEvents
            // 
            this.comboBoxEvents.FormattingEnabled = true;
            this.comboBoxEvents.Location = new System.Drawing.Point(12, 27);
            this.comboBoxEvents.Name = "comboBoxEvents";
            this.comboBoxEvents.Size = new System.Drawing.Size(263, 21);
            this.comboBoxEvents.TabIndex = 0;
            this.comboBoxEvents.SelectedIndexChanged += new System.EventHandler(this.comboBoxEvents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название события";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тема события";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Время окончания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Время начала";
            // 
            // maskedTextBoxEndTime
            // 
            this.maskedTextBoxEndTime.Location = new System.Drawing.Point(114, 189);
            this.maskedTextBoxEndTime.Mask = "00:00";
            this.maskedTextBoxEndTime.Name = "maskedTextBoxEndTime";
            this.maskedTextBoxEndTime.Size = new System.Drawing.Size(34, 20);
            this.maskedTextBoxEndTime.TabIndex = 6;
            this.maskedTextBoxEndTime.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxStartTime
            // 
            this.maskedTextBoxStartTime.Location = new System.Drawing.Point(114, 163);
            this.maskedTextBoxStartTime.Mask = "00:00";
            this.maskedTextBoxStartTime.Name = "maskedTextBoxStartTime";
            this.maskedTextBoxStartTime.Size = new System.Drawing.Size(34, 20);
            this.maskedTextBoxStartTime.TabIndex = 5;
            this.maskedTextBoxStartTime.ValidatingType = typeof(System.DateTime);
            // 
            // buttonAddTemplate
            // 
            this.buttonAddTemplate.Location = new System.Drawing.Point(12, 356);
            this.buttonAddTemplate.Name = "buttonAddTemplate";
            this.buttonAddTemplate.Size = new System.Drawing.Size(263, 59);
            this.buttonAddTemplate.TabIndex = 9;
            this.buttonAddTemplate.Text = "Добавить";
            this.buttonAddTemplate.UseVisualStyleBackColor = true;
            this.buttonAddTemplate.Click += new System.EventHandler(this.buttonAddTemplate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 421);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(263, 33);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(388, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(588, 278);
            this.dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Время начала";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Время окончания";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Предметы обучения, номера тем, занятий и их содержание";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 450;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 59);
            this.button1.TabIndex = 12;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxControlThemes
            // 
            this.comboBoxControlThemes.FormattingEnabled = true;
            this.comboBoxControlThemes.Location = new System.Drawing.Point(12, 73);
            this.comboBoxControlThemes.Name = "comboBoxControlThemes";
            this.comboBoxControlThemes.Size = new System.Drawing.Size(263, 21);
            this.comboBoxControlThemes.TabIndex = 13;
            this.comboBoxControlThemes.Visible = false;
            // 
            // labelControlTheme
            // 
            this.labelControlTheme.AutoSize = true;
            this.labelControlTheme.Location = new System.Drawing.Point(9, 57);
            this.labelControlTheme.Name = "labelControlTheme";
            this.labelControlTheme.Size = new System.Drawing.Size(34, 13);
            this.labelControlTheme.TabIndex = 14;
            this.labelControlTheme.Text = "Тема";
            this.labelControlTheme.Visible = false;
            // 
            // AddSpecialDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 466);
            this.Controls.Add(this.labelControlTheme);
            this.Controls.Add(this.comboBoxControlThemes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddTemplate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBoxEndTime);
            this.Controls.Add(this.maskedTextBoxStartTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEvents);
            this.Name = "AddSpecialDayForm";
            this.Text = "AddSpecialDayForm";
            this.Load += new System.EventHandler(this.AddSpecialDayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEndTime;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartTime;
        private System.Windows.Forms.Button buttonAddTemplate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ComboBox comboBoxControlThemes;
        private System.Windows.Forms.Label labelControlTheme;
    }
}