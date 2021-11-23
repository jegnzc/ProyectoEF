namespace ExamenFinalPolizas
{
    partial class frmExamenFinal
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitácoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pólizasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pólizasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(700, 0);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seguridadToolStripMenuItem,
            this.pólizasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitácoraToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // bitácoraToolStripMenuItem
            // 
            this.bitácoraToolStripMenuItem.Name = "bitácoraToolStripMenuItem";
            this.bitácoraToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.bitácoraToolStripMenuItem.Text = "Bitácora";
            this.bitácoraToolStripMenuItem.Click += new System.EventHandler(this.bitácoraToolStripMenuItem_Click);
            // 
            // pólizasToolStripMenuItem
            // 
            this.pólizasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeCuentasToolStripMenuItem,
            this.pólizasToolStripMenuItem1});
            this.pólizasToolStripMenuItem.Name = "pólizasToolStripMenuItem";
            this.pólizasToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.pólizasToolStripMenuItem.Text = "Pólizas";
            // 
            // tipoDeCuentasToolStripMenuItem
            // 
            this.tipoDeCuentasToolStripMenuItem.Name = "tipoDeCuentasToolStripMenuItem";
            this.tipoDeCuentasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoDeCuentasToolStripMenuItem.Text = "Tipo de Cuentas";
            this.tipoDeCuentasToolStripMenuItem.Click += new System.EventHandler(this.tipoDeCuentasToolStripMenuItem_Click);
            // 
            // pólizasToolStripMenuItem1
            // 
            this.pólizasToolStripMenuItem1.Name = "pólizasToolStripMenuItem1";
            this.pólizasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pólizasToolStripMenuItem1.Text = "Pólizas";
            this.pólizasToolStripMenuItem1.Click += new System.EventHandler(this.pólizasToolStripMenuItem1_Click);
            // 
            // frmExamenFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExamenFinalPolizas.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmExamenFinal";
            this.Text = "frmExamenFinal";
            this.Load += new System.EventHandler(this.ExamenFinal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitácoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pólizasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeCuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pólizasToolStripMenuItem1;
    }
}

