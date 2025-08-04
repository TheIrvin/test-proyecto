using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    internal class conexion_bdbd
    {
        // Variables de conexión y comandos
        public SqlConnection oCon; // Usar este en vez de 'conex' para compatibilidad
        public SqlCommand oCom;
        public SqlDataReader oDR;
        public SqlDataAdapter oDA;
        public DataTable oDT;

        private string server;
        private string basededatos;
        private string usuario;
        private string contrasena;
        private string Cadena;

        public SqlConnection conexion_BBD
        {
            get { return oCon; } // Cambiado de 'conex' a 'oCon' para compatibilidad
        }

        // Constructor por defecto
        public conexion_bdbd()
        {
            Server = "THEIRVIN\\SQLEXPRESS02";
            BaseDeDatos = "Tienda-Virtual";
            Usuario = "Tienda";
            Contrasena = "12345";
            oCon = new SqlConnection();
            Cadena = $"Server={Server}; Database={BaseDeDatos}; User id={Usuario}; Password={Contrasena}";
            oCon.ConnectionString = Cadena;
        }

        // Constructor con parámetros
        public conexion_bdbd(string Server, string BaseDeDatos, string Usuario, string Contrasena)
        {
            this.Server = Server;
            this.basededatos = BaseDeDatos;
            this.usuario = Usuario;
            this.contrasena = Contrasena;
            oCon = new SqlConnection();
            Cadena = $"Server={Server}; Database={BaseDeDatos}; User id={Usuario}; Password={Contrasena}";
            oCon.ConnectionString = Cadena;
        }

        public string Server
        {
            get { return server; }
            set { server = value; }
        }

        public string BaseDeDatos
        {
            get { return basededatos; }
            set { basededatos = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        // Métodos para abrir y cerrar la conexión
        public bool abrirConexion()
        {
            try
            {
                if (oCon.State != ConnectionState.Open)
                {
                    oCon.Open();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE HA CONECTADO DE MANERA CORRECTA A LA BASE DE DATOS, VUELVA A INTENTARLO");
                return false;
            }
            return true;
        }

        public bool cerrarConexion()
        {
            try
            {
                if (oCon.State == ConnectionState.Open)
                {
                    oCon.Close();
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool AbrirCerrarConexion() // Mantengo este método por compatibilidad
        {
            try
            {
                if (oCon.State == ConnectionState.Open)
                {
                    oCon.Close();
                }
                else
                {
                    oCon.Open();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE HA CONECTADO DE MANERA CORRECTA A LA BASE DE DATOS, VUELVA A INTENTARLO");
                return false;
            }
            return true;
        }

        public bool ProbarConexion()
        {
            try
            {
                oCon.Open();
                MessageBox.Show("Conexión exitosa a la base de datos!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                return false;
            }
            finally
            {
                if (oCon.State == ConnectionState.Open)
                {
                    oCon.Close();
                }
            }
        }

        public bool eliminarDatos(string Tabla, string Condicion)
        {
            try
            {
                abrirConexion();
                Cadena = "Delete " + Tabla + " where " + Condicion;
                oCom = new SqlCommand(Cadena, oCon);
                oCom.ExecuteNonQuery();
                cerrarConexion();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public SqlConnection llevarConexion()
        {
            SqlConnection nuevaCon = new SqlConnection();
            try
            {
                string cadena = "Server=" + server + "; Database=" + basededatos + "; User id=" + usuario.Trim() + "; Password=" + contrasena;
                nuevaCon.ConnectionString = cadena;
                nuevaCon.Open();
                return nuevaCon;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error al abrir la conexión: " + ex.Message);
            }
        }

        public bool ejecutarComando(SqlCommand cmd)
        {
            try
            {
                using (SqlConnection con = llevarConexion())
                {
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar el comando: " + ex.Message);
                return false;
            }
        }

        public bool insertarDatos(string Tabla, string Campos, string Datos)
        {
            abrirConexion();
            Cadena = "Insert into " + Tabla + " (" + Campos + ") values( " + Datos + ")";
            oCom = new SqlCommand(Cadena, oCon);
            oCom.ExecuteNonQuery();
            cerrarConexion();
            return true;
        }

        public bool actualizarDatos(string Tabla, string Datos, string Condicion)
        {
            try
            {
                abrirConexion();
                Cadena = "Update " + Tabla + " set " + Datos + " where " + Condicion;
                oCom = new SqlCommand(Cadena, oCon);
                oCom.ExecuteNonQuery();
                cerrarConexion();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool ejecutarSQL(string Sentencia)
        {
            abrirConexion();
            oCom = new SqlCommand(Sentencia, oCon);
            oCom.ExecuteNonQuery();
            cerrarConexion();
            return true;
        }

        public int retornaValor(string Seleccion, string Tabla, string Condicion)
        {
            int temporal;
            abrirConexion();
            Cadena = "Select isnull(cast(" + Seleccion + " as int),0) from " + Tabla + " where " + Condicion;
            oCom = new SqlCommand(Cadena, oCon);
            oDR = oCom.ExecuteReader();
            oDR.Read();
            temporal = (int)oDR[0];
            oDR.Close();
            cerrarConexion();
            return temporal;
        }

        public object retornaValor(string consulta)
        {
            try
            {
                if (!abrirConexion()) return null;

                oCom = new SqlCommand(consulta, oCon);
                object resultado = oCom.ExecuteScalar();
                cerrarConexion();

                return resultado ?? 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en retornaValor: " + ex.Message);
                return null;
            }
        }

        public string retornaCadena(string Seleccion, string Tabla, string Condicion)
        {
            string temporal;
            abrirConexion();
            Cadena = "Select isnull(cast(" + Seleccion + " as varchar(200)),'') from " + Tabla + " where " + Condicion;
            oCom = new SqlCommand(Cadena, oCon);
            oDR = oCom.ExecuteReader();

            if (oDR.Read())
            {
                temporal = (string)oDR[0];
            }
            else
            {
                temporal = "";
            }
            oDR.Close();
            cerrarConexion();
            return temporal;
        }

        public string retornaCadenaConsulta(string Consulta)
        {
            string temporal;
            abrirConexion();
            oCom = new SqlCommand(Consulta, oCon);
            oDR = oCom.ExecuteReader();
            oDR.Read();
            temporal = (string)oDR[0];
            oDR.Close();
            cerrarConexion();
            return temporal;
        }

        public decimal retornaValorConsulta(string Consulta)
        {
            decimal temporal;
            abrirConexion();
            oCom = new SqlCommand(Consulta, oCon);
            oDR = oCom.ExecuteReader();
            oDR.Read();
            temporal = (decimal)oDR[0];
            oDR.Close();
            cerrarConexion();
            return temporal;
        }

        public DataTable retornaRegistros(string Sentencia)
        {
            DataTable dt = new DataTable();
            if (!string.IsNullOrWhiteSpace(Sentencia))
            {
                abrirConexion();    
                oCom = new SqlCommand(Sentencia, oCon);
                oDA = new SqlDataAdapter(oCom);
                oDA.Fill(dt);
                cerrarConexion();
            }
            return dt;
        }
    }
}
