namespace TicketVendingMachine
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTicketType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numTickets = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.rdoCreditCard = new System.Windows.Forms.RadioButton();
            this.rdoMobilePayment = new System.Windows.Forms.RadioButton();
            this.bt1 = new System.Windows.Forms.Button();
            this.lblTicketId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTicketId);
            this.groupBox1.Controls.Add(this.bt1);
            this.groupBox1.Controls.Add(this.rdoMobilePayment);
            this.groupBox1.Controls.Add(this.rdoCreditCard);
            this.groupBox1.Controls.Add(this.rdoCash);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numTickets);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboTicketType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket type";
            // 
            // cboTicketType
            // 
            this.cboTicketType.FormattingEnabled = true;
            this.cboTicketType.Items.AddRange(new object[] {
            "One-way",
            "Round-trip ",
            "Day pass",
            "Weekly or monthly pass"});
            this.cboTicketType.Location = new System.Drawing.Point(72, 24);
            this.cboTicketType.Name = "cboTicketType";
            this.cboTicketType.Size = new System.Drawing.Size(121, 21);
            this.cboTicketType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of ticket(s)";
            // 
            // numTickets
            // 
            this.numTickets.Location = new System.Drawing.Point(473, 22);
            this.numTickets.Name = "numTickets";
            this.numTickets.Size = new System.Drawing.Size(121, 20);
            this.numTickets.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payment method";
            // 
            // rdoCash
            // 
            this.rdoCash.AutoSize = true;
            this.rdoCash.Location = new System.Drawing.Point(114, 70);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(49, 17);
            this.rdoCash.TabIndex = 5;
            this.rdoCash.TabStop = true;
            this.rdoCash.Text = "Cash";
            this.rdoCash.UseVisualStyleBackColor = true;
            // 
            // rdoCreditCard
            // 
            this.rdoCreditCard.AutoSize = true;
            this.rdoCreditCard.Location = new System.Drawing.Point(114, 93);
            this.rdoCreditCard.Name = "rdoCreditCard";
            this.rdoCreditCard.Size = new System.Drawing.Size(77, 17);
            this.rdoCreditCard.TabIndex = 6;
            this.rdoCreditCard.TabStop = true;
            this.rdoCreditCard.Text = "Credit Card";
            this.rdoCreditCard.UseVisualStyleBackColor = true;
            // 
            // rdoMobilePayment
            // 
            this.rdoMobilePayment.AutoSize = true;
            this.rdoMobilePayment.Location = new System.Drawing.Point(114, 116);
            this.rdoMobilePayment.Name = "rdoMobilePayment";
            this.rdoMobilePayment.Size = new System.Drawing.Size(54, 17);
            this.rdoMobilePayment.TabIndex = 7;
            this.rdoMobilePayment.TabStop = true;
            this.rdoMobilePayment.Text = "Momo";
            this.rdoMobilePayment.UseVisualStyleBackColor = true;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(374, 103);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(93, 43);
            this.bt1.TabIndex = 10;
            this.bt1.Text = "Purchase";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.PurchaseTicket_Click);
            // 
            // lblTicketId
            // 
            this.lblTicketId.AutoSize = true;
            this.lblTicketId.Location = new System.Drawing.Point(371, 70);
            this.lblTicketId.Name = "lblTicketId";
            this.lblTicketId.Size = new System.Drawing.Size(51, 13);
            this.lblTicketId.TabIndex = 11;
            this.lblTicketId.Text = "Ticket ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ticket Vendor Machine";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoMobilePayment;
        private System.Windows.Forms.RadioButton rdoCreditCard;
        private System.Windows.Forms.RadioButton rdoCash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTickets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTicketType;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Label lblTicketId;
    }
}

