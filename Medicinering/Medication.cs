using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicinering
{
    public class Medication
    {
        public Medication(string name, string dosage, List<DateTime> times) 
        {
            Name = name;
            Dosage = dosage;
            Times = times;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Dosage { get; set; }
        public List<DateTime> Times { get; set; }

        public void LogTaken(DatabaseManager databaseManager)
        {
            databaseManager.LogMedication(this.Id, this.Name, this.Dosage);
        }
    }
}
