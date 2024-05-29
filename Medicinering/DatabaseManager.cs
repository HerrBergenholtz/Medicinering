using Medicinering;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

public class DatabaseManager
{
    private string connectionString = "Data Source=medications.db;Version=3;";

    public DatabaseManager()
    {
        CreateDatabase();
    }

    private void CreateDatabase()
    {
        using (SQLiteConnection connection = new(connectionString))
        {
            connection.Open();
            string createMedicationsTable = @"
                CREATE TABLE IF NOT EXISTS Medications (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    Dosage TEXT,
                    Times TEXT,
                    Regular BOOLEAN
                )";
            string createLogsTable = @"
                CREATE TABLE IF NOT EXISTS Logs (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    MedicationId INTEGER,
                    Name TEXT,
                    Dosage TEXT,
                    TakenAt DATETIME
                )";

            using (SQLiteCommand command = new(createMedicationsTable, connection))
            {
                command.ExecuteNonQuery();
            }

            using (SQLiteCommand command = new(createLogsTable, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    public void AddMedication(Medication medication)
    {
        using (SQLiteConnection connection = new(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Medications (Name, Dosage, Times, Regular) VALUES (@Name, @Dosage, @Times, @Regular)";
            using (SQLiteCommand command = new(query, connection))
            {
                command.Parameters.AddWithValue("@Name", medication.Name);
                command.Parameters.AddWithValue("@Dosage", medication.Dosage);
                command.Parameters.AddWithValue("@Times", string.Join(",", medication.Times));
                command.Parameters.AddWithValue("@Regular", medication.Regular);
                command.ExecuteNonQuery();
            }
        }
    }

    public List<Medication> GetMedications()
    {
        List<Medication> medications = new();

        using (SQLiteConnection connection = new(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Medications";
            using (SQLiteCommand command = new(query, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Medication medication = new(
                            reader.GetString(1),//Namn
                            reader.GetString(2),//Dos
                            reader.GetString(3).Split(',').Select(t => DateTime.Parse(t)).ToList(), //Tider
                            reader.GetBoolean(4) // Regular
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

    public void LogMedication(int medicationId, string name, string dosage)
    {
        using (SQLiteConnection connection = new(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Logs (MedicationId, Name, Dosage, TakenAt) VALUES (@MedicationId, @Name, @Dosage, @TakenAt)";
            using (SQLiteCommand command = new(query, connection))
            {
                command.Parameters.AddWithValue("@MedicationId", medicationId);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Dosage", dosage);
                command.Parameters.AddWithValue("@TakenAt", DateTime.Now);
                command.ExecuteNonQuery();
            }
        }
    }

    public void DeleteMedication(int medicationId)
    {
        using (SQLiteConnection connection = new(connectionString))
        {
            connection.Open();
            string query = "DELETE FROM Medications WHERE Id = @Id";
            using (SQLiteCommand command = new(query, connection))
            {
                command.Parameters.AddWithValue("@Id", medicationId);
                command.ExecuteNonQuery();
            }
        }
    }

    public List<LoggedMedication> GetLogs()
    {
        List<LoggedMedication> loggedMedications = new();

        using (SQLiteConnection connection = new(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Logs";
            using (SQLiteCommand command = new(query, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LoggedMedication loggedMedication = new(
                            reader.GetInt32(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetDateTime(4)
                        );
                        loggedMedications.Add(loggedMedication);
                    }
                }
            }
        }
        return loggedMedications;
    }
}