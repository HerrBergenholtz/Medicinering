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
            label3 = new Label();
            label4 = new Label();
            name = new TextBox();
            dosage = new TextBox();
            addMedication = new Button();
            frequency = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            addTime = new Button();
            timeList = new ListBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)frequency).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 58);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Namn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 106);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "Dos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 167);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Frekvens";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 227);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "Tid(er)";
            // 
            // name
            // 
            name.Location = new Point(298, 55);
            name.Name = "name";
            name.Size = new Size(309, 23);
            name.TabIndex = 4;
            // 
            // dosage
            // 
            dosage.Location = new Point(298, 103);
            dosage.Name = "dosage";
            dosage.Size = new Size(309, 23);
            dosage.TabIndex = 5;
            // 
            // addMedication
            // 
            addMedication.Location = new Point(298, 370);
            addMedication.Name = "addMedication";
            addMedication.Size = new Size(232, 43);
            addMedication.TabIndex = 8;
            addMedication.Text = "Lägg till";
            addMedication.UseVisualStyleBackColor = true;
            addMedication.Click += button1_Click;
            // 
            // frequency
            // 
            frequency.Location = new Point(298, 165);
            frequency.Name = "frequency";
            frequency.Size = new Size(120, 23);
            frequency.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(283, 221);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // addTime
            // 
            addTime.Location = new Point(510, 221);
            addTime.Name = "addTime";
            addTime.Size = new Size(75, 23);
            addTime.TabIndex = 11;
            addTime.Text = "Lägg till tid";
            addTime.UseVisualStyleBackColor = true;
            addTime.Click += addTime_Click;
            // 
            // timeList
            // 
            timeList.FormattingEnabled = true;
            timeList.ItemHeight = 15;
            timeList.Location = new Point(283, 273);
            timeList.Name = "timeList";
            timeList.Size = new Size(200, 64);
            timeList.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(201, 273);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 13;
            label5.Text = "Valda Tider:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 418);
            Controls.Add(label5);
            Controls.Add(timeList);
            Controls.Add(addTime);
            Controls.Add(dateTimePicker1);
            Controls.Add(frequency);
            Controls.Add(addMedication);
            Controls.Add(dosage);
            Controls.Add(name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)frequency).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox name;
        private TextBox dosage;
        private Button addMedication;
        private NumericUpDown frequency;
        private DateTimePicker dateTimePicker1;
        private Button addTime;
        private ListBox timeList;
        private Label label5;
    }
}