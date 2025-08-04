using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; 
using System.Data.SqlClient;

namespace test
{
    public partial class AgregarProveedor : Form
    {
        // Importación de funciones Win32 para mover el formulario
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private int? ID = null; // null = nuevo, valor = edición



        public AgregarProveedor() // Constructor para agregar
        {
            InitializeComponent();
            this.ActiveControl = null;
        }

        public AgregarProveedor(int id, string ruc, string nombre, string telefono, string correo, string direccion, string activo)
            : this()
        {
            ID = id;
            txtBox_RucProveedor.Text = ruc;
            txtBox_NombreProveedor.Text = nombre;
            txtBox_telefonoProveedor.Text = telefono;
            txtBox_CorreoProveedor.Text = correo;
            txtBox_direccionProveedor.Text = direccion;
            cmbBox_ActivoProveedor.Text = activo;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AgregarProveedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void pnlProveedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void SalirProveedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            string ruc = txtBox_RucProveedor.Text;
            string nombre = txtBox_NombreProveedor.Text;
            string telefono = txtBox_telefonoProveedor.Text;
            string correo = txtBox_CorreoProveedor.Text;
            string direccion = txtBox_direccionProveedor.Text;
            string activo = cmbBox_ActivoProveedor.Text;

            // Usar la clase de conexión personalizada
            conexion_bdbd conexion = new conexion_bdbd();

            string query;
            if (ID == null)
            {
                // Insertar nuevo
                query = "INSERT INTO Proveedores (RUC, Nombre, Telefono, Correo, Direccion, Activo) " +
                        "VALUES (@RUC, @Nombre, @Telefono, @Correo, @Direccion, @Activo)";
            }
            else
            {
                // Actualizar existente
                query = "UPDATE Proveedores SET RUC=@RUC, Nombre=@Nombre, Telefono=@Telefono, " +
                        "Correo=@Correo, Direccion=@Direccion, Activo=@Activo " +
                        "WHERE ID=@ID";
            }

            using (SqlCommand command = new SqlCommand(query, conexion.conexion_BBD))
            {
                command.Parameters.AddWithValue("@RUC", ruc);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Telefono", telefono);
                command.Parameters.AddWithValue("@Correo", correo);
                command.Parameters.AddWithValue("@Direccion", direccion);
                command.Parameters.AddWithValue("@Activo", activo);

                if (ID != null)
                    command.Parameters.AddWithValue("@ID", ID);

                try
                {
                    conexion.conexion_BBD.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show(ID == null ? "Proveedor agregado." : "Proveedor actualizado.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el proveedor: " + ex.Message);
                }
                finally
                {
                    if (conexion.conexion_BBD.State == ConnectionState.Open)
                        conexion.conexion_BBD.Close();
                }
            }

            // Limpiar los campos después de guardar solo si es nuevo
            if (ID == null)
            {
                txtBox_RucProveedor.Clear();
                txtBox_NombreProveedor.Clear();
                txtBox_telefonoProveedor.Clear();
                txtBox_CorreoProveedor.Clear();
                txtBox_direccionProveedor.Clear();
                cmbBox_ActivoProveedor.SelectedIndex = -1;
                this.Close(); // Cierra el formulario después de agregar
            }
            else
            {
                this.Close(); // Si es edición, cierra el formulario
            }
        }

        
    }
}
