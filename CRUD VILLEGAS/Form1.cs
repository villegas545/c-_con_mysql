using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace CRUD_VILLEGAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
           
           
            cargarDatos();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int id= int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string sql = "DELETE FROM pruebatabla WHERE Id = "+id+"";
            MessageBox.Show(conexion.ejecutarQuery(sql,"Eliminado Satisfactoriamente"));
            cargarDatos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            String Nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String Telefono = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            String Edad = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            modificar formularioModificar =new modificar(id,Nombre,Telefono,Edad);
            formularioModificar.Show();
        }
    
        public void cargarDatos()
        {
            string sql = "SELECT * FROM pruebatabla";
            dataGridView1.DataSource = conexion.ConsultaQuery(sql);
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
        public static void limpiar()
        {
      
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Agregar formularioAgregar = new Agregar();
            formularioAgregar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM pruebatabla WHERE "+ cbxFiltro.Text +" LIKE '%"+ txtBusqueda.Text +"%'";
            dataGridView1.DataSource = conexion.ConsultaQuery(sql);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
