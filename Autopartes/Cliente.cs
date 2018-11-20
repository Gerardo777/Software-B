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
using System.Data.SqlClient;
using System.IO;

namespace Autopartes
{
    public partial class Cliente : Form
    {
        string provider = @"Provider=SQLNCLI11;Server=GERARDOHEREDIA\SQLEXPRESS;Database=autopartes;Trusted_Connection=yes;";
        Pen p;
        OpenFileDialog openfile;
        string ruta_foto = "";
        int column;
        int row;
        public Cliente()
        {
            InitializeComponent();
            p = new Pen(Color.Black);
            openfile = new OpenFileDialog();
            Actualiza_Grid();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }



        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {
            Text_Change_TextBox(textBox_nombre, Color.Black);
        }

        private void textBox_nombre_Leave(object sender, EventArgs e)
        {
            Leave_TextBox(textBox_nombre, "Nombre");
        }

        private void textBox_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_apellido_paterno_TextChanged(object sender, EventArgs e)
        {
            Text_Change_TextBox(textBox_apellido_paterno, Color.Black);
        }

        private void textBox_apellido_paterno_Leave(object sender, EventArgs e)
        {
            Leave_TextBox(textBox_apellido_paterno, "Apellido Paterno");
        }

        private void textBox_apellido_paterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_apellido_materno_TextChanged(object sender, EventArgs e)
        {
            Text_Change_TextBox(textBox_apellido_materno, Color.Black);
        }

        private void textBox_apellido_materno_Leave(object sender, EventArgs e)
        {
            Leave_TextBox(textBox_apellido_materno, "Apellido Materno");
        }

        private void textBox_apellido_materno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_credito_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void textBox_pin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_RFC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_ciudad_TextChanged(object sender, EventArgs e)
        {
            Text_Change_TextBox(textBox_ciudad, Color.Black);
        }

        private void textBox_ciudad_Leave(object sender, EventArgs e)
        {
            Leave_TextBox(textBox_ciudad, "Ciudad");
        }

        private void textBox_ciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_calle_TextChanged(object sender, EventArgs e)
        {
            Text_Change_TextBox(textBox_calle, Color.Black);
        }

        private void textBox_calle_Leave(object sender, EventArgs e)
        {
            Leave_TextBox(textBox_calle, "Calle");
        }

        private void textBox_calle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_colonia_TextChanged(object sender, EventArgs e)
        {
            Text_Change_TextBox(textBox_colonia, Color.Black);
        }

        private void textBox_colonia_Leave(object sender, EventArgs e)
        {
            Leave_TextBox(textBox_colonia, "Colonia");
        }

        private void textBox_colonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_numero_TextChanged(object sender, EventArgs e)
        {
            Text_Change_TextBox(textBox_numero, Color.Black);
        }

        private void textBox_numero_Leave(object sender, EventArgs e)
        {
            Leave_TextBox(textBox_numero, "Num");
        }

        private void textBox_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_CP_TextChanged(object sender, EventArgs e)
        {
            Text_Change_TextBox(textBox_CP, Color.Black);
        }

        private void textBox_CP_Leave(object sender, EventArgs e)
        {
            Leave_TextBox(textBox_CP, "CP");
        }

        private void textBox_CP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button_cargar_Click(object sender, EventArgs e)
        {
            openfile.Title = "Abrir Imagen";
            openfile.Filter = "All Images Files (*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif)|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                ruta_foto = openfile.FileName;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Image = Image.FromFile(openfile.FileName);
            }
            openfile.Dispose();
        }

        private void button_alta_Click(object sender, EventArgs e)
        {
            if (Campos_Completos())
            {
                try
                {
                    OleDbConnection con = new OleDbConnection(provider);
                    con.Open();
                    if (con.State != ConnectionState.Open) { return; }//Error

                    OleDbCommand command = new OleDbCommand("INSERT INTO Cliente (IdEmpleado, NombreCliente, AP_Paterno, AP_Materno, Foto, Credito, Pin, Telefono, Ciudad, Calle, Colonia, Numero, CP, Email) " +
                    "VALUES (1,'" + textBox_nombre.Text + "','" + textBox_apellido_paterno.Text + "','" + textBox_apellido_materno.Text + "','" + openfile.FileName + "'," + float.Parse(textBox_credito.Text) + "," +
                    "'" + textBox_pin.Text + "','" + textBox_telefono.Text + "','" + textBox_ciudad.Text + "','" + textBox_calle.Text + "','" + textBox_colonia.Text + "'," +
                    "" + int.Parse(textBox_numero.Text) + "," + int.Parse(textBox_CP.Text) + ",'" + textBox_email.Text + "')", con);

                    command.ExecuteNonQuery();
                    con.Close();
                    Actualiza_Grid();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }

            }
            else
                MessageBox.Show("Faltan campos por llenar!");
        }

