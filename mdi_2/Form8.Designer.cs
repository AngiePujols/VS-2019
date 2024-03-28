
namespace mdi
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.dataGridViewVentas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CbNoVentas = new System.Windows.Forms.ComboBox();
            this.lbNo = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btVentas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboFechas = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewVentas
            // 
            this.dataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVentas.Location = new System.Drawing.Point(118, 352);
            this.dataGridViewVentas.Name = "dataGridViewVentas";
            this.dataGridViewVentas.Size = new System.Drawing.Size(702, 251);
            this.dataGridViewVentas.TabIndex = 0;
            this.dataGridViewVentas.Visible = false;
            this.dataGridViewVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(376, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 85);
            this.label2.TabIndex = 77;
            this.label2.Text = "VENTAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(781, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 40);
            this.pictureBox3.TabIndex = 98;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // CbNoVentas
            // 
            this.CbNoVentas.Font = new System.Drawing.Font("Louis George Café", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbNoVentas.FormattingEnabled = true;
            this.CbNoVentas.Location = new System.Drawing.Point(21, 44);
            this.CbNoVentas.Name = "CbNoVentas";
            this.CbNoVentas.Size = new System.Drawing.Size(131, 31);
            this.CbNoVentas.TabIndex = 108;
            this.CbNoVentas.Text = "Seleccionar";
            this.CbNoVentas.SelectedIndexChanged += new System.EventHandler(this.CbNoVentas_SelectedIndexChanged);
            this.CbNoVentas.Click += new System.EventHandler(this.CbNoVentas_Click);
            // 
            // lbNo
            // 
            this.lbNo.AutoSize = true;
            this.lbNo.BackColor = System.Drawing.Color.Transparent;
            this.lbNo.Font = new System.Drawing.Font("HONEY&JAM", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNo.Location = new System.Drawing.Point(24, 10);
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(118, 31);
            this.lbNo.TabIndex = 108;
            this.lbNo.Text = "No. Ventas";
            this.lbNo.Click += new System.EventHandler(this.lbNo_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.Plum;
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btBuscar.Font = new System.Drawing.Font("Bree Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.Color.Black;
            this.btBuscar.Location = new System.Drawing.Point(161, 81);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(95, 37);
            this.btBuscar.TabIndex = 105;
            this.btBuscar.Text = "Borrar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btVentas
            // 
            this.btVentas.BackColor = System.Drawing.Color.Plum;
            this.btVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btVentas.Font = new System.Drawing.Font("Bree Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVentas.ForeColor = System.Drawing.Color.Black;
            this.btVentas.Location = new System.Drawing.Point(171, 62);
            this.btVentas.Name = "btVentas";
            this.btVentas.Size = new System.Drawing.Size(95, 37);
            this.btVentas.TabIndex = 106;
            this.btVentas.Text = "Mostrar";
            this.btVentas.UseVisualStyleBackColor = false;
            this.btVentas.Click += new System.EventHandler(this.btVentas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("HONEY&JAM", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(360, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 48);
            this.label1.TabIndex = 103;
            this.label1.Text = "*Ingrese el ID de la Venta que \r\ndesea buscar*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.Plum;
            this.btAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btAceptar.Font = new System.Drawing.Font("Bree Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.ForeColor = System.Drawing.Color.Black;
            this.btAceptar.Location = new System.Drawing.Point(161, 38);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(95, 37);
            this.btAceptar.TabIndex = 102;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("HONEY&JAM", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(52, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 32);
            this.label3.TabIndex = 110;
            this.label3.Text = "Años";
            // 
            // ComboFechas
            // 
            this.ComboFechas.Font = new System.Drawing.Font("Louis George Café", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboFechas.FormattingEnabled = true;
            this.ComboFechas.Location = new System.Drawing.Point(27, 67);
            this.ComboFechas.Name = "ComboFechas";
            this.ComboFechas.Size = new System.Drawing.Size(131, 31);
            this.ComboFechas.TabIndex = 111;
            this.ComboFechas.Text = "Seleccionar";
            this.ComboFechas.Click += new System.EventHandler(this.ComboFechas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lbNo);
            this.panel1.Controls.Add(this.btAceptar);
            this.panel1.Controls.Add(this.btBuscar);
            this.panel1.Controls.Add(this.CbNoVentas);
            this.panel1.Location = new System.Drawing.Point(178, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 141);
            this.panel1.TabIndex = 112;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.btVentas);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ComboFechas);
            this.panel2.Location = new System.Drawing.Point(472, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 141);
            this.panel2.TabIndex = 113;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 690);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewVentas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox CbNoVentas;
        private System.Windows.Forms.Label lbNo;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboFechas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}