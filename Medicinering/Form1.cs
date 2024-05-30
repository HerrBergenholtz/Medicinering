using Timer = System.Windows.Forms.Timer;

namespace Medicinering
{
    public partial class Form1 : Form
    {
        private DatabaseManager databaseManager;
        private Timer timer;
        private List<Medication> medications;
        private Dictionary<int, DateTime> lastAlertTime;

        public Form1()
        {
            InitializeComponent();

            databaseManager = new();
            lastAlertTime = new Dictionary<int, DateTime>();

            InitializeTimer();
            UpdateMedicationList();
        }

        private void InitializeTimer()
        {
            timer = new();
            timer.Interval = 20000;
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            UpdateMedicationList();
            CheckMedicationAlerts();
        }

        private void UpdateMedicationList()
        {
            medications = databaseManager.GetMedications();
            medicationList.Items.Clear();

            foreach (var medication in medications)
            {
                medicationList.Items.Add($"{medication.Name} - {medication.Dosage}");
            }
        }

        private void CheckMedicationAlerts()
        {
            foreach (Medication medication in medications)
            {
                foreach (DateTime time in medication.Times)
                {
                    DateTime now = DateTime.Now;
                    DateTime medicationTime = new(now.Year, now.Month, now.Day, time.Hour, time.Minute, 0);

                    if (medicationTime <= now && medicationTime >= now.AddMinutes(-1))
                    {
                        if (lastAlertTime.ContainsKey(medication.Id))
                        {
                            DateTime lastAlert = lastAlertTime[medication.Id];
                            if (lastAlert.Date == now.Date)
                            {
                                continue;
                            }
                        }

                        lastAlertTime[medication.Id] = now;
                        MessageBox.Show($"Dags att ta: {medication.Name} - {medication.Dosage}", "P�minnelse!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        medication.LogTaken(databaseManager);
                    }
                }
            }
        }

        private void addMedication_Click(object sender, EventArgs e)
        {
            Form2 form2 = new(databaseManager);
            form2.ShowDialog();
            UpdateMedicationList();
        }

        private void additionalInformation_Click(object sender, EventArgs e)
        {
            if (medicationList.SelectedItem == null)
            {
                MessageBox.Show("V�nligen v�lj en medecin", "Visa medicin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Medication selectedMedication = medications[medicationList.SelectedIndex];

            Form4 form4 = new(selectedMedication);
            form4.ShowDialog();
        }

        private void removeMedication_Click(object sender, EventArgs e)
        {
            if (medicationList.SelectedItem == null)
            {
                MessageBox.Show("V�nligen v�lj en medecin att ta bort", "Ta bort medicin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Medication selectedMedication = medications[medicationList.SelectedIndex];

            DialogResult confirmResult = MessageBox.Show($"�r du s�ker p� att du vill ta bort {selectedMedication.Name}?", "Bekr�fta radera", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                databaseManager.DeleteMedication(selectedMedication.Id);
                UpdateMedicationList();
            }
        }

        private void showHistory_Click(object sender, EventArgs e)
        {
            Form3 form3 = new(databaseManager);
            form3.ShowDialog();
        }
    }
}