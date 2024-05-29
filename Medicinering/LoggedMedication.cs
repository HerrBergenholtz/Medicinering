using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicinering
{
    public class LoggedMedication
    {
        public LoggedMedication(int id, string name, string dosage, DateTime takenAt) 
        {
            Id = id;
            Name = name;
            Dosage = dosage;
            TakenAt = takenAt;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Dosage { get; set; }
        public DateTime TakenAt { get; set; }
    }
}
