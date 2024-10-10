using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using Separacao_de_Materiais.Entities.Commons;



namespace Separacao_de_Materiais.DAO
{
    public static class OrdersDAO
    {
        static string connectionstring = Connection.SetConnectionString();
        /// <summary>
        /// envia o pedido e recebe as OPS
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static List<Orders> OpsRead(int Order)
        {
            string parameter = Order.ToString();
            List<Orders> orders = new List<Orders>();
            var connection = new SqlConnection(connectionstring);
            var command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT DISTINCT" +
                " LEFT(T0.AUFTRAG, CHARINDEX('-', T0.AUFTRAG)-1) as [ORDER]," +
                " T0.BELNR_ID AS OP," +
                " T0.KNDNAME AS CLIENT" +
                " FROM" +
                " BEAS_FTHAUPT T0" +
                " JOIN" +
                " BEAS_FTSTL T1 ON T0.BELNR_ID = T1.BELNR_ID" +
                " WHERE" +
                " AUFTRAG NOT LIKE 'OP%'" +
                " AND AUFTRAG LIKE @Parameter" +
                " ORDER BY" +
                " OP";
            command.Parameters.AddWithValue(
                "@Parameter", parameter + '%');

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    orders.Add(new Orders(int.Parse(reader.GetString(0)), reader.GetInt32(1), reader.GetString(2)));
                }
                reader.Close();
                connection.Close();
            }
            return orders;
        }



        public static List<Orders> OpsDisticnt(List<int> Ops, int Order)
        {
            string parameter = Order.ToString();
            List<Orders> orders = new List<Orders>();
            var connection = new SqlConnection(connectionstring);
            var command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT DISTINCT" +
                " LEFT(T0.AUFTRAG, CHARINDEX('-', T0.AUFTRAG)-1) as [ORDER]," +
                " T0.BELNR_ID AS OP," +
                " T0.KNDNAME AS CLIENT" +
                " FROM" +
                " BEAS_FTHAUPT T0" +
                " JOIN" +
                " BEAS_FTSTL T1 ON T0.BELNR_ID = T1.BELNR_ID" +
                " WHERE" +
                " AUFTRAG NOT LIKE 'OP%'" +
                " AND AUFTRAG LIKE @Parameter" +
                " ORDER BY" +
                " OP";
            command.Parameters.AddWithValue(
                "@Parameter", parameter + '%');

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    orders.Add(new Orders(int.Parse(reader.GetString(0)), reader.GetInt32(1), reader.GetString(2)));
                }
                reader.Close();
                connection.Close();
            }
            for (int i = 0; i < orders.Count; i++)
            {
                for (int j = 0; j < Ops.Count; j++)
                {
                    if (orders[i].OP == Ops[j])
                    {
                        orders.RemoveAt(i);
                    }
                }
            }
            return orders;
        }
    }

}

