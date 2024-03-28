
namespace Menu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Inicio = new System.Windows.Forms.ToolStripMenuItem();
            this.Operaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.Ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.Guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.Restar = new System.Windows.Forms.ToolStripMenuItem();
            this.Sumar = new System.Windows.Forms.ToolStripMenuItem();
            this.Dividir = new System.Windows.Forms.ToolStripMenuItem();
            this.Multiplicar = new System.Windows.Forms.ToolStripMenuItem();
            this.Temaacerde = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Inicio,
            this.Operaciones,
            this.Ayuda,
            this.Salir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Inicio
            // 
            this.Inicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nuevo,
            this.Guardar});
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(48, 20);
            this.Inicio.Text = "Inicio";
            // 
            // Operaciones
            // 
            this.Operaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Restar,
            this.Sumar,
            this.Dividir,
            this.Multiplicar});
            this.Operaciones.Name = "Operaciones";
            this.Operaciones.Size = new System.Drawing.Size(85, 20);
            this.Operaciones.Text = "Operaciones";
            // 
            // Ayuda
            // 
            this.Ayuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Temaacerde});
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(53, 20);
            this.Ayuda.Text = "Ayuda";
            // 
            // Salir
            // 
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(41, 20);
            this.Salir.Text = "Salir";
            // 
            // Nuevo
            // 
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(116, 22);
            this.Nuevo.Text = "Nuevo";
            // 
            // Guardar
            // 
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(116, 22);
            this.Guardar.Text = "Guardar";
            // 
            // Restar
            // 
            this.Restar.Name = "Restar";
            this.Restar.Size = new System.Drawing.Size(131, 22);
            this.Restar.Text = "Restar";
            // 
            // Sumar
            // 
            this.Sumar.Name = "Sumar";
            this.Sumar.Size = new System.Drawing.Size(131, 22);
            this.Sumar.Text = "Sumar";
            // 
            // Dividir
            // 
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(131, 22);
            this.Dividir.Text = "Dividir";
            // 
            // Multiplicar
            // 
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(131, 22);
            this.Multiplicar.Text = "Multiplicar";
            // 
            // Temaacerde
            // 
            this.Temaacerde.Name = "Temaacerde";
            this.Temaacerde.Size = new System.Drawing.Size(137, 22);
            this.Temaacerde.Text = "Temaacerde";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Inicio;
        private System.Windows.Forms.ToolStripMenuItem Operaciones;
        private System.Windows.Forms.ToolStripMenuItem Ayuda;
        private System.Windows.Forms.ToolStripMenuItem Salir;
        private System.Windows.Forms.ToolStripMenuItem Nuevo;
        private System.Windows.Forms.ToolStripMenuItem Guardar;
        private System.Windows.Forms.ToolStripMenuItem Restar;
        private System.Windows.Forms.ToolStripMenuItem Sumar;
        private System.Windows.Forms.ToolStripMenuItem Dividir;
        private System.Windows.Forms.ToolStripMenuItem Multiplicar;
        private System.Windows.Forms.ToolStripMenuItem Temaacerde;
    }
}

