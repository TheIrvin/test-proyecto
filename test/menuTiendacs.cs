using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class menuTiendacs : Form
    {
        public menuTiendacs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new Inventariocs());
        }
        private void AbrirEnPanel(Form formNij0)
        {
            if (this.pnlInventario.Controls.Count > 0)
            {
                this.pnlInventario.Controls.RemoveAt(0);
            }

            Form fn = formNij0 as Form;
            if (fn != null)
            {
                fn.TopLevel = false;
                fn.FormBorderStyle = FormBorderStyle.None;
                fn.Dock = DockStyle.Fill;
                this.pnlInventario.Controls.Add(fn);
                this.pnlInventario.Tag = fn;
                fn.Show();
            }
        }

        private void btnMotos_Click(object sender, EventArgs e)
        {

        }
    }
}
