using MyTasks.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MyTasks.Repositories
{
    public class TasksRepository
    {
        private readonly string _connectionString;

        public TasksRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Task> Tasks()
        {
            List<Task> tasks = new List<Task>();
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Id, Name, StartDate, EndDate, Status FROM Tasks";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Task task = new Task()
                    {
                        Id = Convert.ToInt32(reader["ID"]),
                        Name = reader["Name"].ToString(),
                        StartDate = Convert.ToDateTime(reader["StartDate"]),
                        EndDate = Convert.ToDateTime(reader["EndDate"]),
                        Status = reader["Status"].ToString()
                    };
                    tasks.Add(task);
                }
                connection.Close();
            }
            return tasks;
        }

        public void CreateTask(Task task)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Tasks (Name, StartDate, EndDate, Status) 
                             VALUES (@Name, @StartDate, @EndDate, @Status)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", task.Name);
                    command.Parameters.AddWithValue("@StartDate", task.StartDate);
                    command.Parameters.AddWithValue("@EndDate", task.EndDate);
                    command.Parameters.AddWithValue("@Status", task.Status);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}