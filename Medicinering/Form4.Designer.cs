namespace Medicinering
{
    partial class Form4
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
            listView1 = new ListView();
            Id = new ColumnHeader();
            Namn = new ColumnHeader();
            Dos = new ColumnHeader();
            Tider = new ColumnHeader();
            textBox1 = new TextBox();
            closeForm = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Id, Namn, Dos, Tider });
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.Location = new Point(11, 42);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(758, 238);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 50;
            // 
            // Namn
            // 
            Namn.Text = "Namn";
            Namn.Width = 250;
            // 
            // Dos
            // 
            Dos.Text = "Dos";
            Dos.Width = 220;
            // 
            // Tider
            // 
            Tider.Text = "Tider";
            Tider.Width = 220;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(532, 69);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 208);
            textBox1.TabIndex = 1;
            // 
            // closeForm
            // 
            closeForm.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            closeForm.Location = new Point(250, 292);
            closeForm.Name = "closeForm";
            closeForm.Size = new Size(279, 35);
            closeForm.TabIndex = 3;
            closeForm.Text = "Stäng";
            closeForm.UseVisualStyleBackColor = true;
            closeForm.Click += closeForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(323, 7);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 4;
            label1.Text = "Information";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 338);
            Controls.Add(label1);
            Controls.Add(closeForm);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader Id;
        private ColumnHeader Namn;
        private ColumnHeader Dos;
        private ColumnHeader Tider;
        private TextBox textBox1;
        private Button closeForm;
        private Label label1;
    }
}