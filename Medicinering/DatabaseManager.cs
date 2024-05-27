using Medicinering;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

public class databaseManager
{
    private string connectionString = "Data Source=medications.db;Version=3;";

    public databaseManager()
    {
        CreateDatabase();
    }

    private void CreateDatabase()
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string createMedicationsTable = @"
                CREATE TABLE IF NOT EXISTS Medications (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    Dosage TEXT,
                    Frequency INTEGER,
                    Times TEXT
                )";
            string createLogsTable = @"
                CREATE TABLE IF NOT EXISTS Logs (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    MedicationId INTEGER,
                    TakenAt DATETIME
                )";
            using (var command = new SQLiteCommand(createMedicationsTable, connection))
            {
                command.ExecuteNonQuery();
            }
            using (var command = new SQLiteCommand(createLogsTable, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    public void AddMedication(Medication medication)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Medications (Name, Dosage, Frequency, Times) VALUES (@Name, @Dosage, @Frequency, @Times)";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", medication.Name);
                command.Parameters.AddWithValue("@Dosage", medication.Dosage);
                command.Parameters.AddWithValue("@Frequency", medication.Frequency);
                command.Parameters.AddWithValue("@Times", string.Join(",", medication.Times));
                command.ExecuteNonQuery();
            }
        }
    }

    public List<Medication> GetMedications()
    {
        List<Medication> medications = new List<Medication>();
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Medications";
            using (var command = new SQLiteCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Medication medication = new Medication(
                            reader.GetString(1), // Name
                            reader.GetString(2), // Dosage
                            reader.GetInt32(3),  // Frequency
                            reader.GetString(4).Split(',').Select(t => DateTime.Parse(t)).ToList() // Times
                        )
                        {
                            Id = reader.GetInt32(0) // Id
                        };
                        medications.Add(medication);
                    }
                }
            }
        }
        return medications;
    }

    public void LogMedication(int medicationId)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Logs (MedicationId, TakenAt) VALUES (@MedicationId, @TakenAt)";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MedicationId", medicationId);
                command.Parameters.AddWithValue("@TakenAt", DateTime.Now);
                command.ExecuteNonQuery();
            }
        }
    }
}