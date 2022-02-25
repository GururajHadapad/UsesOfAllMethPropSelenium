using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Collections.ObjectModel;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.IE;

namespace SeleniumBasic.DataDrivenTesting
{
    class Database
    {
        [Test]
        public void mySql()
        {
            MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=projects;UID=root;PASSWORD=root");
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from project", connection);
            MySqlDataReader reader = command.ExecuteReader();
            // Console.WriteLine(reader.Read);
            while (reader.Read())
            {
                try
                {
                    Console.WriteLine(reader["project_name"]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }
    }
}
