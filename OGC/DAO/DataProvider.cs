﻿using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OGC.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;


        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        string connectionSTR = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=OGCCinema1;Integrated Security=True;Trust Server Certificate=True;";
        //Data Source=CAKE;Initial Catalog=OGCCinema;Integrated Security=True;Trust Server Certificate=True
        //Data Source=MSI\SQLEXPRESS;Initial Catalog=OGCCinema1;Integrated Security=True;Trust Server Certificate=True


        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand comand = new SqlCommand(query, connection);


                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            comand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }

                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(comand);

                try
                {
                    adapter.Fill(data); // Kiểm tra xem có lỗi tại đây không
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                }

                connection.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))// kết nối từ client xuống server,
                                                                               // sử dụng using để khi kết thúc khối lệnh thì
                                                                               // auto ngắt kết nối tránh lỗi
            {

                connection.Open();// phải mở connection để có thể thực hiện tác vụ

                SqlCommand command = new SqlCommand(query, connection);// câu truy vấn sẽ thực thi 

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close(); // mở ra phải đóng lại để tránh nhiều dữ liệu đổ vào bị lỗi
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand comand = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            comand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }

                    }
                }
                data = comand.ExecuteScalar();
                connection.Close();
            }
            return data;
        }

        public int NHN_ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                // Kiểm tra xem có parameter và query có chứa @Username không
                if (parameter != null && parameter.Length > 0 && query.Contains("@Username"))
                {
                    command.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar)
                    {
                        Value = parameter[0] ?? DBNull.Value // Xử lý null value
                    });
                }

                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public DataTable NHN_ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand comand = new SqlCommand(query, connection);


                if (parameter != null)
                {
                    var matches = System.Text.RegularExpressions.Regex.Matches(query, @"@\w+");
                    int i = 0;

                    foreach (System.Text.RegularExpressions.Match match in matches)
                    {
                        string paramName = match.Value;

                        // Tránh trùng tên
                        if (!comand.Parameters.Contains(paramName) && i < parameter.Length)
                        {
                            comand.Parameters.AddWithValue(paramName, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(comand);

                try
                {
                    adapter.Fill(data); // Kiểm tra xem có lỗi tại đây không
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                }

                connection.Close();
            }
            return data;
        }
    }
}
