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
            removeMedication = new Button();
            showHistory = new Button();
            additionalInformation = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // medicationList
            // 
            medicationList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            medicationList.FormattingEnabled = true;
            medicationList.ItemHeight = 28;
            medicationList.Location = new Point(45, 76);
            medicationList.Margin = new Padding(3, 4, 3, 4);
            medicationList.Name = "medicationList";
            medicationList.Size = new Size(404, 424);
            medicationList.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            monthCalendar1.Location = new Point(480, 76);
            monthCalendar1.Margin = new Padding(10, 12, 10, 12);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 5;
            // 
            // addMedication
            // 
            addMedication.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            addMedication.Location = new Point(89, 524);
            addMedication.Margin = new Padding(3, 4, 3, 4);
            addMedication.Name = "addMedication";
            addMedication.Size = new Size(319, 47);
            addMedication.TabIndex = 1;
            addMedication.Text = "Lägg till medicin";
            addMedication.UseVisualStyleBackColor = true;
            addMedication.Click += addMedication_Click;
            // 
            // removeMedication
            // 
            removeMedication.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            removeMedication.Location = new Point(89, 659);
            removeMedication.Margin = new Padding(3, 4, 3, 4);
            removeMedication.Name = "removeMedication";
            removeMedication.Size = new Size(319, 47);
            removeMedication.TabIndex = 3;
            removeMedication.Text = "Ta bort medicin";
            removeMedication.UseVisualStyleBackColor = true;
            removeMedication.Click += removeMedication_Click;
            // 
            // showHistory
            // 
            showHistory.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            showHistory.Location = new Point(480, 524);
            showHistory.Name = "showHistory";
            showHistory.Size = new Size(262, 48);
            showHistory.TabIndex = 4;
            showHistory.Text = "Visa historik";
            showHistory.UseVisualStyleBackColor = true;
            showHistory.Click += showHistory_Click;
            // 
            // additionalInformation
            // 
            additionalInformation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            additionalInformation.Location = new Point(89, 591);
            additionalInformation.Name = "additionalInformation";
            additionalInformation.Size = new Size(319, 47);
            additionalInformation.TabIndex = 2;
            additionalInformation.Text = "Visa Information";
            additionalInformation.UseVisualStyleBackColor = true;
            additionalInformation.Click += additionalInformation_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(89, 20);
            label1.Name = "label1";
            label1.Size = new Size(302, 41);
            label1.TabIndex = 6;
            label1.Text = "Nuvarande Mediciner";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 729);
            Controls.Add(label1);
            Controls.Add(additionalInformation);
            Controls.Add(showHistory);
            Controls.Add(removeMedication);
            Controls.Add(addMedication);
            Controls.Add(monthCalendar1);
            Controls.Add(medicationList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox medicationList;
        private MonthCalendar monthCalendar1;
        private Button addMedication;
        private Button removeMedication;
        private Button showHistory;
        private Button additionalInformation;
        private Label label1;
    }
}