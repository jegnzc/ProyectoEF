namespace ExamenFinalPolizas
{
    partial class frmTipoCuenta
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
            this.dgvTipoDeCuentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoDeCuenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarTipoDeCuenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDeCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTipoDeCuentas
            // 
            this.dgvTipoDeCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoDeCuentas.Location = new System.Drawing.Point(12, 75);
            this.dgvTipoDeCuentas.Name = "dgvTipoDeCuentas";
            this.dgvTipoDeCuentas.Size = new System.Drawing.Size(612, 191);
            this.dgvTipoDeCuentas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(380, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Cuentas";
            // 
            // txtTipoDeCuenta
            // 
            this.txtTipoDeCuenta.Location = new System.Drawing.Point(658, 121);
            this.txtTipoDeCuenta.Name = "txtTipoDeCuenta";
            this.txtTipoDeCuenta.Size = new System.Drawing.Size(100, 20);
            this.txtTipoDeCuenta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(658, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo";
            // 
            // btnAgregarTipoDeCuenta
            // 
            this.btnAgregarTipoDeCuenta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarTipoDeCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTipoDeCuenta.Location = new System.Drawing.Point(670, 157);
            this.btnAgregarTipoDeCuenta.Name = "btnAgregarTipoDeCuenta";
            this.btnAgregarTipoDeCuenta.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarTipoDeCuenta.TabIndex = 4;
            this.btnAgregarTipoDeCuenta.Text = "Agregar";
            this.btnAgregarTipoDeCuenta.UseVisualStyleBackColor = false;
            this.btnAgregarTipoDeCuenta.Click += new System.EventHandler(this.btnAgregarTipoDeCuenta_Click);
            // 
            // frmTipoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExamenFinalPolizas.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(800, 302);
            this.Controls.Add(this.btnAgregarTipoDeCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTipoDeCuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTipoDeCuentas);
            this.Name = "frmTipoCuenta";
            this.Text = "frmTipoCuenta";
            this.Load += new System.EventHandler(this.frmTipoCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDeCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipoDeCuentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipoDeCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarTipoDeCuenta;
    }
}