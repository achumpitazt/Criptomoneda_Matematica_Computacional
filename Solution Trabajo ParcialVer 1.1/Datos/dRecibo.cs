using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dRecibo
    {
        Database db = new Database();
        public string Insertar(Recibo recibo)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = string.Format(" INSERT INTO Recibo( idEmisor, NombreEmisor, idDestinatario,NombreDestinatario, Motivo, Cantidad, NombreCriptomoneda) VALUES ({0}, '{1}', {2}, '{3}', '{4}', {5}, '{6}') ",
                    recibo.idEmisor, recibo.NombreEmisor, recibo.idDestinatario, recibo.NombreDestinantario, recibo.Motivo, recibo.Cantidad, recibo.NombreCriptomoneda);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return " Se registró un recibo. ";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public List<Recibo> ListarReciboDelCreador(int idemisor)
        {
            try
            {
                // 0. Declara los objetos que contendra los datos de la tabla
                List<Recibo> recibos = new List<Recibo>();
                Recibo recibo = null;
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string select = string.Format("SELECT idEmisor, NombreEmisor, idDestinatario, NombreDestinatario, Motivo, Cantidad, NombreCriptomoneda FROM Recibo Where idEmisor = {0} ", idemisor);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos con .Read() hacia el objeto empleo
                while (reader.Read())
                {
                    // 6. Instancia el objeto
                    recibo = new Recibo();

                    // 7. Transferir los datos de reader a empleo
                    recibo.idEmisor = (int)reader["idEmisor"];
                    recibo.NombreEmisor = (string)reader["NombreEmisor"];
                    recibo.idDestinatario = (int)reader["idDestinatario"];
                    recibo.NombreDestinantario = (string)reader["NombreDestinatario"];
                    recibo.Motivo = (string)reader["Motivo"];
                    recibo.Cantidad = (decimal)reader["Cantidad"];
                    recibo.NombreCriptomoneda = (string)reader["NombreCriptomoneda"];
                   

                    // 8. Agregar el objeto empleo a List de empleos
                    recibos.Add(recibo);
                }
                reader.Close();
                return recibos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public List<Recibo> ListarDestinatarioDelCreador(int iddestinanario)
        {
            try
            {
                // 0. Declara los objetos que contendra los datos de la tabla
                List<Recibo> recibos = new List<Recibo>();
                Recibo recibo = null;
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string select = string.Format("SELECT idEmisor, NombreEmisor, idDestinatario, NombreDestinatario, Motivo, Cantidad, NombreCriptomoneda FROM Recibo Where idDestinatario = {0} ", iddestinanario);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos con .Read() hacia el objeto empleo
                while (reader.Read())
                {
                    // 6. Instancia el objeto
                    recibo = new Recibo();

                    // 7. Transferir los datos de reader a empleo
                    recibo.idEmisor = (int)reader["idEmisor"];
                    recibo.NombreEmisor = (string)reader["NombreEmisor"];
                    recibo.idDestinatario = (int)reader["idDestinatario"];
                    recibo.NombreDestinantario = (string)reader["NombreDestinatario"];
                    recibo.Motivo = (string)reader["Motivo"];
                    recibo.Cantidad = (decimal)reader["Cantidad"];
                    recibo.NombreCriptomoneda = (string)reader["NombreCriptomoneda"];


                    // 8. Agregar el objeto empleo a List de empleos
                    recibos.Add(recibo);
                }
                reader.Close();
                return recibos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                db.DesconectaDb();
            }
        }

    }
}
