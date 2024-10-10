using Separacao_de_Materiais.Entities.Exceptions;
using System.Data;
using Microsoft.Data.SqlClient;
using Separacao_de_Materiais.Entities.Commons;
namespace Separacao_de_Materiais.DAO
{
    public static class ItensDAO
    {
        static string connectionstring = Connection.SetConnectionString();
        
        public static List<Itens> ItensRead(Orders order)
        {
            List<Itens> itens = new List<Itens>();
            var connection = new SqlConnection(connectionstring);
            var command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandType = CommandType.Text;
            command.CommandText = "select " +
                "t0.belnr_id as 'Nº op', " +
                "t0.belpos_id as 'Posição', " +
                "t0.Art1_id as 'código do item', " +
                "t0.itemname as 'descrição do item', " +
                "sum (t0.totalquantity_whunit) as 'qtd planejada', " +
                "t0.input_unit as 'unidade', " +
                "t3.ItmsGrpCod " +
                "from " +
                "BEAS_FTSTL t0 " +
                "join " +
                "OITM t2 on t2.ItemCode = t0.ART1_ID " +
                "join " +
                "OITB t3 on t2.ItmsGrpCod = t3.ItmsGrpCod " +
                "where " +
                "t0.belnr_id = @Op " +
                "and  T2.itmsGrpCod  in(107, 110, 113, 115) " +
                "GROUP BY " +
                "t0.belnr_id," +
                "t0.belpos_id," +
                "t0.Art1_id , " +
                "t0.itemname, " +
                "t0.input_unit, " +
                "t3.ItmsGrpCod";
            command.Parameters.AddWithValue("@Op", order.OP);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    try
                    {
                        itens.Add(new Itens(Convert.ToInt32(reader.GetValue(2)), reader.GetString(3), Convert.ToInt32(reader.GetValue(6)), Convert.ToDouble(reader.GetValue(4)), reader.GetString(5)));
                        
                    }
                    catch(Exception e)
                    {
                        throw new ExceptionsGroup($"({DateTime.Now}) Erro da OP {order.OP}: {e} ");
                    }
                }
                reader.Close();
                connection.Close();
            }

            return itens;

        }
    }
}
