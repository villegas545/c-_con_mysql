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
    public partial class modificar : Form
    {
        int id = 0;
        String Nombre, Telefono, Edad = "";

        private void modificar_Load(object sender, EventArgs e)
        {
            txtNombre.Text = Nombre;
            txtTelefono.Text = Telefono;
            txtEdad.Text = Edad;
        }

        public modificar(int _id,String _Nombre, String _Telefono, String _Edad)
        {
            InitializeComponent();
            id = _id;
            Nombre = _Nombre;
            Edad = _Edad;
            Telefono = _Telefono;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sql = "UPDATE pruebatabla SET Nombre = '"+txtNombre.Text+ "', Telefono = '" + txtTelefono.Text + "', Edad = '" + txtEdad.Text + "' WHERE Id = " + id+";";
            MessageBox.Show(conexion.ejecutarQuery(sql, "Registro modificado satisfactoriamente"));
            this.Close();
        }
    }
}
