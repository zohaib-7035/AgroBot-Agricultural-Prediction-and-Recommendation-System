using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace agrobot
{
    internal class DB
    {
        private string connectionString = "Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=agrobot;Integrated Security=True;TrustServerCertificate=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    Console.WriteLine("Connection successful!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection failed: " + ex.Message);
                return false;
            }
        }

        // INSERT: takes table name and key-value data
        public int Insert(string table, Dictionary<string, object> data)
        {
            string columns = string.Join(", ", data.Keys);
            string parameters = string.Join(", ", data.Keys.Select(k => "@" + k));

            string query = $"INSERT INTO {table} ({columns}) VALUES ({parameters})";

            return ExecuteNonQuery(query, data);
        }

        // UPDATE: takes table name, data to update, and WHERE conditions
        public int Update(string table, Dictionary<string, object> data, Dictionary<string, object> whereConditions)
        {
            string setClause = string.Join(", ", data.Keys.Select(k => $"{k} = @{k}"));
            string whereClause = string.Join(" AND ", whereConditions.Keys.Select(k => $"{k} = @where_{k}"));

            string query = $"UPDATE {table} SET {setClause} WHERE {whereClause}";

            var allParams = new Dictionary<string, object>(data);
            foreach (var pair in whereConditions)
                allParams.Add($"where_{pair.Key}", pair.Value);

            return ExecuteNonQuery(query, allParams);
        }

        // DELETE: deletes rows based on WHERE conditions
        public int Delete(string table, Dictionary<string, object> whereConditions)
        {
            string whereClause = string.Join(" AND ", whereConditions.Keys.Select(k => $"{k} = @{k}"));
            string query = $"DELETE FROM {table} WHERE {whereClause}";

            return ExecuteNonQuery(query, whereConditions);
        }

        // SELECT: fetches data based on conditions or all
        public DataTable Select(string table, Dictionary<string, object>? whereConditions = null)
        {
            string query = $"SELECT * FROM {table}";

            if (whereConditions != null && whereConditions.Count > 0)
            {
                string whereClause = string.Join(" AND ", whereConditions.Keys.Select(k => $"{k} = @{k}"));
                query += $" WHERE {whereClause}";
            }

            return FetchData(query, whereConditions);
        }

        // Check if a record exists in a table
        public bool Exists(string table, Dictionary<string, object> whereConditions)
        {
            string whereClause = string.Join(" AND ", whereConditions.Keys.Select(k => $"{k} = @{k}"));
            string query = $"SELECT 1 FROM {table} WHERE {whereClause}";

            return CheckIfExists(query, whereConditions);
        }

        // Helper methods
        private int ExecuteNonQuery(string query, Dictionary<string, object>? parameters)
        {
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    foreach (var pair in parameters)
                    {
                        cmd.Parameters.AddWithValue("@" + pair.Key, pair.Value ?? DBNull.Value);
                    }
                }

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        private DataTable FetchData(string query, Dictionary<string, object>? parameters)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    foreach (var pair in parameters)
                    {
                        cmd.Parameters.AddWithValue("@" + pair.Key, pair.Value ?? DBNull.Value);
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            return dt;
        }

        private bool CheckIfExists(string query, Dictionary<string, object>? parameters)
        {
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    foreach (var pair in parameters)
                    {
                        cmd.Parameters.AddWithValue("@" + pair.Key, pair.Value ?? DBNull.Value);
                    }
                }

                conn.Open();
                object? result = cmd.ExecuteScalar();
                return result != null && result != DBNull.Value;
            }
        }
    }
}




