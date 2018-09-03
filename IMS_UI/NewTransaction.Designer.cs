namespace IMS_UI
{
    partial class NewTransaction
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nBoughtSoldTextbox = new System.Windows.Forms.TextBox();
            this.transactionPriceLavel = new System.Windows.Forms.Label();
            this.transactionPriceTextbox = new System.Windows.Forms.TextBox();
            this.transactionTypeLabel = new System.Windows.Forms.Label();
            this.transactionTypeCombobox = new System.Windows.Forms.ComboBox();
            this.transactionDetailsLabel = new System.Windows.Forms.Label();
            this.transactionDetailsTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(12, 335);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(494, 39);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.TabStop = false;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(12, 275);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(494, 39);
            this.addButton.TabIndex = 24;
            this.addButton.Text = "Add ";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Number bought/sold";
            // 
            // nBoughtSoldTextbox
            // 
            this.nBoughtSoldTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nBoughtSoldTextbox.Location = new System.Drawing.Point(189, 219);
            this.nBoughtSoldTextbox.MaxLength = 5;
            this.nBoughtSoldTextbox.Name = "nBoughtSoldTextbox";
            this.nBoughtSoldTextbox.Size = new System.Drawing.Size(132, 25);
            this.nBoughtSoldTextbox.TabIndex = 22;
            // 
            // transactionPriceLavel
            // 
            this.transactionPriceLavel.AutoSize = true;
            this.transactionPriceLavel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionPriceLavel.Location = new System.Drawing.Point(324, 199);
            this.transactionPriceLavel.Name = "transactionPriceLavel";
            this.transactionPriceLavel.Size = new System.Drawing.Size(106, 17);
            this.transactionPriceLavel.TabIndex = 21;
            this.transactionPriceLavel.Text = "Transaction Price";
            // 
            // transactionPriceTextbox
            // 
            this.transactionPriceTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionPriceTextbox.Location = new System.Drawing.Point(327, 219);
            this.transactionPriceTextbox.MaxLength = 20;
            this.transactionPriceTextbox.Name = "transactionPriceTextbox";
            this.transactionPriceTextbox.Size = new System.Drawing.Size(179, 25);
            this.transactionPriceTextbox.TabIndex = 20;
            // 
            // transactionTypeLabel
            // 
            this.transactionTypeLabel.AutoSize = true;
            this.transactionTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionTypeLabel.Location = new System.Drawing.Point(9, 199);
            this.transactionTypeLabel.Name = "transactionTypeLabel";
            this.transactionTypeLabel.Size = new System.Drawing.Size(105, 17);
            this.transactionTypeLabel.TabIndex = 19;
            this.transactionTypeLabel.Text = "Transaction Type";
            // 
            // transactionTypeCombobox
            // 
            this.transactionTypeCombobox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionTypeCombobox.FormattingEnabled = true;
            this.transactionTypeCombobox.Location = new System.Drawing.Point(12, 219);
            this.transactionTypeCombobox.Name = "transactionTypeCombobox";
            this.transactionTypeCombobox.Size = new System.Drawing.Size(171, 25);
            this.transactionTypeCombobox.TabIndex = 18;
            // 
            // transactionDetailsLabel
            // 
            this.transactionDetailsLabel.AutoSize = true;
            this.transactionDetailsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionDetailsLabel.Location = new System.Drawing.Point(9, 13);
            this.transactionDetailsLabel.Name = "transactionDetailsLabel";
            this.transactionDetailsLabel.Size = new System.Drawing.Size(117, 17);
            this.transactionDetailsLabel.TabIndex = 17;
            this.transactionDetailsLabel.Text = "Transaction Details";
            // 
            // transactionDetailsTextbox
            // 
            this.transactionDetailsTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionDetailsTextbox.Location = new System.Drawing.Point(12, 33);
            this.transactionDetailsTextbox.MaxLength = 500;
            this.transactionDetailsTextbox.Multiline = true;
            this.transactionDetailsTextbox.Name = "transactionDetailsTextbox";
            this.transactionDetailsTextbox.Size = new System.Drawing.Size(494, 143);
            this.transactionDetailsTextbox.TabIndex = 16;
            this.transactionDetailsTextbox.TextChanged += new System.EventHandler(this.transactionDetailsTextbox_TextChanged);
            // 
            // NewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 393);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nBoughtSoldTextbox);
            this.Controls.Add(this.transactionPriceLavel);
            this.Controls.Add(this.transactionPriceTextbox);
            this.Controls.Add(this.transactionTypeLabel);
            this.Controls.Add(this.transactionTypeCombobox);
            this.Controls.Add(this.transactionDetailsLabel);
            this.Controls.Add(this.transactionDetailsTextbox);
            this.MaximizeBox = false;
            this.Name = "NewTransaction";
            this.Text = "NewTransaction";
            this.Load += new System.EventHandler(this.NewTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nBoughtSoldTextbox;
        private System.Windows.Forms.Label transactionPriceLavel;
        private System.Windows.Forms.TextBox transactionPriceTextbox;
        private System.Windows.Forms.Label transactionTypeLabel;
        private System.Windows.Forms.ComboBox transactionTypeCombobox;
        private System.Windows.Forms.Label transactionDetailsLabel;
        private System.Windows.Forms.TextBox transactionDetailsTextbox;
    }
}