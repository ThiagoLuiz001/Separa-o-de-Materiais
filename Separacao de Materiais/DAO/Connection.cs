using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Data;

namespace Separacao_de_Materiais.DAO
{
    public class Connection
    {
        public static string SetConnectionString()
        {
            string connectionString = "";
            string jsonPath = "Connection.json";
            if (File.Exists(jsonPath))
            {
                string jsonContent = File.ReadAllText(jsonPath);
                var config = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonContent);

                if (config.TryGetValue("Data Source", out string? source) && config.TryGetValue("Initial Catalog", out string? catalog))
                {
                    string user = config["User ID"];
                    string password = config["Password"];
                    connectionString = $"Data Source ={source}; Initial Catalog={catalog}; User ID={user}; Password={password}; TrustServerCertificate=true";
                }
                else
                {
                    try
                    {
                        throw new Exception("Arquivo de configuração de conexão inválido!");
                    }
                    catch (Exception ex)
                    {
                        //realizado mudança
                        return ex.Data.ToString();
                    }
                }
            }
            else
            {
                throw new Exception("Arquivo de configuração de conexão não encontrado!");
            }
            return connectionString;
        }


        public static SqlConnection Connect()
        {
            string connectionString = SetConnectionString();
            SqlConnection connection = new(connectionString);
            return connection;
        }

        public static void Execute(SqlCommand command)
        {
            using SqlConnection connection = Connect();
            command.Connection = connection;
            command.ExecuteNonQuery();
        }

        public static SqlDataReader Read(SqlCommand command)
        {
            using SqlConnection connection = Connect();
            command.Connection = connection;
            using SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }

    }
}
