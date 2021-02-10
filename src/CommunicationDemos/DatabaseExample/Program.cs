using Microsoft.Data.Sqlite;
using System;

namespace DatabaseExample
{
    class Program
    {
        static void ReadData(SqliteConnection conn)
        {
            SqliteCommand sqlCommand;
            sqlCommand = conn.CreateCommand();
            sqlCommand.CommandText = "SELECT id, name, price, description FROM Cars";

            SqliteDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string name = reader.GetString(1);
                string price = reader.GetString(2);
                string description = reader.GetString(3);
                Console.WriteLine("id: {0}, name: {1}, price: {2}, description: {3}", id, name, price, description);
            }
        }

        static void RunCommand(SqliteConnection conn, string sqlCommand)
        {
            using var cmd = new SqliteCommand(sqlCommand, conn);
            cmd.ExecuteNonQuery();
        }

        static void Main(string[] args)
        {
            string connectionString = "Data Source=:memory:";
            //string connectionString = @"Data Source=file:C:\tmp1\cars1.db";

            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            RunCommand(connection, @"CREATE TABLE IF NOT EXISTS cars(id INTEGER PRIMARY KEY, name TEXT, price INT, description VARCHAR(100))");

            RunCommand(connection, "INSERT INTO cars(name, price, description) VALUES('Audi',52642,'d1')");
            RunCommand(connection, "INSERT INTO cars(name, price, description) VALUES('BMW',48512, 'd2')");
            RunCommand(connection, "INSERT INTO cars(name, price, description) VALUES('Skoda',20000, 'd3')");
            RunCommand(connection, "INSERT INTO cars(name, price, description) VALUES('Fiat',20000, 'd4')");

            ReadData(connection);

        }
    }
}
