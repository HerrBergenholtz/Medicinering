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

            timeList.Items.Add(dateTimePicker1.Value.ToString("HH:mm"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medication newMedication;

            if (name.Text == "" || dosage.Text == "" || timeList.Items == null)
            {
                MessageBox.Show("Vänligen fyll i alla fält", "Fel uppstod", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            newMedication = new(name.Text, dosage.Text, times);

            databaseManager.AddMedication(newMedication);

            this.Close();
        }
    }
}