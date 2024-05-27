using Timer = System.Windows.Forms.Timer;

namespace Medicinering
{
    public partial class Form1 : Form
    {
        private databaseManager databaseManager;
        private Timer timer;
        private List<Medication> medications;

        public Form1()
        {
            InitializeComponent();
            databaseManager = new();
            LoadMedications();
            InitializeTimer();
        }

        private void LoadMedications()
        {
            medications = databaseManager.GetMedications();

        }

        private void InitializeTimer()
        {
            timer = new();
            timer.Interval = 60000;
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            checkMedications();
            medicationList.Items.Clear();
            foreach (var med in medications)
            {
                medicationList.Items.Add($"{med.Name} - {med.Dosage} - {med.Frequency} times a day");
            }
        }

        private void checkMedications()
        {
            foreach (var med in medications)
            {
                if (med.TakeNow())
                {
                    MessageBox.Show($"Time to take {med.Name}!", "Medication Reminder");
                    med.LogTaken(databaseManager);
                }
            }
        }

        private void addMedication_Click(object sender, EventArgs e)
        {
            Form2 form2 = new(databaseManager);
            form2.ShowDialog();
            LoadMedications();
        }
    }
}