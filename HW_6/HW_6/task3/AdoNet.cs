using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices.ComTypes;

namespace HW_6.task3
{
    public static class AdoNet
    {
        public static void AdonetShow()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["AdvanceCSharpCS"].ConnectionString;
            var CreateTableStories = @"create table [dbo].[Stories]([ID] [int] NOT NULL, [Name] [nvarchar](50) NOT NULL, [Description] [nvarchar](50) NOT NULL,) on[PRIMARY]";
            var InsertStories = @"insert into Stories (Id, Name, Description) values (@id, @name, @description)";
            var ReaderStories = @"select * from Stories";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
               
                SqlCommand commandC = new SqlCommand(CreateTableStories, connection);
               commandC.ExecuteNonQuery();
              
               SqlCommand commandI = new SqlCommand(InsertStories, connection);

                  commandI.Parameters.Add(new SqlParameter("@id", 3));
                  commandI.Parameters.Add(new SqlParameter("@name", "Cool story, Bob"));
                  commandI.Parameters.Add(new SqlParameter("@description", "none"));

                  commandI.ExecuteNonQuery(); 
                  
                  SqlCommand commandR = new SqlCommand(ReaderStories, connection);
                 try
                 {

                   SqlDataReader sqlReader = commandR.ExecuteReader();

                  try
                   {
                       while (sqlReader.Read())
                       {
                           Console.WriteLine($"ID: {sqlReader[0]}, \tName: {sqlReader[1]}," + $"  \tDesription: {sqlReader[2]}");
                       }
                   }
                   finally
                   {
                       sqlReader.Close();
                   }
                 }
                  finally
                  {
                    connection.Close();
                  }
            }

        }

    }
}
