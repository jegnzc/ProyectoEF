namespace ExamenFinalPolizas.Vista
{
    partial class frmPoliza
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoDeOperacion = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvPolizaDetalles = new System.Windows.Forms.DataGridView();
            this.cboCuenta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnAgregarDetalleDePoliza = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizaDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Concepto";
            // 
            // cboTipoDeOperacion
            // 
            this.cboTipoDeOperacion.FormattingEnabled = true;
            this.cboTipoDeOperacion.Location = new System.Drawing.Point(300, 118);
            this.cboTipoDeOperacion.Name = "cboTipoDeOperacion";
            this.cboTipoDeOperacion.Size = new System.Drawing.Size(121, 21);
            this.cboTipoDeOperacion.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dgvPolizaDetalles
            // 
            this.dgvPolizaDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolizaDetalles.Location = new System.Drawing.Point(63, 155);
            this.dgvPolizaDetalles.Name = "dgvPolizaDetalles";
            this.dgvPolizaDetalles.Size = new System.Drawing.Size(478, 150);
            this.dgvPolizaDetalles.TabIndex = 6;
            // 
            // cboCuenta
            // 
            this.cboCuenta.FormattingEnabled = true;
            this.cboCuenta.Location = new System.Drawing.Point(156, 118);
            this.cboCuenta.Name = "cboCuenta";
            this.cboCuenta.Size = new System.Drawing.Size(121, 21);
            this.cboCuenta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo de Operación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(446, 119);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 10;
            // 
            // btnAgregarDetalleDePoliza
            // 
            this.btnAgregarDetalleDePoliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetalleDePoliza.Location = new System.Drawing.Point(559, 115);
            this.btnAgregarDetalleDePoliza.Name = "btnAgregarDetalleDePoliza";
            this.btnAgregarDetalleDePoliza.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDetalleDePoliza.TabIndex = 11;
            this.btnAgregarDetalleDePoliza.Text = "Agregar";
            this.btnAgregarDetalleDePoliza.UseVisualStyleBackColor = true;
            this.btnAgregarDetalleDePoliza.Click += new System.EventHandler(this.btnAgregarDetalleDePoliza_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(570, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(470, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pólizas Contables";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(46, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Póliza";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Emisión";
            // 
            // frmPoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExamenFinalPolizas.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(738, 317);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregarDetalleDePoliza);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPolizaDetalles);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cboTipoDeOperacion);
            this.Controls.Add(this.cboCuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "frmPoliza";
            this.Text = "frmPoliza";
            this.Load += new System.EventHandler(this.frmPoliza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizaDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoDeOperacion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvPolizaDetalles;
        private System.Windows.Forms.ComboBox cboCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnAgregarDetalleDePoliza;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}