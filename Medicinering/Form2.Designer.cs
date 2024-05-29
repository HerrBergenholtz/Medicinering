namespace Medicinering
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            name = new TextBox();
            dosage = new TextBox();
            addMedication = new Button();
            dateTimePicker1 = new DateTimePicker();
            addTime = new Button();
            timeList = new ListBox();
            label5 = new Label();
            dates = new CheckBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(247, 84);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 0;
            label1.Text = "Namn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(266, 148);
            label2.Name = "label2";
            label2.Size = new Size(50, 28);
            label2.TabIndex = 1;
            label2.Text = "Dos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(277, 266);
            label4.Name = "label4";
            label4.Size = new Size(39, 28);
            label4.TabIndex = 3;
            label4.Text = "Tid";
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(322, 84);
            name.Margin = new Padding(3, 4, 3, 4);
            name.Name = "name";
            name.Size = new Size(322, 34);
            name.TabIndex = 4;
            // 
            // dosage
            // 
            dosage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dosage.Location = new Point(322, 148);
            dosage.Margin = new Padding(3, 4, 3, 4);
            dosage.Name = "dosage";
            dosage.Size = new Size(322, 34);
            dosage.TabIndex = 5;
            // 
            // addMedication
            // 
            addMedication.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addMedication.Location = new Point(308, 487);
            addMedication.Margin = new Padding(3, 4, 3, 4);
            addMedication.Name = "addMedication";
            addMedication.Size = new Size(265, 47);
            addMedication.TabIndex = 8;
            addMedication.Text = "Lägg till";
            addMedication.UseVisualStyleBackColor = true;
            addMedication.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(322, 267);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(322, 34);
            dateTimePicker1.TabIndex = 10;
            // 
            // addTime
            // 
            addTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addTime.Location = new Point(650, 266);
            addTime.Margin = new Padding(3, 4, 3, 4);
            addTime.Name = "addTime";
            addTime.Size = new Size(97, 38);
            addTime.TabIndex = 11;
            addTime.Text = "Lägg till tid";
            addTime.UseVisualStyleBackColor = true;
            addTime.Click += addTime_Click;
            // 
            // timeList
            // 
            timeList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeList.FormattingEnabled = true;
            timeList.ItemHeight = 28;
            timeList.Location = new Point(355, 347);
            timeList.Margin = new Padding(3, 4, 3, 4);
            timeList.Name = "timeList";
            timeList.Size = new Size(251, 116);
            timeList.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(236, 347);
            label5.Name = "label5";
            label5.Size = new Size(113, 28);
            label5.TabIndex = 13;
            label5.Text = "Valda Tider:";
            // 
            // dates
            // 
            dates.AutoSize = true;
            dates.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dates.Location = new Point(355, 214);
            dates.Name = "dates";
            dates.Size = new Size(212, 32);
            dates.TabIndex = 14;
            dates.Text = "Ta medicin varje dag";
            dates.UseVisualStyleBackColor = true;
            dates.CheckedChanged += dates_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(355, 21);
            label3.Name = "label3";
            label3.Size = new Size(198, 35);
            label3.TabIndex = 15;
            label3.Text = "Lägg till Medicin";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 557);
            Controls.Add(label3);
            Controls.Add(dates);
            Controls.Add(label5);
            Controls.Add(timeList);
            Controls.Add(addTime);
            Controls.Add(dateTimePicker1);
            Controls.Add(addMedication);
            Controls.Add(dosage);
            Controls.Add(name);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox name;
        private TextBox dosage;
        private Button addMedication;
        private DateTimePicker dateTimePicker1;
        private Button addTime;
        private ListBox timeList;
        private Label label5;
        private CheckBox dates;
        private Label label3;
    }
}