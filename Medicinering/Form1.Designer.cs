namespace Medicinering
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            medicationList = new ListBox();
            monthCalendar1 = new MonthCalendar();
            addMedication = new Button();
            SuspendLayout();
            // 
            // medicationList
            // 
            medicationList.FormattingEnabled = true;
            medicationList.ItemHeight = 15;
            medicationList.Location = new Point(40, 33);
            medicationList.Name = "medicationList";
            medicationList.Size = new Size(279, 319);
            medicationList.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(366, 33);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            // 
            // addMedication
            // 
            addMedication.Location = new Point(40, 374);
            addMedication.Name = "addMedication";
            addMedication.Size = new Size(279, 35);
            addMedication.TabIndex = 2;
            addMedication.Text = "Lägg till medicin";
            addMedication.UseVisualStyleBackColor = true;
            addMedication.Click += addMedication_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addMedication);
            Controls.Add(monthCalendar1);
            Controls.Add(medicationList);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox medicationList;
        private MonthCalendar monthCalendar1;
        private Button addMedication;
    }
}