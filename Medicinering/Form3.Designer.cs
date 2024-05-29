namespace Medicinering
{
    partial class Form3
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
            listBox1 = new ListBox();
            closeForm = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(484, 624);
            listBox1.TabIndex = 0;
            // 
            // closeForm
            // 
            closeForm.Location = new Point(69, 651);
            closeForm.Name = "closeForm";
            closeForm.Size = new Size(361, 44);
            closeForm.TabIndex = 1;
            closeForm.Text = "Stäng";
            closeForm.UseVisualStyleBackColor = true;
            closeForm.Click += closeForm_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 707);
            Controls.Add(closeForm);
            Controls.Add(listBox1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button closeForm;
    }
}