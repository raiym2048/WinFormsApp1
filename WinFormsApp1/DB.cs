﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace WinFormsApp1
{
    public partial class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=8889;username=root;password=root;database=bd;SSL Mode=None");
        public static List<string> cardName = new List<string>();
        public static List<string> cardID = new List<string>();
        public static List<string> blnc = new List<string>();



        public static int usId;
        public int getUsId() { 
            return usId;
        }
        public DB() { }
    
        public void userIdSelect(string uL)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            string sql = "SELECT id FROM users where email = @uL";
            cmd.Parameters.Add("@uL", MySqlDbType.VarChar).Value = uL;

            cmd.CommandText = sql;
            
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {


                       usId = (Convert.ToInt32(reader.GetValue(0)));
                        
                    }
                }
            }


            MySqlCommand cmd2 = connection.CreateCommand();
            string sql2 = "SELECT * FROM cards where id = @iD";
            cmd2.Parameters.Add("@iD", MySqlDbType.VarChar).Value = usId;

            cmd2.CommandText = sql2;
            
            using (DbDataReader reader = cmd2.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        cardID.Add(reader.GetValue(1).ToString());
                        cardName.Add(reader.GetValue(2).ToString());
                        blnc.Add(reader.GetValue(3).ToString());
                        

                    }
                }
            }  
           
           
        }
        public void ClearLists()
        {
            cardID.Clear();
            cardName.Clear();
            blnc.Clear();

        }
        public void RefreshDatabase()
        {
            connection.Open();
            MySqlCommand cmd2 = connection.CreateCommand();
            string sql2 = "SELECT * FROM cards where id = @iD";
            cmd2.Parameters.Add("@iD", MySqlDbType.VarChar).Value = usId;

            cmd2.CommandText = sql2;

            using (DbDataReader reader = cmd2.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        cardID.Add(reader.GetValue(1).ToString());
                        cardName.Add(reader.GetValue(2).ToString());
                        blnc.Add(reader.GetValue(3).ToString());


                    }
                }
            }
        }


       
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();


            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public List<string> getCarId()
        {
            return cardID;
        }
        public List<string> getCarName()
        {
            return cardName;
        }
        public List<string> getBalance()
        {
            return blnc;
        }


        public MySqlConnection getConnection()
        {
            return connection;
        }
    }

    class Database
    {
    }
}
