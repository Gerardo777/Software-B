namespace Autopartes
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_apellido_paterno = new System.Windows.Forms.TextBox();
            this.textBox_apellido_materno = new System.Windows.Forms.TextBox();
            this.textBox_credito = new System.Windows.Forms.TextBox();
            this.textBox_pin = new System.Windows.Forms.TextBox();
            this.textBox_RFC = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.textBox_ciudad = new System.Windows.Forms.TextBox();
            this.textBox_calle = new System.Windows.Forms.TextBox();
            this.textBox_colonia = new System.Windows.Forms.TextBox();
            this.textBox_numero = new System.Windows.Forms.TextBox();
            this.textBox_CP = new System.Windows.Forms.TextBox();
            this.button_cargar = new System.Windows.Forms.Button();
            this.button_alta = new System.Windows.Forms.Button();
            this.button_modificar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.datagrid_cliente = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1094, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "RFC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Crédito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Pin";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_nombre.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_nombre.ForeColor = System.Drawing.Color.Gray;
            this.textBox_nombre.Location = new System.Drawing.Point(207, 116);
            this.textBox_nombre.MaxLength = 30;
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(223, 26);
            this.textBox_nombre.TabIndex = 25;
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
            this.textBox_apellido_paterno.Location = new System.Drawing.Point(207, 170);
            this.textBox_apellido_paterno.MaxLength = 15;
            this.textBox_apellido_paterno.Name = "textBox_apellido_paterno";
            this.textBox_apellido_paterno.Size = new System.Drawing.Size(223, 26);
            this.textBox_apellido_paterno.TabIndex = 26;
            this.textBox_apellido_paterno.Text = "Apellido Paterno";
            this.textBox_apellido_paterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_apellido_paterno.TextChanged += new System.EventHandler(this.textBox_apellido_paterno_TextChanged);
            this.textBox_apellido_paterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_apellido_paterno_KeyPress);
            this.textBox_apellido_paterno.Leave += new System.EventHandler(this.textBox_apellido_paterno_Leave);
            // 
            // textBox_apellido_materno
            // 
            this.textBox_apellido_materno.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_apellido_materno.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_apellido_materno.ForeColor = System.Drawing.Color.Gray;
            this.textBox_apellido_materno.Location = new System.Drawing.Point(207, 224);
            this.textBox_apellido_materno.MaxLength = 15;
            this.textBox_apellido_materno.Name = "textBox_apellido_materno";
            this.textBox_apellido_materno.Size = new System.Drawing.Size(223, 26);
            this.textBox_apellido_materno.TabIndex = 27;
            this.textBox_apellido_materno.Text = "Apellido Materno";
            this.textBox_apellido_materno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_apellido_materno.TextChanged += new System.EventHandler(this.textBox_apellido_materno_TextChanged);
            this.textBox_apellido_materno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_apellido_materno_KeyPress);
            this.textBox_apellido_materno.Leave += new System.EventHandler(this.textBox_apellido_materno_Leave);
            // 
            // textBox_credito
            // 
            this.textBox_credito.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_credito.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_credito.ForeColor = System.Drawing.Color.Black;
            this.textBox_credito.Location = new System.Drawing.Point(311, 263);
            this.textBox_credito.Name = "textBox_credito";
            this.textBox_credito.Size = new System.Drawing.Size(119, 26);
            this.textBox_credito.TabIndex = 28;
            this.textBox_credito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_credito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_credito_KeyPress);
            // 
            // textBox_pin
            // 
            this.textBox_pin.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_pin.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_pin.ForeColor = System.Drawing.Color.Black;
            this.textBox_pin.Location = new System.Drawing.Point(311, 299);
            this.textBox_pin.MaxLength = 4;
            this.textBox_pin.Name = "textBox_pin";
            this.textBox_pin.Size = new System.Drawing.Size(119, 26);
            this.textBox_pin.TabIndex = 29;
            this.textBox_pin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_pin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pin_KeyPress);
            // 
            // textBox_RFC
            // 
            this.textBox_RFC.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_RFC.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_RFC.ForeColor = System.Drawing.Color.Black;
            this.textBox_RFC.Location = new System.Drawing.Point(520, 141);
            this.textBox_RFC.MaxLength = 13;
            this.textBox_RFC.Name = "textBox_RFC";
            this.textBox_RFC.Size = new System.Drawing.Size(137, 26);
            this.textBox_RFC.TabIndex = 30;
            this.textBox_RFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_RFC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_RFC_KeyPress);
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_email.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_email.ForeColor = System.Drawing.Color.Black;
            this.textBox_email.Location = new System.Drawing.Point(520, 184);
            this.textBox_email.MaxLength = 25;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(137, 26);
            this.textBox_email.TabIndex = 31;
            this.textBox_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_telefono.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_telefono.Location = new System.Drawing.Point(520, 224);
            this.textBox_telefono.MaxLength = 10;
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(137, 26);
            this.textBox_telefono.TabIndex = 32;
            this.textBox_telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_telefono_KeyPress);
            // 
            // textBox_ciudad
            // 
            this.textBox_ciudad.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_ciudad.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_ciudad.ForeColor = System.Drawing.Color.Gray;
            this.textBox_ciudad.Location = new System.Drawing.Point(471, 267);
            this.textBox_ciudad.MaxLength = 15;
            this.textBox_ciudad.Name = "textBox_ciudad";
            this.textBox_ciudad.Size = new System.Drawing.Size(89, 26);
            this.textBox_ciudad.TabIndex = 33;
            this.textBox_ciudad.Text = "Ciudad";
            this.textBox_ciudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_ciudad.TextChanged += new System.EventHandler(this.textBox_ciudad_TextChanged);
            this.textBox_ciudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ciudad_KeyPress);
            this.textBox_ciudad.Leave += new System.EventHandler(this.textBox_ciudad_Leave);
            // 
            // textBox_calle
            // 
            this.textBox_calle.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_calle.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_calle.ForeColor = System.Drawing.Color.Gray;
            this.textBox_calle.Location = new System.Drawing.Point(566, 266);
            this.textBox_calle.MaxLength = 15;
            this.textBox_calle.Name = "textBox_calle";
            this.textBox_calle.Size = new System.Drawing.Size(91, 26);
            this.textBox_calle.TabIndex = 34;
            this.textBox_calle.Text = "Calle";
            this.textBox_calle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_calle.TextChanged += new System.EventHandler(this.textBox_calle_TextChanged);
            this.textBox_calle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_calle_KeyPress);
            this.textBox_calle.Leave += new System.EventHandler(this.textBox_calle_Leave);
            // 
            // textBox_colonia
            // 
            this.textBox_colonia.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_colonia.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_colonia.ForeColor = System.Drawing.Color.Gray;
            this.textBox_colonia.Location = new System.Drawing.Point(471, 301);
            this.textBox_colonia.MaxLength = 15;
            this.textBox_colonia.Name = "textBox_colonia";
            this.textBox_colonia.Size = new System.Drawing.Size(89, 26);
            this.textBox_colonia.TabIndex = 35;
            this.textBox_colonia.Text = "Colonia";
            this.textBox_colonia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_colonia.TextChanged += new System.EventHandler(this.textBox_colonia_TextChanged);
            this.textBox_colonia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_colonia_KeyPress);
            this.textBox_colonia.Leave += new System.EventHandler(this.textBox_colonia_Leave);
            // 
            // textBox_numero
            // 
            this.textBox_numero.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_numero.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_numero.ForeColor = System.Drawing.Color.Gray;
            this.textBox_numero.Location = new System.Drawing.Point(566, 301);
            this.textBox_numero.Name = "textBox_numero";
            this.textBox_numero.Size = new System.Drawing.Size(41, 26);
            this.textBox_numero.TabIndex = 36;
            this.textBox_numero.Text = "Num";
            this.textBox_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_numero.TextChanged += new System.EventHandler(this.textBox_numero_TextChanged);
            this.textBox_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_numero_KeyPress);
            this.textBox_numero.Leave += new System.EventHandler(this.textBox_numero_Leave);
            // 
            // textBox_CP
            // 
            this.textBox_CP.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_CP.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.textBox_CP.ForeColor = System.Drawing.Color.Gray;
            this.textBox_CP.Location = new System.Drawing.Point(613, 301);
            this.textBox_CP.MaxLength = 5;
            this.textBox_CP.Name = "textBox_CP";
            this.textBox_CP.Size = new System.Drawing.Size(44, 26);
            this.textBox_CP.TabIndex = 37;
            this.textBox_CP.Text = "CP";
            this.textBox_CP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_CP.TextChanged += new System.EventHandler(this.textBox_CP_TextChanged);
            this.textBox_CP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CP_KeyPress);
            this.textBox_CP.Leave += new System.EventHandler(this.textBox_CP_Leave);
            // 
            // button_cargar
            // 
            this.button_cargar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_cargar.FlatAppearance.BorderSize = 0;
            this.button_cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cargar.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.button_cargar.ForeColor = System.Drawing.Color.Black;
            this.button_cargar.Location = new System.Drawing.Point(61, 301);
            this.button_cargar.Name = "button_cargar";
            this.button_cargar.Size = new System.Drawing.Size(75, 26);
            this.button_cargar.TabIndex = 38;
            this.button_cargar.Text = "Cargar";
            this.button_cargar.UseVisualStyleBackColor = false;
            this.button_cargar.Click += new System.EventHandler(this.button_cargar_Click);
            // 
            // button_alta
            // 
            this.button_alta.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_alta.FlatAppearance.BorderSize = 0;
            this.button_alta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_alta.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.button_alta.ForeColor = System.Drawing.Color.Black;
            this.button_alta.Location = new System.Drawing.Point(408, 344);
            this.button_alta.Name = "button_alta";
            this.button_alta.Size = new System.Drawing.Size(94, 23);
            this.button_alta.TabIndex = 39;
            this.button_alta.Text = "Alta";
            this.button_alta.UseVisualStyleBackColor = false;
            this.button_alta.Click += new System.EventHandler(this.button_alta_Click);
            // 
            // button_modificar
            // 
            this.button_modificar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_modificar.FlatAppearance.BorderSize = 0;
            this.button_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modificar.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.button_modificar.ForeColor = System.Drawing.Color.Black;
            this.button_modificar.Location = new System.Drawing.Point(508, 344);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(94, 23);
            this.button_modificar.TabIndex = 40;
            this.button_modificar.Text = "Modificar";
            this.button_modificar.UseVisualStyleBackColor = false;
            this.button_modificar.Click += new System.EventHandler(this.button_modificar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_eliminar.FlatAppearance.BorderSize = 0;
            this.button_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eliminar.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.button_eliminar.ForeColor = System.Drawing.Color.Black;
            this.button_eliminar.Location = new System.Drawing.Point(608, 344);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(94, 23);
            this.button_eliminar.TabIndex = 41;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = false;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // datagrid_cliente
            // 
            this.datagrid_cliente.AllowUserToAddRows = false;
            this.datagrid_cliente.AllowUserToDeleteRows = false;
            this.datagrid_cliente.AllowUserToResizeColumns = false;
            this.datagrid_cliente.AllowUserToResizeRows = false;
            this.datagrid_cliente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datagrid_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_cliente.GridColor = System.Drawing.SystemColors.Control;
            this.datagrid_cliente.Location = new System.Drawing.Point(677, 116);
            this.datagrid_cliente.Name = "datagrid_cliente";
            this.datagrid_cliente.ReadOnly = true;
            this.datagrid_cliente.Size = new System.Drawing.Size(406, 211);
            this.datagrid_cliente.TabIndex = 42;
            this.datagrid_cliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_cliente_CellClick);
            this.datagrid_cliente.Paint += new System.Windows.Forms.PaintEventHandler(this.datagrid_cliente_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 176);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 381);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_cargar);
            this.Controls.Add(this.datagrid_cliente);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.button_alta);
            this.Controls.Add(this.textBox_CP);
            this.Controls.Add(this.textBox_numero);
            this.Controls.Add(this.textBox_colonia);
            this.Controls.Add(this.textBox_calle);
            this.Controls.Add(this.textBox_ciudad);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_RFC);
            this.Controls.Add(this.textBox_pin);
            this.Controls.Add(this.textBox_credito);
            this.Controls.Add(this.textBox_apellido_materno);
            this.Controls.Add(this.textBox_apellido_paterno);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Gray;
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Cliente_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_apellido_paterno;
        private System.Windows.Forms.TextBox textBox_apellido_materno;
        private System.Windows.Forms.TextBox textBox_credito;
        private System.Windows.Forms.TextBox textBox_pin;
        private System.Windows.Forms.TextBox textBox_RFC;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.TextBox textBox_ciudad;
        private System.Windows.Forms.TextBox textBox_calle;
        private System.Windows.Forms.TextBox textBox_colonia;
        private System.Windows.Forms.TextBox textBox_numero;
        private System.Windows.Forms.TextBox textBox_CP;
        private System.Windows.Forms.Button button_cargar;
        private System.Windows.Forms.Button button_alta;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.DataGridView datagrid_cliente;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}