
namespace mdi
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.precio1TextBox = new System.Windows.Forms.TextBox();
            this.clientesComboBox = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.facturarButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.agregarButton2 = new System.Windows.Forms.Button();
            this.textBoxNo = new System.Windows.Forms.TextBox();
            this.lbNo = new System.Windows.Forms.Label();
            this.dGviewFactura = new System.Windows.Forms.DataGridView();
            this.btBuscar2 = new System.Windows.Forms.Button();
            this.textbNF = new System.Windows.Forms.TextBox();
            this.lbnumfac = new System.Windows.Forms.Label();
            this.BtEnviar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelDate = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.btEliminar = new System.Windows.Forms.Button();
            this.comboBoxEliminar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelUser1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGviewFactura)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTURACION";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("HONEY&JAM", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label9.Location = new System.Drawing.Point(33, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 32);
            this.label9.TabIndex = 6;
            this.label9.Text = "Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("HONEY&JAM", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 27);
            this.label8.TabIndex = 10;
            this.label8.Text = "Precio";
            this.label8.Visible = false;
            // 
            // precio1TextBox
            // 
            this.precio1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio1TextBox.Location = new System.Drawing.Point(41, 325);
            this.precio1TextBox.Name = "precio1TextBox";
            this.precio1TextBox.ReadOnly = true;
            this.precio1TextBox.Size = new System.Drawing.Size(96, 24);
            this.precio1TextBox.TabIndex = 11;
            this.precio1TextBox.Visible = false;
            // 
            // clientesComboBox
            // 
            this.clientesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesComboBox.FormattingEnabled = true;
            this.clientesComboBox.Items.AddRange(new object[] {
            "Luis Fernandez",
            "Maria Perez",
            "Lia Yaport",
            "Camila Mendez",
            "Angie Carrascoo"});
            this.clientesComboBox.Location = new System.Drawing.Point(39, 155);
            this.clientesComboBox.Name = "clientesComboBox";
            this.clientesComboBox.Size = new System.Drawing.Size(209, 28);
            this.clientesComboBox.TabIndex = 18;
            this.clientesComboBox.Text = "Seleccionar";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(159, 325);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(87, 24);
            this.textBox7.TabIndex = 21;
            this.textBox7.Text = " ";
            this.textBox7.Visible = false;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("HONEY&JAM", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 27);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cantidad";
            this.label4.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(719, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // facturarButton
            // 
            this.facturarButton.BackColor = System.Drawing.Color.LightSalmon;
            this.facturarButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.facturarButton.Font = new System.Drawing.Font("Bree Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturarButton.ForeColor = System.Drawing.Color.Black;
            this.facturarButton.Location = new System.Drawing.Point(932, 614);
            this.facturarButton.Name = "facturarButton";
            this.facturarButton.Size = new System.Drawing.Size(105, 38);
            this.facturarButton.TabIndex = 96;
            this.facturarButton.Text = "Facturar";
            this.facturarButton.UseVisualStyleBackColor = false;
            this.facturarButton.Click += new System.EventHandler(this.facturarButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1047, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 40);
            this.pictureBox3.TabIndex = 97;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Items.AddRange(new object[] {
            "Luis Fernandez",
            "Maria Perez",
            "Lia Yaport",
            "Camila Mendez",
            "Angie Carrascoo"});
            this.comboBoxProductos.Location = new System.Drawing.Point(39, 236);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(207, 28);
            this.comboBoxProductos.TabIndex = 98;
            this.comboBoxProductos.Text = "Seleccionar";
            this.comboBoxProductos.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductos_SelectedIndexChanged);
            this.comboBoxProductos.SelectionChangeCommitted += new System.EventHandler(this.comboBoxProductos_SelectionChangeCommitted_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("HONEY&JAM", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 32);
            this.label5.TabIndex = 99;
            this.label5.Text = "Productos";
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.LightPink;
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btBuscar.Font = new System.Drawing.Font("Bree Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.Color.Black;
            this.btBuscar.Location = new System.Drawing.Point(265, 208);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(115, 42);
            this.btBuscar.TabIndex = 100;
            this.btBuscar.Text = "Aceptar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // agregarButton2
            // 
            this.agregarButton2.BackColor = System.Drawing.Color.LightSalmon;
            this.agregarButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.agregarButton2.Font = new System.Drawing.Font("Bree Serif", 16F);
            this.agregarButton2.ForeColor = System.Drawing.Color.Black;
            this.agregarButton2.Location = new System.Drawing.Point(265, 297);
            this.agregarButton2.Name = "agregarButton2";
            this.agregarButton2.Size = new System.Drawing.Size(119, 52);
            this.agregarButton2.TabIndex = 103;
            this.agregarButton2.Text = "Agregar";
            this.agregarButton2.UseVisualStyleBackColor = false;
            this.agregarButton2.Visible = false;
            this.agregarButton2.Click += new System.EventHandler(this.agregarButton2_Click);
            // 
            // textBoxNo
            // 
            this.textBoxNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNo.Location = new System.Drawing.Point(301, 155);
            this.textBoxNo.Name = "textBoxNo";
            this.textBoxNo.ReadOnly = true;
            this.textBoxNo.Size = new System.Drawing.Size(74, 24);
            this.textBoxNo.TabIndex = 107;
            this.textBoxNo.Enter += new System.EventHandler(this.textBoxNo_Enter);
            this.textBoxNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNo_KeyPress);
            // 
            // lbNo
            // 
            this.lbNo.AutoSize = true;
            this.lbNo.BackColor = System.Drawing.Color.Transparent;
            this.lbNo.Font = new System.Drawing.Font("HONEY&JAM", 24F, System.Drawing.FontStyle.Bold);
            this.lbNo.Location = new System.Drawing.Point(259, 149);
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(49, 32);
            this.lbNo.TabIndex = 106;
            this.lbNo.Text = "No.";
            // 
            // dGviewFactura
            // 
            this.dGviewFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGviewFactura.Location = new System.Drawing.Point(20, 391);
            this.dGviewFactura.Name = "dGviewFactura";
            this.dGviewFactura.Size = new System.Drawing.Size(892, 274);
            this.dGviewFactura.TabIndex = 108;
            this.dGviewFactura.Visible = false;
            // 
            // btBuscar2
            // 
            this.btBuscar2.BackColor = System.Drawing.Color.LightSalmon;
            this.btBuscar2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btBuscar2.Font = new System.Drawing.Font("Bree Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar2.ForeColor = System.Drawing.Color.Black;
            this.btBuscar2.Location = new System.Drawing.Point(932, 403);
            this.btBuscar2.Name = "btBuscar2";
            this.btBuscar2.Size = new System.Drawing.Size(105, 38);
            this.btBuscar2.TabIndex = 109;
            this.btBuscar2.Text = "Buscar";
            this.btBuscar2.UseVisualStyleBackColor = false;
            this.btBuscar2.Click += new System.EventHandler(this.btBuscar2_Click);
            this.btBuscar2.MouseHover += new System.EventHandler(this.btBuscar2_MouseHover);
            // 
            // textbNF
            // 
            this.textbNF.Location = new System.Drawing.Point(938, 471);
            this.textbNF.Name = "textbNF";
            this.textbNF.Size = new System.Drawing.Size(90, 22);
            this.textbNF.TabIndex = 111;
            this.textbNF.Text = " ";
            this.textbNF.Visible = false;
            this.textbNF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbNF_KeyPress);
            // 
            // lbnumfac
            // 
            this.lbnumfac.AutoSize = true;
            this.lbnumfac.BackColor = System.Drawing.Color.Transparent;
            this.lbnumfac.Font = new System.Drawing.Font("HONEY&JAM", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnumfac.Location = new System.Drawing.Point(928, 444);
            this.lbnumfac.Name = "lbnumfac";
            this.lbnumfac.Size = new System.Drawing.Size(100, 24);
            this.lbnumfac.TabIndex = 110;
            this.lbnumfac.Text = " No.Factura";
            this.lbnumfac.Visible = false;
            // 
            // BtEnviar
            // 
            this.BtEnviar.BackColor = System.Drawing.Color.LightSalmon;
            this.BtEnviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtEnviar.Font = new System.Drawing.Font("Bree Serif", 11F);
            this.BtEnviar.ForeColor = System.Drawing.Color.Black;
            this.BtEnviar.Location = new System.Drawing.Point(1034, 467);
            this.BtEnviar.Name = "BtEnviar";
            this.BtEnviar.Size = new System.Drawing.Size(63, 29);
            this.BtEnviar.TabIndex = 112;
            this.BtEnviar.Text = "Enviar";
            this.BtEnviar.UseVisualStyleBackColor = false;
            this.BtEnviar.Visible = false;
            this.BtEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.LabelDate);
            this.panel2.Controls.Add(this.labelFecha);
            this.panel2.Location = new System.Drawing.Point(719, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 42);
            this.panel2.TabIndex = 114;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Bree Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.Location = new System.Drawing.Point(50, 11);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(77, 20);
            this.LabelDate.TabIndex = 1;
            this.LabelDate.Text = "LabelDate";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Bree Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(3, 11);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(52, 20);
            this.labelFecha.TabIndex = 0;
            this.labelFecha.Text = "Fecha:";
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.LightSalmon;
            this.btEliminar.Enabled = false;
            this.btEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btEliminar.Font = new System.Drawing.Font("Bree Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.ForeColor = System.Drawing.Color.Black;
            this.btEliminar.Location = new System.Drawing.Point(932, 506);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(105, 38);
            this.btEliminar.TabIndex = 115;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // comboBoxEliminar
            // 
            this.comboBoxEliminar.FormattingEnabled = true;
            this.comboBoxEliminar.Items.AddRange(new object[] {
            "Luis Fernandez",
            "Maria Perez",
            "Lia Yaport",
            "Camila Mendez",
            "Angie Carrascoo"});
            this.comboBoxEliminar.Location = new System.Drawing.Point(938, 574);
            this.comboBoxEliminar.Name = "comboBoxEliminar";
            this.comboBoxEliminar.Size = new System.Drawing.Size(136, 24);
            this.comboBoxEliminar.TabIndex = 116;
            this.comboBoxEliminar.Text = "Seleccionar";
            this.comboBoxEliminar.Visible = false;
            this.comboBoxEliminar.Click += new System.EventHandler(this.comboBoxEliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("HONEY&JAM", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(934, 547);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 117;
            this.label6.Text = "Productos";
            this.label6.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.LabelUser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(923, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 42);
            this.panel1.TabIndex = 115;
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Font = new System.Drawing.Font("Bree Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUser.Location = new System.Drawing.Point(67, 11);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(76, 20);
            this.LabelUser.TabIndex = 1;
            this.LabelUser.Text = "LabelUser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bree Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuario:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.LabelUser1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(923, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 42);
            this.panel3.TabIndex = 115;
            // 
            // LabelUser1
            // 
            this.LabelUser1.AutoSize = true;
            this.LabelUser1.Font = new System.Drawing.Font("Bree Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUser1.Location = new System.Drawing.Point(67, 11);
            this.LabelUser1.Name = "LabelUser1";
            this.LabelUser1.Size = new System.Drawing.Size(76, 20);
            this.LabelUser1.TabIndex = 1;
            this.LabelUser1.Text = "LabelUser";
            this.LabelUser1.Click += new System.EventHandler(this.LabelUser1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bree Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Usuario:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1123, 677);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxEliminar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtEnviar);
            this.Controls.Add(this.textbNF);
            this.Controls.Add(this.lbnumfac);
            this.Controls.Add(this.btBuscar2);
            this.Controls.Add(this.dGviewFactura);
            this.Controls.Add(this.textBoxNo);
            this.Controls.Add(this.lbNo);
            this.Controls.Add(this.agregarButton2);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxProductos);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.facturarButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clientesComboBox);
            this.Controls.Add(this.precio1TextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGviewFactura)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox precio1TextBox;
        private System.Windows.Forms.ComboBox clientesComboBox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button facturarButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox comboBoxProductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button agregarButton2;
        private System.Windows.Forms.TextBox textBoxNo;
        private System.Windows.Forms.Label lbNo;
        private System.Windows.Forms.DataGridView dGviewFactura;
        private System.Windows.Forms.Button btBuscar2;
        private System.Windows.Forms.TextBox textbNF;
        private System.Windows.Forms.Label lbnumfac;
        private System.Windows.Forms.Button BtEnviar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.ComboBox comboBoxEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabelUser1;
        private System.Windows.Forms.Label label7;
    }
}