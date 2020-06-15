using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;
using DAL;

namespace BLL
{
    public class RecaudoService
    {
        private readonly ConnectionManager conexion;
        private readonly RecaudoRepository repository;
        List<Recaudo> recaudos;
        public RecaudoService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repository = new RecaudoRepository(conexion);
        }

        public string GuardarArchivoPlano()
        {
            try
            {
                conexion.Open();
                repository.GuardarArchivoPlano();
                conexion.Close();
                return $"Se exporto el archivo a la BASE DE DATOS CON EXITO";


            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }

        }
        public Recaudo Buscar(string nit)
        {
            try
            {
                return repository.Buscar(nit);
            }
            catch (Exception e)
            {
                string mensaje = " ERROR" + e.Message;
                return null;
            }
        }
        public decimal ValorTotalAdultoMayor()
        {
            return repository.ValorTotalAdultoMayor();
        }
        public List<Recaudo> ConsultarTodos()
        {
            conexion.Open();
            recaudos = new List<Recaudo>();
            recaudos = repository.ConsultarTodos();
            conexion.Close();
            return recaudos;
        }

    }
}
