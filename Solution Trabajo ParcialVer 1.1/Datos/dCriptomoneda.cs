using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dCriptomoneda
    {
        Database db = new Database();
        public string Insertar(Criptomoneda criptomoneda)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string insert = string.Format("INSERT INTO Criptomoneda(Nombre,Cantidad,Valor,idCreador,InversionSeguridad,InversionPublicidad,Status,Mes,Año) VALUES ('{0}', {1}, {2}, {3}, {4},{5},{6},{7},{8})",
                   criptomoneda.Nombre,criptomoneda.Cantidad,criptomoneda.Valor,criptomoneda.idCreador,criptomoneda.InversionSeguridad,criptomoneda.InversionPublicidad,criptomoneda.Status,criptomoneda.Mes,criptomoneda.Año);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(insert, con);
                // 4. Ejecuto
                cmd.ExecuteNonQuery();
                return "Haz minado por primera vez y se creó tu criptomoneda. ¡Felicidades!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                // SIEMPRE SE VA A EJECUTAR=EXITO O FRACASO
                db.DesconectaDb();
            }
        }
        public bool ExisteNombreCriptomoneda(String nombrecriptomoneda)
        {
            bool parametro = false;
            // 0. Declara el objeto que contendra los datos de la tabla
            Criptomoneda criptomoneda = new Criptomoneda();
            criptomoneda.Nombre = "";
            // 1. Me conecto con la BD
            SqlConnection con = db.ConectaDb();
            // 2. Crear la instruccion SQL

            string select = string.Format("SELECT Nombre FROM Criptomoneda WHERE Nombre = '{0}'", nombrecriptomoneda);
            // 3. Creo el Command = SQL + Con
            SqlCommand cmd = new SqlCommand(select, con);
            // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
            SqlDataReader reader = cmd.ExecuteReader();
            // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
            if (reader.Read())
            {
                // 6. Instancia el objeto
                criptomoneda = new Criptomoneda();
                // 7. Transferir los datos de reader a empleo
                criptomoneda.Nombre = (String)reader["Nombre"];
            }
            reader.Close();
            if (criptomoneda.Nombre != "")
            {
                parametro = true;
            }
            return parametro;
        }
        public List<Criptomoneda> ListarCriptomonedaDelCreador(int idcreador)
        {
            try
            {
                // 0. Declara los objetos que contendra los datos de la tabla
                List<Criptomoneda> criptomonedas = new List<Criptomoneda>();
                Criptomoneda criptomoneda = null;
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string select = string.Format("SELECT idCriptomoneda,Nombre,Cantidad,Valor,idCreador,InversionSeguridad,InversionPublicidad,Status,Mes,Año FROM Criptomoneda Where idCreador = {0}", idcreador);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos con .Read() hacia el objeto empleo
                while (reader.Read())
                {
                    // 6. Instancia el objeto
                    criptomoneda = new Criptomoneda();
                    // 7. Transferir los datos de reader a empleo
                    criptomoneda.idCriptomoneda = (int)reader["idCriptomoneda"];
                    criptomoneda.Nombre = (String)reader["Nombre"];
                    criptomoneda.Cantidad = (decimal)reader["Cantidad"];
                    criptomoneda.Valor = (decimal)reader["Valor"];
                    criptomoneda.idCreador = (int)reader["idCreador"];
                    criptomoneda.InversionSeguridad = (decimal)reader["InversionSeguridad"];
                    criptomoneda.InversionPublicidad = (decimal)reader["InversionPublicidad"];
                    criptomoneda.Mes = (int)reader["Mes"];
                    criptomoneda.Año = (int)reader["Año"];
                    
                    // 8. Agregar el objeto empleo a List de empleos
                    criptomonedas.Add(criptomoneda);
                }
                reader.Close();
                return criptomonedas;
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
        public List<Criptomoneda> ListarTodo()
        {
            try
            {
                // 0. Declara los objetos que contendra los datos de la tabla
                List<Criptomoneda> criptomonedas = new List<Criptomoneda>();
                Criptomoneda criptomoneda = null;
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string select = "SELECT idCriptomoneda,Nombre,Cantidad, Valor, idCreador, InversionSeguridad, InversionPublicidad FROM Criptomoneda";
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos con .Read() hacia el objeto empleo
                while (reader.Read())
                {
                    // 6. Instancia el objeto
                    criptomoneda = new Criptomoneda();
                    // 7. Transferir los datos de reader a empleo
                    criptomoneda.idCriptomoneda = (int)reader["idCriptomoneda"];
                    criptomoneda.Nombre = (String)reader["Nombre"];
                    criptomoneda.Cantidad = (decimal)reader["Cantidad"];
                    criptomoneda.Valor = (decimal)reader["Valor"];
                    criptomoneda.idCreador = (int)reader["idCreador"];
                    criptomoneda.InversionSeguridad = (decimal)reader["InversionSeguridad"];
                    criptomoneda.InversionPublicidad = (decimal)reader["InversionPublicidad"];


                    // 8. Agregar el objeto empleo a List de empleos
                    criptomonedas.Add(criptomoneda);
                    
                }
                reader.Close();
                return criptomonedas;
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
        public string ModificarInversionPublicidad(Criptomoneda criptomoneda)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string update = string.Format("UPDATE Criptomoneda SET InversionPublicidad = {0} WHERE idCriptomoneda = {1}",
                    criptomoneda.InversionPublicidad, criptomoneda.idCriptomoneda);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "Se agregó el monto a publicidad";
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
        public string ModificarInversionSeguridad(Criptomoneda criptomoneda)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string update = string.Format("UPDATE Criptomoneda SET InversionSeguridad = {0} WHERE idCriptomoneda = {1}",
                    criptomoneda.InversionSeguridad, criptomoneda.idCriptomoneda);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "Se agregó el monto a seguridad.";
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
        public decimal BuscarInversionSeguridadConidCriptomoneda(int idCriptomoneda)
        {
            try
            {
                // 0. Declara el objeto que contendra los datos de la tabla
                Criptomoneda criptomoneda = new Criptomoneda();
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL

                string select = string.Format("SELECT InversionSeguridad FROM Criptomoneda WHERE idCriptomoneda = {0}", idCriptomoneda);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
                if (reader.Read())
                {
                    // 6. Instancia el objeto

                    // 7. Transferir los datos de reader a empleo

                    criptomoneda.InversionSeguridad = (decimal)reader["InvserionSeguridad"];


                }
                reader.Close();
                return criptomoneda.InversionSeguridad;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public decimal BuscarInversionPublicidadConidCriptomoneda(int idCriptomoneda)
        {
            try
            {
                // 0. Declara el objeto que contendra los datos de la tabla
                Criptomoneda criptomoneda = new Criptomoneda();
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL

                string select = string.Format("SELECT InversionPublicidad FROM Criptomoneda WHERE idCriptomoneda = {0}", idCriptomoneda);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
                if (reader.Read())
                {
                    // 6. Instancia el objeto

                    // 7. Transferir los datos de reader a empleo

                    criptomoneda.InversionPublicidad = (decimal)reader["InvserionPublicidad"];


                }
                reader.Close();
                return criptomoneda.InversionPublicidad;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public int BuscaridCriptomonedaConNombre(String nombre)
        {
            try
            {
                // 0. Declara el objeto que contendra los datos de la tabla
                Criptomoneda criptomoneda = new Criptomoneda();
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL

                string select = string.Format("SELECT idCriptomoneda FROM Criptomoneda WHERE Nombre = '{0}'", nombre);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
                if (reader.Read())
                {
                    // 6. Instancia el objeto

                    // 7. Transferir los datos de reader a empleo

                    criptomoneda.idCriptomoneda = (int)reader["idCriptomoneda"];


                }
                reader.Close();
                return criptomoneda.idCriptomoneda ;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public decimal BuscarValorConNombreCriptomoneda(String nombrecriptomoneda)
        {
            try
            {
                // 0. Declara el objeto que contendra los datos de la tabla
                Criptomoneda criptomoneda = new Criptomoneda();
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL

                string select = string.Format("SELECT Valor FROM Criptomoneda WHERE Nombre = '{0}'", nombrecriptomoneda);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
                if (reader.Read())
                {
                    // 6. Instancia el objeto

                    // 7. Transferir los datos de reader a empleo

                    criptomoneda.Valor = (decimal)reader["Valor"];


                }
                reader.Close();
                return criptomoneda.Valor;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public decimal BuscarCantidadConNombreCriptomoneda(String nombrecriptomoneda)
        {
            try
            {
                // 0. Declara el objeto que contendra los datos de la tabla
                Criptomoneda criptomoneda = new Criptomoneda();
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL

                string select = string.Format("SELECT Cantidad FROM Criptomoneda WHERE Nombre = '{0}'", nombrecriptomoneda);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
                if (reader.Read())
                {
                    // 6. Instancia el objeto

                    // 7. Transferir los datos de reader a empleo

                    criptomoneda.Cantidad = (decimal)reader["Cantidad"];


                }
                reader.Close();
                return criptomoneda.Cantidad;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public int BuscarMesConidCriptomoneda(int idCriptomoneda)
        {
            try
            {
                // 0. Declara el objeto que contendra los datos de la tabla
                Criptomoneda criptomoneda = new Criptomoneda();
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL

                string select = string.Format("SELECT Mes FROM Criptomoneda WHERE idCriptomoneda = {0}", idCriptomoneda);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
                if (reader.Read())
                {
                    // 6. Instancia el objeto

                    // 7. Transferir los datos de reader a empleo

                    criptomoneda.Mes = (int)reader["Mes"];


                }
                reader.Close();
                return criptomoneda.Mes;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public int BuscarAñoConidCriptomoneda(int idCriptomoneda)
        {
            try
            {
                // 0. Declara el objeto que contendra los datos de la tabla
                Criptomoneda criptomoneda = new Criptomoneda();
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL

                string select = string.Format("SELECT Año FROM Criptomoneda WHERE idCriptomoneda = {0}", idCriptomoneda);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
                if (reader.Read())
                {
                    // 6. Instancia el objeto

                    // 7. Transferir los datos de reader a empleo

                    criptomoneda.Año = (int)reader["Año"];


                }
                reader.Close();
                return criptomoneda.Año;
            }
            finally
            {
                db.DesconectaDb();
            }
        }

        public string ModificarCantidadCriptomoneda(decimal nuevacontidad, string nombrecriptomoneda)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string update = string.Format("UPDATE Criptomoneda SET Cantidad = {0} WHERE Nombre = '{1}'",
                    nuevacontidad, nombrecriptomoneda);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "¡Felicidades! ¡Usted a minado " + nuevacontidad + " en este momento. ";
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
        
        public string ModificarMesCriptomonedaConidCriptomoneda(int nuevoMes, int NuevoAño , int idCriptomoneda)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string update = string.Format("UPDATE Criptomoneda SET Mes = {0}, Año = {1} WHERE idCriptomoneda = {2}",
                    nuevoMes, NuevoAño, idCriptomoneda);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return " Se actualizó el mes y año. ";
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
        public string ModificarValorCriptomonedaConidCriptomoneda(decimal nuevoValor, int idCriptomoneda)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string update = string.Format("UPDATE Criptomoneda SET Valor = {0} WHERE idCriptomoneda = {1}",
                     nuevoValor, idCriptomoneda);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return " Se actualizó valor de la criptomoneda. ";
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

    }
}
