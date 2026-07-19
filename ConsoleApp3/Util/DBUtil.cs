using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Configuration;
using ConsoleApp3.Entity;

namespace ConsoleApp3.Util
{
    internal class DBUtil
    {
        SqlConnection conn = null;

        public void ConnectToDatabase()
        {
          /*  string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                conn.Open();
                Console.WriteLine("接続成功");
                this.conn = conn;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("接続失敗: " + ex.Message);
            }*/
        }

        public void Insert(string table, string[] cols, List<Word> words)
        {
            string colstring = string.Join(", ", cols);
            string[] values = cols.Select(s => '@' + s).ToArray();
            string valuestring = string.Join(",", values);

            string sql = $"INSERT INTO {table} ({colstring}) VALUES ({valuestring})";

            using (SqlCommand cmd = new SqlCommand(sql, this.conn))
            {
                foreach (Word word in words)
                {

                    //これをしないと繰り返しにははじかれてしまう
                    cmd.Parameters.Clear();

                    try
                    {
                        cmd.Parameters.AddWithValue("@Quote", word.quote);
                        cmd.Parameters.AddWithValue("@Author", word.author);
                        cmd.Parameters.AddWithValue("@Tags", string.Join(",", word.tags));


                        int rows = cmd.ExecuteNonQuery();
                        Console.WriteLine($"{rows}件登録しました");
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("登録失敗: " + ex.Message);
                    }
                }
            }
        }


    }
}
