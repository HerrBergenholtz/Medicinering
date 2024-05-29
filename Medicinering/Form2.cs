using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Medicinering
{
    public partial class Form2 : Form
    {
        private DatabaseManager databaseManager;
        private List<DateTime> times;

        public Form2(DatabaseManager databaseManager)
        {
            InitializeComponent();
            this.databaseManager = databaseManager;
            times = new List<DateTime>();
        }

        private void addTime_Click(object sender, EventArgs e)
        {
            times.Add(dateTimePicker1.Value);

            if (dates.Checked)
            {
                timeList.Items.Add(dateTimePicker1.Value.ToString("HH:mm"));
            }
            else
            {
                timeList.Items.Add(dateTimePicker1.Value.ToString("MM/dd/yyyy HH:mm"));
            }
        }

        private void dates_CheckedChanged(object sender, EventArgs e)
        {
            if (dates.Checked)
            {
                dateTimePicker1.Format = DateTimePickerFormat.Time;
            }
            else
            {
                dateTimePicker1.Format = DateTimePickerFormat.Long;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medication newMedication;

            if (name.Text == "" || dosage.Text == "" || timeList.Items == null)
            {
                MessageBox.Show("Vänligen fyll i alla fält", "Fel uppstod", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            if (dates.Checked)
            {
                newMedication = new(name.Text, dosage.Text, times, true);
            }
            else
            {
                newMedication = new(name.Text, dosage.Text, times, false);
            }

            databaseManager.AddMedication(newMedication);

            this.Close();
        }
    }
}
