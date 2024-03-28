
namespace Login
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.textBoxContraeña = new System.Windows.Forms.TextBox();
            this.Imagenlogin = new System.Windows.Forms.PictureBox();
            this.ImagenCerrar = new System.Windows.Forms.PictureBox();
            this.labellogin = new System.Windows.Forms.Label();
            this.labelCompañia = new System.Windows.Forms.Label();
            this.imagenOjo = new System.Windows.Forms.PictureBox();
            this.ImagenOjo2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Imagenlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenOjo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenOjo2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("SF Compact Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(70, 229);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(180, 27);
            this.textBoxUsuario.TabIndex = 0;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelUsuario.Font = new System.Drawing.Font("Bree Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(45)))), ((int)(((byte)(35)))));
            this.labelUsuario.Location = new System.Drawing.Point(65, 198);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(83, 28);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.BackColor = System.Drawing.Color.Transparent;
            this.labelContraseña.Font = new System.Drawing.Font("Bree Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(45)))), ((int)(((byte)(35)))));
            this.labelContraseña.Location = new System.Drawing.Point(65, 276);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(116, 28);
            this.labelContraseña.TabIndex = 3;
            this.labelContraseña.Text = "Contraseña";
            this.labelContraseña.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxContraeña
            // 
            this.textBoxContraeña.Font = new System.Drawing.Font("SF Compact Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraeña.Location = new System.Drawing.Point(70, 307);
            this.textBoxContraeña.Name = "textBoxContraeña";
            this.textBoxContraeña.PasswordChar = '*';
            this.textBoxContraeña.Size = new System.Drawing.Size(180, 27);
            this.textBoxContraeña.TabIndex = 4;
            this.textBoxContraeña.UseSystemPasswordChar = true;
            this.textBoxContraeña.TextChanged += new System.EventHandler(this.textBoxContraeña_TextChanged);
            // 
            // Imagenlogin
            // 
            this.Imagenlogin.BackColor = System.Drawing.Color.Transparent;
            this.Imagenlogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.Imagenlogin.Image = ((System.Drawing.Image)(resources.GetObject("Imagenlogin.Image")));
            this.Imagenlogin.Location = new System.Drawing.Point(51, 340);
            this.Imagenlogin.Name = "Imagenlogin";
            this.Imagenlogin.Size = new System.Drawing.Size(238, 93);
            this.Imagenlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Imagenlogin.TabIndex = 5;
            this.Imagenlogin.TabStop = false;
            this.Imagenlogin.Click += new System.EventHandler(this.Imagenlogin_Click);
            // 
            // ImagenCerrar
            // 
            this.ImagenCerrar.BackColor = System.Drawing.Color.Transparent;
            this.ImagenCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImagenCerrar.Image = ((System.Drawing.Image)(resources.GetObject("ImagenCerrar.Image")));
            this.ImagenCerrar.Location = new System.Drawing.Point(290, 12);
            this.ImagenCerrar.Name = "ImagenCerrar";
            this.ImagenCerrar.Size = new System.Drawing.Size(58, 57);
            this.ImagenCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImagenCerrar.TabIndex = 7;
            this.ImagenCerrar.TabStop = false;
            this.ImagenCerrar.Click += new System.EventHandler(this.ImagenCerrar_Click);
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.BackColor = System.Drawing.Color.Transparent;
            this.labellogin.Font = new System.Drawing.Font("Budmo Jiggler", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(45)))), ((int)(((byte)(35)))));
            this.labellogin.Location = new System.Drawing.Point(61, 144);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(153, 54);
            this.labellogin.TabIndex = 9;
            this.labellogin.Text = "Login";
            // 
            // labelCompañia
            // 
            this.labelCompañia.AutoSize = true;
            this.labelCompañia.BackColor = System.Drawing.Color.Transparent;
            this.labelCompañia.Font = new System.Drawing.Font("Playfair Display SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompañia.ForeColor = System.Drawing.Color.OliveDrab;
            this.labelCompañia.Location = new System.Drawing.Point(215, 117);
            this.labelCompañia.Name = "labelCompañia";
            this.labelCompañia.Size = new System.Drawing.Size(98, 21);
            this.labelCompañia.TabIndex = 10;
            this.labelCompañia.Text = "OrgaFarm";
            // 
            // imagenOjo
            // 
            this.imagenOjo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.imagenOjo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagenOjo.Image = ((System.Drawing.Image)(resources.GetObject("imagenOjo.Image")));
            this.imagenOjo.Location = new System.Drawing.Point(247, 307);
            this.imagenOjo.Name = "imagenOjo";
            this.imagenOjo.Size = new System.Drawing.Size(42, 27);
            this.imagenOjo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagenOjo.TabIndex = 6;
            this.imagenOjo.TabStop = false;
            this.imagenOjo.Click += new System.EventHandler(this.imagenOjo_Click);
            // 
            // ImagenOjo2
            // 
            this.ImagenOjo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ImagenOjo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagenOjo2.Image = ((System.Drawing.Image)(resources.GetObject("ImagenOjo2.Image")));
            this.ImagenOjo2.Location = new System.Drawing.Point(247, 307);
            this.ImagenOjo2.Name = "ImagenOjo2";
            this.ImagenOjo2.Size = new System.Drawing.Size(42, 27);
            this.ImagenOjo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImagenOjo2.TabIndex = 8;
            this.ImagenOjo2.TabStop = false;
            this.ImagenOjo2.Click += new System.EventHandler(this.ImagenOjo2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cambiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(736, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCompañia);
            this.Controls.Add(this.labellogin);
            this.Controls.Add(this.ImagenOjo2);
            this.Controls.Add(this.ImagenCerrar);
            this.Controls.Add(this.imagenOjo);
            this.Controls.Add(this.Imagenlogin);
            this.Controls.Add(this.textBoxContraeña);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.textBoxUsuario);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Imagenlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenOjo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenOjo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox textBoxContraeña;
        private System.Windows.Forms.PictureBox Imagenlogin;
        private System.Windows.Forms.PictureBox ImagenCerrar;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.Label labelCompañia;
        private System.Windows.Forms.PictureBox imagenOjo;
        private System.Windows.Forms.PictureBox ImagenOjo2;
        private System.Windows.Forms.Button button1;
    }
}

