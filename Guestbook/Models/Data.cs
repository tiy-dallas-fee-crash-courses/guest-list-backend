using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Guestbook.Models
{
    public static class Data
    {
        private const string _CONNECTION_STRING = @"Server=.\SQL2012;Database=Guestbook;Trusted_Connection=True;";

        public static List<Entry> List()
        {
            var entries = new List<Entry>();

            using (var conn = new SqlConnection(_CONNECTION_STRING))
            {
                using (var cmd = new SqlCommand("SELECT FirstName, LastName FROM PersonList", conn))
                {
                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var entry = new Entry();
                        entry.FirstName = reader["FirstName"].ToString();
                        entry.LastName = reader["LastName"].ToString();

                        entries.Add(entry);
                    }
                }
            }

            return entries;
        }

        public static void Add(string firstName, string lastName)
        {
            using (var conn = new SqlConnection(_CONNECTION_STRING))
            {
                using (var cmd = new SqlCommand("INSERT INTO PersonList (FirstName, LastName, TimeOfSignIn) VALUES (@firstName, @lastName, getdate())", conn))
                {
                    var firstNameParam = new SqlParameter("@firstName", firstName);
                    firstNameParam.Value = firstName;

                    var lastNameParam = new SqlParameter("@lastName", lastName);
                    lastNameParam.Value = lastName;

                    cmd.Parameters.Add(firstNameParam);
                    cmd.Parameters.Add(lastNameParam);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}