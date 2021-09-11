using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dCreador
    {
        Database db = new Database();
        public string Insertar(Creador creador)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("INSERT INTO Creador(Nombre,Apellido,Contraseña,Email," +
                    "CodigoEspecial, Inversion, Retiro, TipoCpu, TipoRam, TipoTarjetaGrafica, TiempoConexion," +
                    " NumeroTransacciones) VALUES ('{0}', '{1}', '{2}', '{3}', {4}, {5}, {6}, '{7}', {8}, '{9}',{10},{11})",
                    creador.Nombre, creador.Apellido, creador.Contraseña, creador.Email, creador.CodigoEspecial, 
                    creador.Inversion, creador.Retiro, creador.TipoCpu, creador.TipoRam, creador.TipoTarjetaGrafica, 
                    creador.TiempoConexion, creador.NumeroTransacciones);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "¡Buena suerte!";
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
        public bool Existe_email_creador(String email)
        {
            bool parametro = false;
            // 0. Declara el objeto que contendra los datos de la tabla
            Creador creador = new Creador();
            creador.Email = "";
            // 1. Me conecto con la BD
            SqlConnection con = db.ConectaDb();
            // 2. Crear la instruccion SQL

            string select = string.Format("SELECT Email FROM Creador WHERE Email = '{0}'", email);
            // 3. Creo el Command = SQL + Con
            SqlCommand cmd = new SqlCommand(select, con);
            // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
            SqlDataReader reader = cmd.ExecuteReader();
            // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
            if (reader.Read())
            {
                // 6. Instancia el objeto
                creador = new Creador();
                // 7. Transferir los datos de reader a empleo
                creador.Email = (String)reader["email"];
            }
            reader.Close();
            if (creador.Email != "")
            {
                parametro = true;
            }
            return parametro;
        }
        public bool ExisteidCreador(int idCreador)
        {
            bool parametro = false;
            // 0. Declara el objeto que contendra los datos de la tabla
            Creador creador = new Creador();
            creador.idCreador = 0;
            // 1. Me conecto con la BD
            SqlConnection con = db.ConectaDb();
            // 2. Crear la instruccion SQL

            string select = string.Format("SELECT idCreador FROM Creador WHERE idCreador = {0}", idCreador);
            // 3. Creo el Command = SQL + Con
            SqlCommand cmd = new SqlCommand(select, con);
            // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
            SqlDataReader reader = cmd.ExecuteReader();
            // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
            if (reader.Read())
            {
                // 6. Instancia el objeto
                creador = new Creador();
                // 7. Transferir los datos de reader a empleo
                creador.idCreador = (int)reader["idCreador"];
            }
            reader.Close();
            if (creador.idCreador != 0)
            {
                parametro = true;
            }
            return parametro;
        }

        public String BuscarNombre(int codigoespecial)
        {
            try
            {
                // 0. Declara el objeto que contendra los datos de la tabla
                Creador creador = new Creador();
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL

                string select = string.Format("SELECT Nombre FROM Creador WHERE CodigoEspecial = {0}", codigoespecial);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
                if (reader.Read())
                {
                    // 6. Instancia el objeto

                    // 7. Transferir los datos de reader a empleo

                    creador.Nombre = (String)reader["Nombre"];


                }
                reader.Close();
                return creador.Nombre;
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
        public String BuscarApellido(int codigoespecial)
        {
            try
            {
                // 0. Declara el objeto que contendra los datos de la tabla
                Creador creador = new Creador();
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL

                string select = string.Format("SELECT Apellido FROM Creador WHERE CodigoEspecial = {0}", codigoespecial);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
                if (reader.Read())
                {
                    // 6. Instancia el objeto

                    // 7. Transferir los datos de reader a empleo

                    creador.Apellido = (String)reader["Apellido"];


                }
                reader.Close();
                return creador.Apellido;
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
        public String BuscarTipoCpuConCodigoEspecial(int codigoespecial)
        {
            try
            {
                // 0. Declara el objeto que contendra los datos de la tabla
                Creador creador = new Creador();
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL

                string select = string.Format("SELECT TipoCpu FROM Creador WHERE CodigoEspecial = {0}", codigoespecial);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
                if (reader.Read())
                {
                    // 6. Instancia el objeto

                    // 7. Transferir los datos de reader a empleo

                    creador.TipoCpu = (String)reader["TipoCpu"];


                }
                reader.Close();
                return creador.TipoCpu;
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
        public String BuscarTipoTarjetaGraficaConCodigoEspecial(int codigoespecial)
        {
            try
            {
                // 0. Declara el objeto que contendra los datos de la tabla
                Creador creador = new Creador();
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL

                string select = string.Format("SELECT TipoTarjetaGrafica FROM Creador WHERE CodigoEspecial = {0}", codigoespecial);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
                if (reader.Read())
                {
                    // 6. Instancia el objeto

                    // 7. Transferir los datos de reader a empleo

                    creador.TipoTarjetaGrafica = (String)reader["TipoTarjetaGrafica"];


                }
                reader.Close();
                return creador.TipoTarjetaGrafica;
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
        public int BuscarTipoRamConCodigoEspecial(int codigoespecial)
        {
            try
            {
                // 0. Declara el objeto que contendra los datos de la tabla
                Creador creador = new Creador();
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL

                string select = string.Format("SELECT TipoRam FROM Creador WHERE CodigoEspecial = {0}", codigoespecial);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
                if (reader.Read())
                {
                    // 6. Instancia el objeto

                    // 7. Transferir los datos de reader a empleo

                    creador.TipoRam = (int)reader["TipoRam"];


                }
                reader.Close();
                return creador.TipoRam;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public int BuscarTiempoConexion(int codigoespecial)
        {
            try
            {
                // 0. Declara el objeto que contendra los datos de la tabla
                Creador creador = new Creador();
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL

                string select = string.Format("SELECT TiempoConexion FROM Creador WHERE CodigoEspecial = {0}", codigoespecial);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
                if (reader.Read())
                {
                    // 6. Instancia el objeto

                    // 7. Transferir los datos de reader a empleo

                    creador.TiempoConexion = (int)reader["TiempoConexion"];


                }
                reader.Close();
                return creador.TiempoConexion;
            }
            finally
            {
                db.DesconectaDb();
            }
        }

        public String BuscarEmail(int codigoespecial)
        {
            try
            {
                // 0. Declara el objeto que contendra los datos de la tabla
                Creador creador = new Creador();
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL

                string select = string.Format("SELECT Email FROM Creador WHERE CodigoEspecial = {0}", codigoespecial);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
                if (reader.Read())
                {
                    // 6. Instancia el objeto

                    // 7. Transferir los datos de reader a empleo

                    creador.Email = (String)reader["Email"];


                }
                reader.Close();
                return creador.Apellido;
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
        public String BuscarPorEmailCreador(String email)
        {
            try
            {
               
                Creador creador = new Creador();
                SqlConnection con = db.ConectaDb();
                string select = string.Format("SELECT Contraseña FROM Creador WHERE Email = '{0}'", email);
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader reader = cmd.ExecuteReader();
               
                if (reader.Read())
                {
                    creador.Contraseña = (String)reader["Contraseña"];
                }
                reader.Close();
                return creador.Contraseña;
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
        public decimal BuscarInversionConCodigoEspecial(int codigoespecial)
        {
            try
            {
                Creador creador = new Creador();
                SqlConnection con = db.ConectaDb();
                string select = string.Format("SELECT Inversion FROM Creador WHERE CodigoEspecial = {0}", codigoespecial);
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    creador.Inversion = (decimal)reader["Inversion"];
                }
                reader.Close();
                return creador.Inversion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public decimal BuscarRetiroConCodigoEspecial(int codigoespecial)
        {
            try
            {
                Creador creador = new Creador();
                SqlConnection con = db.ConectaDb();
                string select = string.Format("SELECT Retiro FROM Creador WHERE CodigoEspecial = {0}", codigoespecial);
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    creador.Retiro = (decimal)reader["Retiro"];
                }
                reader.Close();
                return creador.Retiro;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public string ModificarInversionConCodigoEspecial(decimal nuevainversion, int codigoespecial)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL


                string update = string.Format("UPDATE Creador SET Inversion= {0} WHERE CodigoEspecial= {1} ",
                    nuevainversion, codigoespecial );

                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return " Se actualizó su inversion. ";
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
        public string ModificarRetiroConCodigoEspecial(decimal nuevoretiro, int codigoespecial)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL


                string update = string.Format("UPDATE Creador SET Retiro = {0} WHERE CodigoEspecial= {1} ",
                    nuevoretiro, codigoespecial);

                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return " Se actualizó su retiro. ";
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

        public string ModificarPinConEmail(int nuevopin, string email)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL


                string update = string.Format("UPDATE Creador SET CodigoEspecial= {0} WHERE Email= '{1}' ",
                    nuevopin, email);

                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "Su pin para ingresar es: " + nuevopin;
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
        public string ModificarCodigoEspecialConCodigoEspecial(int codigoespecial1, int codigoespecial2)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL


                string update = string.Format("UPDATE Creador SET CodigoEspecial= {0} WHERE CodigoEspecial = {1} ",
                    codigoespecial1, codigoespecial2);

                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "Su nuevo pin para ingresar es: " + codigoespecial1;
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
        public string ModificarEmailConCodigoEspecial(string email, int codigoespecial)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL


                string update = string.Format("UPDATE Creador SET Email= '{0}' WHERE CodigoEspecial = {1} ",
                    email, codigoespecial);

                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return " Su email a sido modificado exitosamente. ";
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
        public bool Existe_Codigo_creador(int codigoespecial)
        {
            bool parametro = false;
            // 0. Declara el objeto que contendra los datos de la tabla
            Creador creador = new Creador();
            creador.CodigoEspecial = 0;
            // 1. Me conecto con la BD
            SqlConnection con = db.ConectaDb();
            // 2. Crear la instruccion SQL

            string select = string.Format("SELECT CodigoEspecial FROM Creador WHERE CodigoEspecial = {0}", codigoespecial);
            // 3. Creo el Command = SQL + Con
            SqlCommand cmd = new SqlCommand(select, con);
            // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
            SqlDataReader reader = cmd.ExecuteReader();
            // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
            if (reader.Read())
            {
                // 6. Instancia el objeto
                creador = new Creador();
                // 7. Transferir los datos de reader a empleo
                creador.CodigoEspecial = (int)reader["CodigoEspecial"];
            }
            reader.Close();
            if (creador.CodigoEspecial != 0)
            {
                parametro = true;
            }
            return parametro;
        }
        public int BuscarIdCreadorConCodigoEspecial(int codigoespecial)
        {
            try
            {
                // 0. Declara el objeto que contendra los datos de la tabla
                Creador creador = new Creador();
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL

                string select = string.Format("SELECT idCreador FROM Creador WHERE CodigoEspecial = {0}", codigoespecial);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
                if (reader.Read())
                {
                    // 6. Instancia el objeto

                    // 7. Transferir los datos de reader a empleo

                    creador.idCreador = (int)reader["idCreador"];


                }
                reader.Close();
                return creador.idCreador;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public string BuscarNombreConidCreador(int idCreador)
        {
            try
            {
                // 0. Declara el objeto que contendra los datos de la tabla
                Creador creador = new Creador();
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL

                string select = string.Format("SELECT Nombre FROM Creador WHERE idCreador = '{0}'",idCreador);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
                if (reader.Read())
                {
                    // 6. Instancia el objeto

                    // 7. Transferir los datos de reader a empleo

                    creador.Nombre = (string)reader["Nombre"];


                }
                reader.Close();
                return creador.Nombre;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public string ModificarNombre(Creador creador)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string update = string.Format("UPDATE Creador SET Nombre = '{0}', Apellido = '{1}' WHERE idCreador = {2}",
                    creador.Nombre, creador.Apellido, creador.idCreador);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "Se modificaron los datos de nombre y apellido.";
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
        public string ModificarTipoCpuConCodigoEspecial(string nuevocpu, int codigoespecial)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string update = string.Format("UPDATE Creador SET TipoCpu = '{0}' WHERE CodigoEspecial = {1}",
                    nuevocpu,codigoespecial);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "El modelo de su microprocesador es: ";
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
        public string ModificarTipoRamConCodigoEspecial(int nuevoram, int codigoespecial)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string update = string.Format("UPDATE Creador SET TipoRam = {0} WHERE CodigoEspecial = {1}",
                    nuevoram, codigoespecial);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "La capacidad de su ram es: ";
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
        public string ModificarTipoTarjetaGraficaConCodigoEspecial(string nuevatarjetagrafica, int codigoespecial)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string update = string.Format("UPDATE Creador SET TipoTarjetaGrafica = '{0}' WHERE CodigoEspecial = {1}",
                    nuevatarjetagrafica, codigoespecial);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "Su nueva tarjeta gráfica es: ";
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
        public string ModificarTiempoConexionConCodigoEspecial(int nuevotiempoconexion, int codigoespecial)
        {
            try
            {
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL
                string update = string.Format("UPDATE Creador SET TiempoConexion = {0} WHERE CodigoEspecial = {1}",
                    nuevotiempoconexion, codigoespecial);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return " Y su tiempo de conexion ahora es: ";
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
        
        public int BuscarCodigoEspecialConEmail(string email)
        {
            try
            {
                // 0. Declara el objeto que contendra los datos de la tabla
                Creador creador = new Creador();
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL

                string select = string.Format("SELECT CodigoEspecial FROM Creador WHERE Email = '{0}'", email);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
                if (reader.Read())
                {
                    // 6. Instancia el objeto

                    // 7. Transferir los datos de reader a empleo

                    creador.CodigoEspecial = (int)reader["CodigoEspecial"];


                }
                reader.Close();
                return creador.CodigoEspecial;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public string BuscarContraseñaConCodigoEspecial(int codigoespecial)
        {
            try
            {
                // 0. Declara el objeto que contendra los datos de la tabla
                Creador creador = new Creador();
                // 1. Me conecto con la BD
                SqlConnection con = db.ConectaDb();
                // 2. Crear la instruccion SQL

                string select = string.Format("SELECT Contraseña FROM Creador WHERE CodigoEspecial = {0}", codigoespecial);
                // 3. Creo el Command = SQL + Con
                SqlCommand cmd = new SqlCommand(select, con);
                // 4. Ejecuto un ExecuteReader y el resultado lo guardo en reader
                SqlDataReader reader = cmd.ExecuteReader();
                // 5. Extraer del objeto reader los datos .Read() hacia el objeto empleo
                if (reader.Read())
                {
                    // 6. Instancia el objeto

                    // 7. Transferir los datos de reader a empleo

                    creador.Contraseña = (String)reader["Contraseña"];


                }
                reader.Close();
                return creador.Contraseña;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
    }
}