        private void button_modificar_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection(provider);
            conexion.Open();
            if (conexion.State != ConnectionState.Open) { return; }
            string consulta = "UPDATE Cliente SET NombreCliente='" + textBox_nombre.Text + "',AP_Paterno='" + textBox_apellido_paterno.Text + "',AP_Materno='" + textBox_apellido_materno.Text +
                "',Credito =" + float.Parse(textBox_credito.Text) + ",Pin='" + textBox_pin.Text + "',Email='" + textBox_email.Text + "',Telefono ='" + textBox_telefono.Text + "',Ciudad='" + textBox_ciudad.Text + "',Calle='"
                + textBox_calle.Text + "',Colonia='" + textBox_colonia.Text + "',Numero=" + int.Parse(textBox_numero.Text) + ",CP=" + int.Parse(textBox_CP.Text) + ",Foto ='" + ruta_foto + "' WHERE idCliente=" + datagrid_cliente.Rows[row].Cells[0].Value;
            OleDbCommand command = new OleDbCommand(consulta, conexion);
            command.ExecuteNonQuery();
            conexion.Close();
            Actualiza_Grid();
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection(provider);
            conexion.Open();
            if (conexion.State != ConnectionState.Open) { return; }
            string consulta = "DELETE FROM Cliente WHERE idCliente=" + datagrid_cliente.Rows[row].Cells[0].Value;
            OleDbCommand command = new OleDbCommand(consulta, conexion);
            command.ExecuteNonQuery();
            conexion.Close();
            Actualiza_Grid();
            Limpa_Controles();
        }

        private void Text_Change_TextBox(TextBox textbox, Color color)
        {
            textbox.ForeColor = color;
        }

        private void Leave_TextBox(TextBox textbox, string field)
        {

            if (textbox.Text.Length == 0)
            {
                textbox.Text = field;
                textbox.ForeColor = Color.Gray;
            }
        }

        private bool Textbox_Nombre_Completo()
        {
            bool esta_lleno = true;

            if (textBox_nombre.Text.Length == 0 || textBox_nombre.ForeColor == Color.Gray)
                esta_lleno = false;

            return esta_lleno;
        }

        private bool Textbox_Ap_Paterno_Completo()
        {
            bool esta_lleno = true;

            if (textBox_apellido_paterno.Text.Length == 0 || textBox_apellido_paterno.ForeColor == Color.Gray)
                esta_lleno = false;

            return esta_lleno;
        }

        private bool Textbox_Ap_Materno_Completo()
        {
            bool esta_lleno = true;

            if (textBox_apellido_materno.Text.Length == 0 || textBox_apellido_materno.ForeColor == Color.Gray)
                esta_lleno = false;

            return esta_lleno;
        }

        private bool Textbox_Credito_Completo()
        {
            bool esta_lleno = true;

            if (textBox_credito.Text.Length == 0)
                esta_lleno = false;

            return esta_lleno;
        }

        private bool Textbox_Pin_Completo()
        {
            bool esta_lleno = true;

            if (textBox_pin.Text.Length == 0)
                esta_lleno = false;

            return esta_lleno;
        }

        private bool Textbox_RFC_Completo()
        {
            bool esta_lleno = true;

            if (textBox_RFC.Text.Length == 0)
                esta_lleno = false;

            return esta_lleno;
        }

        private bool Textbox_Email_Completo()
        {
            bool esta_lleno = true;

            if (textBox_email.Text.Length == 0)
                esta_lleno = false;

            return esta_lleno;
        }

        private bool Textbox_Telefono_Completo()
        {
            bool esta_lleno = true;

            if (textBox_telefono.Text.Length == 0)
                esta_lleno = false;

            return esta_lleno;
        }

        private bool Textbox_Ciudad_Completo()
        {
            bool esta_lleno = true;

            if (textBox_ciudad.Text.Length == 0 || textBox_ciudad.ForeColor == Color.Gray)
                esta_lleno = false;

            return esta_lleno;
        }

        private bool Textbox_Calle_Completo()
        {
            bool esta_lleno = true;

            if (textBox_calle.Text.Length == 0 || textBox_calle.ForeColor == Color.Gray)
                esta_lleno = false;

            return esta_lleno;
        }

        private bool Textbox_Colonia_Completo()
        {
            bool esta_lleno = true;

            if (textBox_colonia.Text.Length == 0 || textBox_colonia.ForeColor == Color.Gray)
                esta_lleno = false;

            return esta_lleno;
        }

        private bool Textbox_Numero_Completo()
        {
            bool esta_lleno = true;

            if (textBox_numero.Text.Length == 0 || textBox_numero.ForeColor == Color.Gray)
                esta_lleno = false;

            return esta_lleno;
        }

        private bool Textbox_CP_Completo()
        {
            bool esta_lleno = true;

            if (textBox_CP.Text.Length == 0 || textBox_CP.ForeColor == Color.Gray)
                esta_lleno = false;

            return esta_lleno;
        }

        private bool PicureBox_Empleado_Completo()
        {
            bool esta_lleno = true;

            if (openfile.FileName.Length == 0 || openfile.FileName.Equals("") || openfile.FileName.Equals(null))
                esta_lleno = false;

            return esta_lleno;
        }

        private bool Campos_Completos()
        {
            bool completo = true;

            if (!Textbox_Nombre_Completo() || !Textbox_Ap_Paterno_Completo() || !Textbox_Ap_Materno_Completo() || !Textbox_Credito_Completo() || !Textbox_Pin_Completo() ||
                !Textbox_RFC_Completo() || !Textbox_Email_Completo() || !Textbox_Telefono_Completo() || !Textbox_Ciudad_Completo() || !Textbox_Calle_Completo() || !Textbox_Colonia_Completo() ||
                !Textbox_Numero_Completo() || !Textbox_CP_Completo() || !PicureBox_Empleado_Completo())
                completo = false;
            return completo;
        }

        private void Actualiza_Grid()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(provider);
                con.Open();
                if (con.State != ConnectionState.Open) { return; }//Error

                //IdEmpleado, NombreCliente, AP_Paterno, AP_Materno, Foto, Credito, Pin, Telefono, Ciudad, Calle, Colonia, Numero, CP, Email
                OleDbCommand command = new OleDbCommand("SELECT IdCliente, NombreCliente, Ap_Paterno, Ap_Materno, Credito, Telefono,Email FROM Cliente", con);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                DataTable table = new DataTable();
                adapter.Fill(table);
                datagrid_cliente.DataSource = table;
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void datagrid_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            column = e.ColumnIndex;
            row = e.RowIndex;
            Recupera_Datos(row);
        }


        private void Recupera_Datos(int r)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(provider);
                con.Open();
                if (con.State != ConnectionState.Open) { return; }//Error

                OleDbCommand command = new OleDbCommand("SELECT * FROM Cliente WHERE IdCliente = " + datagrid_cliente.Rows[r].Cells[0].Value.ToString(), con);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                DataTable table = new DataTable();
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    textBox_nombre.Text = row["NombreCliente"].ToString();
                    textBox_apellido_paterno.Text = row["Ap_Paterno"].ToString();
                    textBox_apellido_materno.Text = row["Ap_Materno"].ToString();
                    textBox_credito.Text = row["Credito"].ToString();
                    textBox_pin.Text = row["Pin"].ToString();
                    //textBox_RFC.Text = row["RFC"].ToString();
                    textBox_email.Text = row["Email"].ToString();
                    textBox_telefono.Text = row["Telefono"].ToString();
                    textBox_ciudad.Text = row["Ciudad"].ToString();
                    textBox_calle.Text = row["Calle"].ToString();
                    textBox_colonia.Text = row["Colonia"].ToString();
                    textBox_numero.Text = row["Numero"].ToString();
                    textBox_CP.Text = row["CP"].ToString();
                    ruta_foto = row["Foto"].ToString();
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox2.Image = Image.FromFile(row["Foto"].ToString());
                }
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void Cliente_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(p, 12, 105, 194, 105);// arriba
            g.DrawLine(p, 12, 335, 194, 335);//abajo
            g.DrawLine(p, 12, 105, 12, 335); //izquierda            
            g.DrawLine(p, 194, 105, 194, 335); //derecha
        }

        private void datagrid_cliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Limpa_Controles()
        {
            textBox_nombre.Clear();
            textBox_apellido_paterno.Clear();
            textBox_apellido_materno.Clear();
            textBox_credito.Clear();            
            textBox_pin.Clear();
            textBox_RFC.Clear();
            textBox_telefono.Clear();
            textBox_email.Clear();
            textBox_ciudad.Clear();
            textBox_calle.Clear();
            textBox_colonia.Clear();
            textBox_numero.Clear();
            textBox_CP.Clear();            
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile(@"C:\Users\Gerardo Heredia\Desktop\Noveno Semestre\Software B\Compra Imagen.png");
        }
            

    }
}
