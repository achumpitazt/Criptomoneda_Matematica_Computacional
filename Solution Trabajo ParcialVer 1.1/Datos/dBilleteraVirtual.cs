using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class dBilleteraVirtual
    {
        Database db = new Database();
        public string Insertar(BilleteraVirtual billeteravirtual)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string insert = string.Format("INSERT INTO BilleteraVirtual(idCreador, Nombre, Cantidad, Minado) VALUES ({0}, '{1}', {2}, {3})",
                    billeteravirtual.idCreador,billeteravirtual.Nombre,billeteravirtual.Cantidad, billeteravirtual.Minado);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(insert, con);
                // 4. Ejecuto
                cmd.ExecuteNonQuery();
                return "Y se insertó en tu billetera";
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
        public string Insertar2(int idCreador, string Nombre, decimal Cantidad, int Minado)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string insert = string.Format("INSERT INTO BilleteraVirtual(idCreador, Nombre, Cantidad, Minado) VALUES ({0}, '{1}', {2}, {3})",
                    idCreador,Nombre, Cantidad, Minado);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(insert, con);
                // 4. Ejecuto
                cmd.ExecuteNonQuery();
                return "Se registró la criptomoneda en la cuenta del destinatario. ";
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
        public List<BilleteraVirtual> ListarBillteraConidCreador(int idCreador)
        {
            try
            {
                // 0. Declara los objetos que contendra los datos de la tabla
                List<BilleteraVirtual> billeteraVirtuales = new List<BilleteraVirtual>();
                BilleteraVirtual billeteraVirtual = null;
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string select = string.Format("SELECT idCreador, Nombre, Cantidad, Minado FROM BilleteraVirtual Where idCreador = {0}", idCreador);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos con .Read() hacia el objeto empleo
                while (reader.Read())
                {
                    // 6. Instancia el objeto
                    billeteraVirtual = new BilleteraVirtual();
                    // 7. Transferir los datos de reader a empleo
                    billeteraVirtual.idCreador = (int)reader["idCreador"];
                    billeteraVirtual.Nombre = (string)reader["Nombre"];
                    billeteraVirtual.Cantidad = (decimal)reader["Cantidad"];
                    billeteraVirtual.Minado = (int)reader["Minado"];
                    
                    // 8. Agregar el objeto empleo a List de empleos
                    billeteraVirtuales.Add(billeteraVirtual);
                }
                reader.Close();
                return billeteraVirtuales;
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
        public string ModificarCantidadBilltera(decimal nuevacontidad, int idCreador,string nombrecriptomoneda)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string update = string.Format("UPDATE BilleteraVirtual SET Cantidad = {0} WHERE idCreador = {1} AND Nombre = '{2}'",
                    nuevacontidad,idCreador,nombrecriptomoneda);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "¡Felicidades! ¡Usted a minado: ";
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
        public string ModificarCantidadBillteraDeposito(decimal nuevacontidad, int idCreador, string nombrecriptomoneda)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string update = string.Format("UPDATE BilleteraVirtual SET Cantidad = {0} WHERE idCreador = {1} AND Nombre = '{2}'",
                    nuevacontidad, idCreador, nombrecriptomoneda);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return " Se depositó el monto seleccionado. ";
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
        public decimal BuscarCantidadConidCreadorBilltera(string nombrecriptomoneda, int idCreador)
        {
            try
            {
                // 0. Declara el objeto que contendra los datos de la tabla
                BilleteraVirtual billeteraVirtual = new BilleteraVirtual();
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL

                string select = string.Format("SELECT Cantidad FROM BilleteraVirtual WHERE Nombre = '{0}' AND idCreador = {1}",nombrecriptomoneda, idCreador);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
                if (reader.Read())
                {
                    // 6. Instancia el objeto

                    // 7. Transferir los datos de reader a empleo

                    billeteraVirtual.Cantidad = (decimal)reader["Cantidad"];


                }
                reader.Close();
                return billeteraVirtual.Cantidad;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public string ModificarMinadoBilltera(int nuevominado, int idCreador, string nombrecriptomoneda)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string update = string.Format("UPDATE BilleteraVirtual SET Minado = {0} WHERE idCreador = {1} AND Nombre = '{2}'",
                    nuevominado, idCreador, nombrecriptomoneda);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return " No podrá minar esta criptomoneda por un mes. ";
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
        public string ModificarMinadoParaTodos(int nuevominado, string nombrecriptomoneda)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string update = string.Format("UPDATE BilleteraVirtual SET Minado = {0} WHERE Nombre = '{1}'",
                    nuevominado, nombrecriptomoneda);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return " Se fue la reestricción. Ahora pueden empezar a minar esta criptomoneda por este mes. ";
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
        
        public bool ExisteCriptomonedaEnBilltera(string nombre, int idCreador)
        {
            bool parametro = false;
            // 0. Declara el objeto que contendra los datos de la tabla
            BilleteraVirtual billeteraVirtual = new BilleteraVirtual();
            billeteraVirtual.Nombre = " ";
            
            // 1. Me conecto con la BD
            SqlConnection con = db.ConectaDb();
            // 2. Crear la instruccion SQL

            string select = string.Format("SELECT Nombre FROM BilleteraVirtual WHERE Nombre = '{0}' AND idCreador = {1}", nombre, idCreador);
            // 3. Creo el Command = SQL + Con
            SqlCommand cmd = new SqlCommand(select, con);
            // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
            SqlDataReader reader = cmd.ExecuteReader();
            // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
            if (reader.Read())
            {
                // 6. Instancia el objeto
                billeteraVirtual = new BilleteraVirtual();
                // 7. Transferir los datos de reader a empleo
                billeteraVirtual.Nombre = (string)reader["Nombre"];
            }
            reader.Close();
            if (billeteraVirtual.Nombre != " ")
            {
                parametro = true;
            }
            return parametro;
        }


    }
    
}
