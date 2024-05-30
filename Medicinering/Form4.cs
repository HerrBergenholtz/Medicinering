using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicinering
{
    public partial class Form4 : Form
    {
        private Medication medication;
        public Form4(Medication medication)
        {
            this.medication = medication;
            InitializeComponent();
            DrawInformation();
        }

        private void DrawInformation()
        {
            ListViewItem item = new(medication.Id.ToString());

            item.SubItems.Add(medication.Name);
            item.SubItems.Add(medication.Dosage);
            listView1.Items.Add(item);

            textBox1.Text = string.Join(Environment.NewLine, medication.Times.Select(t => t.ToString().Split(" ")[1]));
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}