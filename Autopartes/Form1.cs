using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;





namespace Autopartes
{
    public partial class Form1 : Form
    {
        Pen p;
        Graphics g;
        public Form1()
        {            
            InitializeComponent();
            p = new Pen(Color.Black);            
        }
        
        private bool login(string sha_1)
        {
            string provider = @"Provider=SQLNCLI11;Server=GERARDOHEREDIA\SQLEXPRESS;Database=autopartes;Trusted_Connection=yes;";
            OleDbConnection conexion = new OleDbConnection(provider);
            conexion.Open();

            if (conexion.State != ConnectionState.Open) { }//ERROR

            //DataGridView credenciales_usuario = new DataGridView();
            OleDbCommand command = new OleDbCommand("SELECT empleado.Contraseña FROM empleado  WHERE usuario ='" + textbox_usuario.Text + "'", conexion);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conexion.Close();
            if (table.Rows.Count > 0)
            {
                if (table.Rows[0][0].ToString().Equals(sha_1))
                {                    
                    return true;
                }
                else
                {
                    MessageBox.Show("Error de inicio de sesión!");                                   
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Error de inicio de sesión!");
                
                return false;
            }                        
        }

        private string GetSHA1(string text)
        {
            SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
            sh.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] re = sh.Hash;
            StringBuilder sb = new StringBuilder();
            foreach (byte b in re)
                sb.Append(b.ToString("x2"));
            return sb.ToString();
        }
       
        private void textbox_password_TextChanged(object sender, EventArgs e)
        {
            textbox_password.ForeColor = Color.Black;
            textbox_password.UseSystemPasswordChar = true;            
        }

        private void textbox_password_Leave(object sender, EventArgs e)
        {
            if (textbox_password.Text.Length == 0)
            {
                textbox_password.Text = "Contraseña";
                textbox_password.ForeColor = Color.Gray;
                textbox_password.UseSystemPasswordChar = false;
            }
        }

        private void textbox_usuario_TextChanged(object sender, EventArgs e)
        {
            textbox_usuario.ForeColor = Color.Black;            
        }

        private void textbox_usuario_Leave(object sender, EventArgs e)
        {
            if (textbox_usuario.Text.Length == 0)
            {
                textbox_usuario.Text = "Usuario";
                textbox_usuario.ForeColor = Color.Gray;
            }
        }

                    
        private void boton_aceptar_Click(object sender, EventArgs e)
        {
            string sha1 = "";
            sha1 = GetSHA1(textbox_password.Text);
            if (login(sha1))
            {
                this.Visible = false;
                Tienda t = new Tienda();
                t.ShowDialog();
                textbox_usuario.Clear();
                textbox_password.Clear();
                this.Visible = true;                
                textbox_usuario.Text = "Usuario";
                textbox_password.Text = "Contraseña";
                textbox_usuario.ForeColor = Color.Gray;
                textbox_password.ForeColor = Color.Gray;
                textbox_password.UseSystemPasswordChar = false;
            }
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Leave(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawLine(p, 179, 125,477 , 125);
            g.DrawLine(p, 179, 201, 477, 201);
        }
    }
}
