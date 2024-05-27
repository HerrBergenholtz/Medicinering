using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicinering
{
    public class Medication
    {
        public Medication(string name, string dosage, int frequency, List<DateTime> times) 
        {
            Name = name;
            Dosage = dosage;
            Frequency = frequency;
            Times = times;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Dosage { get; set; }
        public int Frequency { get; set; }
        public List<DateTime> Times { get; set; }

        public bool TakeNow()
        {
            DateTime now = DateTime.Now;
            return Times.Any(t => t.Hour == now.Hour && t.Minute == now.Minute);
        }

        public void LogTaken(databaseManager databaseManager)
        {
            databaseManager.LogMedication(this.Id);
        }
    }
}
