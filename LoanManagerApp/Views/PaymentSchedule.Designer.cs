namespace LoanManagerApp.Views
{
    partial class PaymentSchedule
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Principal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterestPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrincipalPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLoanId = new System.Windows.Forms.Label();
            this.txtLoanId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PsId,
            this.Status,
            this.Amount,
            this.Interest,
            this.Principal,
            this.AmountPaid,
            this.InterestPaid,
            this.PrincipalPaid,
            this.DatePaid,
            this.Date});
            this.dataGridView1.Location = new System.Drawing.Point(-6, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1269, 484);
            this.dataGridView1.TabIndex = 0;
            // 
            // PsId
            // 
            this.PsId.HeaderText = "Id Calendario";
            this.PsId.MinimumWidth = 6;
            this.PsId.Name = "PsId";
            this.PsId.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Estado";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Monto";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // Interest
            // 
            this.Interest.HeaderText = "Interes";
            this.Interest.MinimumWidth = 6;
            this.Interest.Name = "Interest";
            this.Interest.Width = 125;
            // 
            // Principal
            // 
            this.Principal.HeaderText = "Principal";
            this.Principal.MinimumWidth = 6;
            this.Principal.Name = "Principal";
            this.Principal.Width = 125;
            // 
            // AmountPaid
            // 
            this.AmountPaid.HeaderText = "Monto Pagado";
            this.AmountPaid.MinimumWidth = 6;
            this.AmountPaid.Name = "AmountPaid";
            this.AmountPaid.Width = 125;
            // 
            // InterestPaid
            // 
            this.InterestPaid.HeaderText = "Interes Pagado";
            this.InterestPaid.MinimumWidth = 6;
            this.InterestPaid.Name = "InterestPaid";
            this.InterestPaid.Width = 125;
            // 
            // PrincipalPaid
            // 
            this.PrincipalPaid.HeaderText = "Principal Pagado";
            this.PrincipalPaid.MinimumWidth = 6;
            this.PrincipalPaid.Name = "PrincipalPaid";
            this.PrincipalPaid.Width = 125;
            // 
            // DatePaid
            // 
            this.DatePaid.HeaderText = "Fecha pagado";
            this.DatePaid.MinimumWidth = 6;
            this.DatePaid.Name = "DatePaid";
            this.DatePaid.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Fecha de pago";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // lblLoanId
            // 
            this.lblLoanId.Image = global::LoanManagerApp.Properties.Resources.seo;
            this.lblLoanId.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLoanId.Location = new System.Drawing.Point(320, 68);
            this.lblLoanId.Name = "lblLoanId";
            this.lblLoanId.Size = new System.Drawing.Size(153, 25);
            this.lblLoanId.TabIndex = 1;
            this.lblLoanId.Text = "Id del préstamo:";
            // 
            // txtLoanId
            // 
            this.txtLoanId.Location = new System.Drawing.Point(479, 68);
            this.txtLoanId.Name = "txtLoanId";
            this.txtLoanId.Size = new System.Drawing.Size(228, 27);
            this.txtLoanId.TabIndex = 2;
            // 
            // PaymentSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1262, 620);
            this.Controls.Add(this.txtLoanId);
            this.Controls.Add(this.lblLoanId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PaymentSchedule";
            this.Text = "PaymentSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn PsId;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Interest;
        private DataGridViewTextBoxColumn Principal;
        private DataGridViewTextBoxColumn AmountPaid;
        private DataGridViewTextBoxColumn InterestPaid;
        private DataGridViewTextBoxColumn PrincipalPaid;
        private DataGridViewTextBoxColumn DatePaid;
        private DataGridViewTextBoxColumn Date;
        private Label lblLoanId;
        private TextBox txtLoanId;
    }
}