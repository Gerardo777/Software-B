namespace Autopartes
{
    partial class Empleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_apellido_paterno = new System.Windows.Forms.TextBox();
            this.textBox_apallido_materno = new System.Windows.Forms.TextBox();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.textBox_contraseña = new System.Windows.Forms.TextBox();
            this.textBox_saldo = new System.Windows.Forms.TextBox();
            this.textBox_RFC = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.textBox_ciudad = new System.Windows.Forms.TextBox();
            this.textBox_calle = new System.Windows.Forms.TextBox();
            this.textBox_colonia = new System.Windows.Forms.TextBox();
            this.textBox_numero = new System.Windows.Forms.TextBox();
            this.textBox_CP = new System.Windows.Forms.TextBox();
            this.textBox_comentarios = new System.Windows.Forms.TextBox();
            this.button_cargar = new System.Windows.Forms.Button();
            this.button_alta = new System.Windows.Forms.Button();
            this.button_modificar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.dataGridView_empleado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_empleado)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1094, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 176);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_nombre.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_nombre.ForeColor = System.Drawing.Color.Gray;
            this.textBox_nombre.Location = new System.Drawing.Point(207, 106);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(223, 26);
            this.textBox_nombre.TabIndex = 2;
            this.textBox_nombre.Text = "Nombre";
            this.textBox_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_nombre.TextChanged += new System.EventHandler(this.textBox_nombre_TextChanged);
            this.textBox_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nombre_KeyPress);
            this.textBox_nombre.Leave += new System.EventHandler(this.textBox_nombre_Leave);
            // 
            // textBox_apellido_paterno
            // 
            this.textBox_apellido_paterno.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_apellido_paterno.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_apellido_paterno.ForeColor = System.Drawing.Color.Gray;
            this.textBox_apellido_paterno.Location = new System.Drawing.Point(207, 149);
            this.textBox_apellido_paterno.Name = "textBox_apellido_paterno";
            this.textBox_apellido_paterno.Size = new System.Drawing.Size(223, 26);
            this.textBox_apellido_paterno.TabIndex = 3;
            this.textBox_apellido_paterno.Text = "Apellido Paterno";
            this.textBox_apellido_paterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_apellido_paterno.TextChanged += new System.EventHandler(this.textBox_apellido_paterno_TextChanged);
            this.textBox_apellido_paterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_apellido_paterno_KeyPress);
            this.textBox_apellido_paterno.Leave += new System.EventHandler(this.textBox_apellido_paterno_Leave);
            // 
            // textBox_apallido_materno
            // 
            this.textBox_apallido_materno.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_apallido_materno.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_apallido_materno.ForeColor = System.Drawing.Color.Gray;
            this.textBox_apallido_materno.Location = new System.Drawing.Point(207, 189);
            this.textBox_apallido_materno.Name = "textBox_apallido_materno";
            this.textBox_apallido_materno.Size = new System.Drawing.Size(223, 26);
            this.textBox_apallido_materno.TabIndex = 4;
            this.textBox_apallido_materno.Text = "Apellido Materno";
            this.textBox_apallido_materno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_apallido_materno.TextChanged += new System.EventHandler(this.textBox_apallido_materno_TextChanged);
            this.textBox_apallido_materno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_apallido_materno_KeyPress);
            this.textBox_apallido_materno.Leave += new System.EventHandler(this.textBox_apallido_materno_Leave);
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_usuario.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_usuario.ForeColor = System.Drawing.Color.Gray;
            this.textBox_usuario.Location = new System.Drawing.Point(311, 226);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(119, 26);
            this.textBox_usuario.TabIndex = 5;
            this.textBox_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_usuario.TextChanged += new System.EventHandler(this.textBox_usuario_TextChanged);
            // 
            // textBox_contraseña
            // 
            this.textBox_contraseña.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_contraseña.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_contraseña.ForeColor = System.Drawing.Color.Gray;
            this.textBox_contraseña.Location = new System.Drawing.Point(311, 264);
            this.textBox_contraseña.Name = "textBox_contraseña";
            this.textBox_contraseña.Size = new System.Drawing.Size(119, 26);
            this.textBox_contraseña.TabIndex = 6;
            this.textBox_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_saldo
            // 
            this.textBox_saldo.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_saldo.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_saldo.ForeColor = System.Drawing.Color.Gray;
            this.textBox_saldo.Location = new System.Drawing.Point(311, 298);
            this.textBox_saldo.Name = "textBox_saldo";
            this.textBox_saldo.Size = new System.Drawing.Size(119, 26);
            this.textBox_saldo.TabIndex = 7;
            this.textBox_saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_RFC
            // 
            this.textBox_RFC.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_RFC.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_RFC.ForeColor = System.Drawing.Color.Gray;
            this.textBox_RFC.Location = new System.Drawing.Point(520, 106);
            this.textBox_RFC.Name = "textBox_RFC";
            this.textBox_RFC.Size = new System.Drawing.Size(137, 26);
            this.textBox_RFC.TabIndex = 8;
            this.textBox_RFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_email.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_email.ForeColor = System.Drawing.Color.Gray;
            this.textBox_email.Location = new System.Drawing.Point(520, 149);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(137, 26);
            this.textBox_email.TabIndex = 9;
            this.textBox_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_telefono.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_telefono.ForeColor = System.Drawing.Color.Gray;
            this.textBox_telefono.Location = new System.Drawing.Point(520, 189);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(137, 26);
            this.textBox_telefono.TabIndex = 10;
            this.textBox_telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_ciudad
            // 
            this.textBox_ciudad.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_ciudad.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_ciudad.ForeColor = System.Drawing.Color.Gray;
            this.textBox_ciudad.Location = new System.Drawing.Point(471, 226);
            this.textBox_ciudad.Name = "textBox_ciudad";
            this.textBox_ciudad.Size = new System.Drawing.Size(89, 26);
            this.textBox_ciudad.TabIndex = 11;
            this.textBox_ciudad.Text = "Ciudad";
            this.textBox_ciudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_calle
            // 
            this.textBox_calle.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_calle.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_calle.ForeColor = System.Drawing.Color.Gray;
            this.textBox_calle.Location = new System.Drawing.Point(566, 225);
            this.textBox_calle.Name = "textBox_calle";
            this.textBox_calle.Size = new System.Drawing.Size(91, 26);
            this.textBox_calle.TabIndex = 12;
            this.textBox_calle.Text = "Calle";
            this.textBox_calle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_colonia
            // 
            this.textBox_colonia.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_colonia.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_colonia.ForeColor = System.Drawing.Color.Gray;
            this.textBox_colonia.Location = new System.Drawing.Point(471, 260);
            this.textBox_colonia.Name = "textBox_colonia";
            this.textBox_colonia.Size = new System.Drawing.Size(89, 26);
            this.textBox_colonia.TabIndex = 13;
            this.textBox_colonia.Text = "Colonia";
            this.textBox_colonia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_numero
            // 
            this.textBox_numero.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_numero.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_numero.ForeColor = System.Drawing.Color.Gray;
            this.textBox_numero.Location = new System.Drawing.Point(566, 260);
            this.textBox_numero.Name = "textBox_numero";
            this.textBox_numero.Size = new System.Drawing.Size(41, 26);
            this.textBox_numero.TabIndex = 14;
            this.textBox_numero.Text = "Num";
            this.textBox_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CP
            // 
            this.textBox_CP.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_CP.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_CP.ForeColor = System.Drawing.Color.Gray;
            this.textBox_CP.Location = new System.Drawing.Point(613, 260);
            this.textBox_CP.Name = "textBox_CP";
            this.textBox_CP.Size = new System.Drawing.Size(44, 26);
            this.textBox_CP.TabIndex = 15;
            this.textBox_CP.Text = "CP";
            this.textBox_CP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_comentarios
            // 
            this.textBox_comentarios.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_comentarios.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_comentarios.ForeColor = System.Drawing.Color.Gray;
            this.textBox_comentarios.Location = new System.Drawing.Point(471, 295);
            this.textBox_comentarios.Multiline = true;
            this.textBox_comentarios.Name = "textBox_comentarios";
            this.textBox_comentarios.Size = new System.Drawing.Size(186, 29);
            this.textBox_comentarios.TabIndex = 16;
            this.textBox_comentarios.Text = "Comentarios";
            this.textBox_comentarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_cargar
            // 
            this.button_cargar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_cargar.FlatAppearance.BorderSize = 0;
            this.button_cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cargar.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.button_cargar.ForeColor = System.Drawing.Color.Black;
            this.button_cargar.Location = new System.Drawing.Point(61, 291);
            this.button_cargar.Name = "button_cargar";
            this.button_cargar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_cargar.Size = new System.Drawing.Size(75, 26);
            this.button_cargar.TabIndex = 17;
            this.button_cargar.Text = "Cargar";
            this.button_cargar.UseVisualStyleBackColor = false;
            // 
            // button_alta
            // 
            this.button_alta.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_alta.FlatAppearance.BorderSize = 0;
            this.button_alta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_alta.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.button_alta.Location = new System.Drawing.Point(408, 344);
            this.button_alta.Name = "button_alta";
            this.button_alta.Size = new System.Drawing.Size(94, 23);
            this.button_alta.TabIndex = 18;
            this.button_alta.Text = "Alta";
            this.button_alta.UseVisualStyleBackColor = false;
            // 
            // button_modificar
            // 
            this.button_modificar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_modificar.FlatAppearance.BorderSize = 0;
            this.button_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modificar.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.button_modificar.Location = new System.Drawing.Point(508, 344);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(94, 23);
            this.button_modificar.TabIndex = 19;
            this.button_modificar.Text = "Modificar";
            this.button_modificar.UseVisualStyleBackColor = false;
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_eliminar.FlatAppearance.BorderSize = 0;
            this.button_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eliminar.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.button_eliminar.Location = new System.Drawing.Point(608, 344);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(94, 23);
            this.button_eliminar.TabIndex = 20;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = false;
            // 
            // dataGridView_empleado
            // 
            this.dataGridView_empleado.AllowUserToAddRows = false;
            this.dataGridView_empleado.AllowUserToDeleteRows = false;
            this.dataGridView_empleado.AllowUserToOrderColumns = true;
            this.dataGridView_empleado.AllowUserToResizeColumns = false;
            this.dataGridView_empleado.AllowUserToResizeRows = false;
            this.dataGridView_empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_empleado.Location = new System.Drawing.Point(677, 106);
            this.dataGridView_empleado.Name = "dataGridView_empleado";
            this.dataGridView_empleado.Size = new System.Drawing.Size(406, 211);
            this.dataGridView_empleado.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(232, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(232, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(232, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sueldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(459, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "RFC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(459, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(459, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Teléfono";
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 381);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_empleado);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.button_alta);
            this.Controls.Add(this.button_cargar);
            this.Controls.Add(this.textBox_comentarios);
            this.Controls.Add(this.textBox_CP);
            this.Controls.Add(this.textBox_numero);
            this.Controls.Add(this.textBox_colonia);
            this.Controls.Add(this.textBox_calle);
            this.Controls.Add(this.textBox_ciudad);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_RFC);
            this.Controls.Add(this.textBox_saldo);
            this.Controls.Add(this.textBox_contraseña);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.textBox_apallido_materno);
            this.Controls.Add(this.textBox_apellido_paterno);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Empleado";
            this.Text = "Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_empleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_apellido_paterno;
        private System.Windows.Forms.TextBox textBox_apallido_materno;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.TextBox textBox_contraseña;
        private System.Windows.Forms.TextBox textBox_saldo;
        private System.Windows.Forms.TextBox textBox_RFC;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.TextBox textBox_ciudad;
        private System.Windows.Forms.TextBox textBox_calle;
        private System.Windows.Forms.TextBox textBox_colonia;
        private System.Windows.Forms.TextBox textBox_numero;
        private System.Windows.Forms.TextBox textBox_CP;
        private System.Windows.Forms.TextBox textBox_comentarios;
        private System.Windows.Forms.Button button_cargar;
        private System.Windows.Forms.Button button_alta;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.DataGridView dataGridView_empleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}