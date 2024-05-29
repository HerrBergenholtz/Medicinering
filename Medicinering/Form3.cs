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
    public partial class Form3 : Form
    {
        private List<LoggedMedication> loggedMedications;
        private DatabaseManager databaseManager;
        public Form3(DatabaseManager databaseManager)
        {
            this.databaseManager = databaseManager;
            InitializeComponent();
            CheckLoggedMedications();
        }

        private void CheckLoggedMedications()
        {
            listBox1.Items.Clear();
            loggedMedications = databaseManager.GetLogs();

            foreach (LoggedMedication loggedMed in loggedMedications)
            {
                listBox1.Items.Add($"{loggedMed.Id} - {loggedMed.Name} - {loggedMed.Dosage} - {loggedMed.TakenAt}");
            }
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}