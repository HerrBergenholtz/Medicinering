using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicinering
{
    public class Medication
    {
        public Medication(string name, string dosage, List<DateTime> times, bool regular) 
        {
            Name = name;
            Dosage = dosage;
            Times = times;
            Regular = regular;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Dosage { get; set; }
        public List<DateTime> Times { get; set; }
        public bool Regular {  get; set; }

        public bool TakeNow()
        {
            DateTime now = DateTime.Now;

            if (Times.Any(t => t.Hour == now.Hour && t.Minute == now.Minute))
            {
                return true;
            }
            else return false;
        }

        public void LogTaken(DatabaseManager databaseManager)
        {
            databaseManager.LogMedication(this.Id, this.Name, this.Dosage);
        }
    }
}
