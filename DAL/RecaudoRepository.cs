using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using Entity;
namespace DAL
{
    public class RecaudoRepository
    {
        public List<Recaudo> recaudos = new List<Recaudo>();
        private readonly SqlConnection _connection;
        public RecaudoRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
            recaudos = new List<Recaudo>();
        }

        public void GuardarArchivoPlano()
        {


            using (var command = _connection.CreateCommand())
            {

                command.CommandText = "BULK INSERT Recaudo FROM 'C:\\Users\\Gomez\\source\\repos\\Gobernacion del Magdalena\\Recaudo.txt' WITH (FIELDTERMINATOR = ';' , ROWTERMINATOR = '\n')";
                command.CommandType = CommandType.Text;

                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }

        }

    }
    

}
