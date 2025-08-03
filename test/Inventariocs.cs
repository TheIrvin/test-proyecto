using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Inventariocs : Form
    {
        public Inventariocs()
        {
            InitializeComponent();
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            AgregarProveedor agregarProveedor = new AgregarProveedor();
            agregarProveedor.ShowDialog(); 

            conexion_bdbd conexion = new conexion_bdbd();
            dgvProveedor.DataSource = conexion.retornaRegistros("SELECT * FROM Proveedores");
        }

        private void Inventariocs_Load(object sender, EventArgs e)
        {
            conexion_bdbd conexion = new conexion_bdbd();
            dgvProveedor.DataSource = conexion.retornaRegistros("SELECT * FROM Proveedores");
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProveedor.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["ID"].Value);
                string ruc = row.Cells["RUC"].Value.ToString();
                string nombre = row.Cells["Nombre"].Value.ToString();
                string telefono = row.Cells["Telefono"].Value.ToString();
                string correo = row.Cells["Correo"].Value.ToString();
                string direccion = row.Cells["Direccion"].Value.ToString();
                string activo = row.Cells["Activo"].Value.ToString();

                AgregarProveedor editarProveedor = new AgregarProveedor(id, ruc, nombre, telefono, correo, direccion, activo);
                editarProveedor.ShowDialog();
                dgvProveedor.Refresh();
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor para editar.");
            }
        }

        private void dgvProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProveedor.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["ID"].Value);
                string ruc = row.Cells["RUC"].Value.ToString();
                string nombre = row.Cells["Nombre"].Value.ToString();
                string telefono = row.Cells["Telefono"].Value.ToString();
                string correo = row.Cells["Correo"].Value.ToString();
                string direccion = row.Cells["Direccion"].Value.ToString();
                string activo = row.Cells["Activo"].Value.ToString();

                AgregarProveedor editarProveedor = new AgregarProveedor(id, ruc, nombre, telefono, correo, direccion, activo);
                editarProveedor.ShowDialog();
                // Recarga el DataGridView después de editar si lo deseas
            }
        }

        private void btnEditarProveedor_Click_1(object sender, EventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProveedor.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["ID"].Value);
                string ruc = row.Cells["RUC"].Value.ToString();
                string nombre = row.Cells["Nombre"].Value.ToString();
                string telefono = row.Cells["Telefono"].Value.ToString();
                string correo = row.Cells["Correo"].Value.ToString();
                string direccion = row.Cells["Direccion"].Value.ToString();
                string activo = row.Cells["Activo"].Value.ToString();

                AgregarProveedor editarProveedor = new AgregarProveedor(id, ruc, nombre, telefono, correo, direccion, activo);
                editarProveedor.ShowDialog();

                // Recarga el DataGridView después de editar
                conexion_bdbd conexion = new conexion_bdbd();
                dgvProveedor.DataSource = conexion.retornaRegistros("SELECT * FROM Proveedores");
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor para editar.");
            }
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "¿Seguro deseas eliminar este proveedor?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvProveedor.SelectedRows[0];
                    int id = Convert.ToInt32(row.Cells["ID"].Value);

                    conexion_bdbd conexion = new conexion_bdbd();
                    string query = $"DELETE FROM Proveedores WHERE ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conexion.conexion_BBD))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);

                        try
                        {
                            conexion.conexion_BBD.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Proveedor eliminado correctamente.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al eliminar el proveedor: " + ex.Message);
                        }
                        finally
                        {
                            if (conexion.conexion_BBD.State == System.Data.ConnectionState.Open)
                                conexion.conexion_BBD.Close();
                        }
                    }

                    dgvProveedor.DataSource = conexion.retornaRegistros("SELECT * FROM Proveedores");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor para eliminar.");
            }
        }
        private void FiltrarProveedores()
        {
            string campo = cmb_FiltroPor.SelectedItem?.ToString();
            string valor = txtBox_Filtro.Text.Trim();

            if (string.IsNullOrEmpty(campo) || string.IsNullOrEmpty(valor))
            {
                conexion_bdbd conexion = new conexion_bdbd();
                dgvProveedor.DataSource = conexion.retornaRegistros("SELECT * FROM Proveedores");
                return;
            }

            string columna = campo;

            string query;
            if (columna == "Activo")
                query = $"SELECT * FROM Proveedores WHERE Activo = @valor";
            else
                query = $"SELECT * FROM Proveedores WHERE {columna} LIKE @valor";

            conexion_bdbd conexion2 = new conexion_bdbd();
            using (SqlCommand cmd = new SqlCommand(query, conexion2.conexion_BBD))
            {
                if (columna == "Activo")
                    cmd.Parameters.AddWithValue("@valor", valor);
                else
                    cmd.Parameters.AddWithValue("@valor", "%" + valor + "%");

                DataTable dt = new DataTable();
                try
                {
                    conexion2.conexion_BBD.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                finally
                {
                    if (conexion2.conexion_BBD.State == System.Data.ConnectionState.Open)
                        conexion2.conexion_BBD.Close();
                }
                dgvProveedor.DataSource = dt;
            }
        }
        private void cmb_FiltroPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProveedores();

        }

        private void txtBox_Filtro_TextChanged(object sender, EventArgs e)
        {
            FiltrarProveedores();
            if (txtBox_Filtro.Text.Length == 0)
            {
                this.ActiveControl = null; 
            }
        }
    }
}
