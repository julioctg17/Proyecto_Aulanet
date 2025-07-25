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

namespace Proyecto_Aulanet
{
    public partial class frmcreacue : Form
    {
        public frmcreacue()
        {
            InitializeComponent();
        }

        private void frmcreacue_Load(object sender, EventArgs e)
        {

        }

        private void bntcrearcuen_Click(object sender, EventArgs e)
        {
            string NombreUsuario = txtnomc.Text.Trim();
            string ApellidoPaterno = txtapepat.Text.Trim();
            string ApellidoMaterno = txtapemat.Text.Trim();
            string Contrasena = txtcontrasena.Text.Trim();
            string Curp = txtcurp.Text.Trim();

            using (var conn = new ConexionDB().ObtenerConexion())
            {
                conn.Open();
                var cmd = new SqlCommand("INSERT INTO Usuario(NombreUsuario, ApellidoPaterno, ApellidoMaterno, Contrasena, Curp) VALUES (@n, @ap, @am, @c, @crp)", conn);
                cmd.Parameters.AddWithValue("@n", NombreUsuario);
                cmd.Parameters.AddWithValue("@ap", ApellidoPaterno);
                cmd.Parameters.AddWithValue("@am", ApellidoMaterno);
                cmd.Parameters.AddWithValue("@c", Contrasena);
                cmd.Parameters.AddWithValue("@crp", Curp);
            }
            if (txtcontrasena.Text == txtconfcont.Text)
            {
                MessageBox.Show("Estudiante registrado");
            }
            else 
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            txtnomc.Clear();
            txtapepat.Clear();
            txtapemat.Clear();
            txtcontrasena.Clear();
            txtcurp.Clear();
           txtconfcont.Clear();
        }
        private void CargarUsuario()
        {
            using (var conn = new ConexionDB().ObtenerConexion())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT IdUsuario, NombreUsuario, ApellidoPaterno, ApellidoMaterno FROM Usuario", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    reader "IdUsuario", reader "Nombre", reader "Correo"];
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtconfcont_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtapepat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
