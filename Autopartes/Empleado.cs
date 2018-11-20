using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autopartes
{
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
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

        private void textBox_apallido_materno_TextChanged(object sender, EventArgs e)
        {
            Text_Change_TextBox(textBox_apallido_materno, Color.Black);
        }

        private void textBox_apallido_materno_Leave(object sender, EventArgs e)
        {
            Leave_TextBox(textBox_apallido_materno, "Apellido Materno");
        }

        private void textBox_apallido_materno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
