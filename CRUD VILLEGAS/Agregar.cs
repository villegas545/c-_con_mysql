using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_VILLEGAS
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sql = "INSERT INTO pruebatabla (Nombre, Telefono, Edad) VALUES ('"+txtNombre.Text+ "', '" + txtTelefono.Text + "', '" + txtEdad.Text + "');";
            MessageBox.Show(conexion.ejecutarQuery(sql, "Registro Satisfactorio"));
            this.Close();
        }
    }
}
