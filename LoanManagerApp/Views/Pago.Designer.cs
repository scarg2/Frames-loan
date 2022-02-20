namespace LoanManagerApp.Views
{
    partial class Pago
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPagoInteres = new System.Windows.Forms.TextBox();
            this.txtMontoRecibido = new System.Windows.Forms.TextBox();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.txtPagoPrincipal = new System.Windows.Forms.TextBox();
            this.btnGuardarP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdPrestamo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto recibido:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de pago:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(44, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pago principal:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(44, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pago interes:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Hug Me Tight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Image = global::LoanManagerApp.Properties.Resources.metodo_de_pago;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(162, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 30);
            this.label9.TabIndex = 16;
            this.label9.Text = "Datos del pago";
            // 
            // txtPagoInteres
            // 
            this.txtPagoInteres.Location = new System.Drawing.Point(203, 257);
            this.txtPagoInteres.Name = "txtPagoInteres";
            this.txtPagoInteres.Size = new System.Drawing.Size(232, 25);
            this.txtPagoInteres.TabIndex = 21;
            // 
            // txtMontoRecibido
            // 
            this.txtMontoRecibido.Location = new System.Drawing.Point(203, 76);
            this.txtMontoRecibido.Name = "txtMontoRecibido";
            this.txtMontoRecibido.Size = new System.Drawing.Size(232, 25);
            this.txtMontoRecibido.TabIndex = 23;
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(203, 132);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(232, 28);
            this.cmbTipoPago.TabIndex = 30;
            // 
            // txtPagoPrincipal
            // 
            this.txtPagoPrincipal.Location = new System.Drawing.Point(203, 195);
            this.txtPagoPrincipal.Name = "txtPagoPrincipal";
            this.txtPagoPrincipal.Size = new System.Drawing.Size(232, 25);
            this.txtPagoPrincipal.TabIndex = 31;
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.Image = global::LoanManagerApp.Properties.Resources.disquete;
            this.btnGuardarP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarP.Location = new System.Drawing.Point(162, 424);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Size = new System.Drawing.Size(137, 41);
            this.btnGuardarP.TabIndex = 33;
            this.btnGuardarP.Text = "Guardar";
            this.btnGuardarP.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Id préstamo:";
            // 
            // txtIdPrestamo
            // 
            this.txtIdPrestamo.Location = new System.Drawing.Point(203, 317);
            this.txtIdPrestamo.Name = "txtIdPrestamo";
            this.txtIdPrestamo.Size = new System.Drawing.Size(232, 25);
            this.txtIdPrestamo.TabIndex = 35;
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(170)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(500, 593);
            this.Controls.Add(this.txtIdPrestamo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuardarP);
            this.Controls.Add(this.txtPagoPrincipal);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(this.txtMontoRecibido);
            this.Controls.Add(this.txtPagoInteres);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Pago";
            this.Text = "Pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label9;
        private TextBox txtPagoInteres;
        private TextBox txtMontoRecibido;
        private ComboBox cmbTipoPago;
        private TextBox txtPagoPrincipal;
        private Button btnGuardarP;
        private Label label5;
        private TextBox txtIdPrestamo;
    }
}