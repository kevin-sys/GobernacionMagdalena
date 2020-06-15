﻿using System;
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
        private string ruta = @"Recaudo.txt";
        private List<Recaudo> recaudos;
        private readonly SqlConnection _connection;
        public RecaudoRepository(ConnectionManager connection)
        {
            recaudos = new List<Recaudo>();

            _connection = connection._conexion;
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


       
        public List<Recaudo> Consultar()
        {
            recaudos.Clear();
            FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(fileStream);
            string linea = string.Empty;
            while ((linea = streamReader.ReadLine()) != null)
            {
                Recaudo recaudo = new Recaudo();
                string[] datos = linea.Split(';');
                recaudo.NitAgenteRecaudador = datos[0];
                    recaudo.MesReporte = int.Parse(datos[1]);
                    recaudo.AñoReporte = int.Parse(datos[2]);
                    recaudo.TipoEstampilla = datos[3];
                    recaudo.ValorImpuesto = decimal.Parse(datos[4]);
                    recaudo.IdentificacionContratista = datos[5];
                    recaudo.NombreContratista = datos[6];
                recaudos.Add(recaudo);
            }
            fileStream.Close();
            streamReader.Close();
            return recaudos;
        }
       

        public Recaudo Buscar(string nit)
        {
            recaudos.Clear();
            recaudos = Consultar();
            foreach (var item in recaudos)
            {
                if (item.NitAgenteRecaudador.Equals(nit))
                {
                    return item;
                }
            }
            return null;
        }
    }
}


