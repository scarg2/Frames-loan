namespace LoanManagerApp.Views
{
    partial class viewcliente
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
            this.binAddCustomer = new System.Windows.Forms.Button();
            this.btnEliminarC = new System.Windows.Forms.Button();
            this.btnEditarC = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warranty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // binAddCustomer
            // 
            this.binAddCustomer.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.binAddCustomer.Image = global::LoanManagerApp.Properties.Resources.agregar_usuario;
            this.binAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.binAddCustomer.Location = new System.Drawing.Point(108, 533);
            this.binAddCustomer.Name = "binAddCustomer";
            this.binAddCustomer.Size = new System.Drawing.Size(129, 40);
            this.binAddCustomer.TabIndex = 0;
            this.binAddCustomer.Text = "Agregar";
            this.binAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btnEliminarC
            // 
            this.btnEliminarC.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarC.Image = global::LoanManagerApp.Properties.Resources.dejar_de_seguir;
            this.btnEliminarC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarC.Location = new System.Drawing.Point(378, 533);
            this.btnEliminarC.Name = "btnEliminarC";
            this.btnEliminarC.Size = new System.Drawing.Size(163, 40);
            this.btnEliminarC.TabIndex = 1;
            this.btnEliminarC.Text = "Eliminar";
            this.btnEliminarC.UseVisualStyleBackColor = true;
            // 
            // btnEditarC
            // 
            this.btnEditarC.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarC.Image = global::LoanManagerApp.Properties.Resources.usuario;
            this.btnEditarC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarC.Location = new System.Drawing.Point(645, 533);
            this.btnEditarC.Name = "btnEditarC";
            this.btnEditarC.Size = new System.Drawing.Size(149, 40);
            this.btnEditarC.TabIndex = 2;
            this.btnEditarC.Text = "Editar";
            this.btnEditarC.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.Names,
            this.LastNames,
            this.DNI,
            this.Phone,
            this.Adress,
            this.Warranty});
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(920, 346);
            this.dataGridView1.TabIndex = 3;
            // 
            // CustomerId
            // 
            this.CustomerId.HeaderText = "Id Cliente";
            this.CustomerId.MinimumWidth = 6;
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Width = 125;
            // 
            // Names
            // 
            this.Names.HeaderText = "Nombre";
            this.Names.MinimumWidth = 6;
            this.Names.Name = "Names";
            this.Names.Width = 125;
            // 
            // LastNames
            // 
            this.LastNames.HeaderText = "Apellido";
            this.LastNames.MinimumWidth = 6;
            this.LastNames.Name = "LastNames";
            this.LastNames.Width = 125;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "Cédula";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            this.DNI.Width = 125;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Teléfono";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // Adress
            // 
            this.Adress.HeaderText = "Dirección";
            this.Adress.MinimumWidth = 6;
            this.Adress.Name = "Adress";
            this.Adress.Width = 125;
            // 
            // Warranty
            // 
            this.Warranty.HeaderText = "Garantia";
            this.Warranty.MinimumWidth = 6;
            this.Warranty.Name = "Warranty";
            this.Warranty.Width = 125;
            // 
            // label1
            // 
            this.label1.Image = global::LoanManagerApp.Properties.Resources.seo;
            this.label1.Location = new System.Drawing.Point(258, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(309, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 27);
            this.textBox1.TabIndex = 5;
            // 
            // viewcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(920, 601);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEditarC);
            this.Controls.Add(this.btnEliminarC);
            this.Controls.Add(this.binAddCustomer);
            this.Name = "viewcliente";
            this.Text = "viewcliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button binAddCustomer;
        private Button btnEliminarC;
        private Button btnEditarC;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CustomerId;
        private DataGridViewTextBoxColumn Names;
        private DataGridViewTextBoxColumn LastNames;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Adress;
        private DataGridViewTextBoxColumn Warranty;
        private Label label1;
        private TextBox textBox1;
    }
}