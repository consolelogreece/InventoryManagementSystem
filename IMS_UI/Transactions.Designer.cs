namespace IMS_UI
{
    partial class Transactions
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
            this.transactionsListView = new System.Windows.Forms.ListView();
            this.transactionDateTextbox = new System.Windows.Forms.TextBox();
            this.transactionDateLabel = new System.Windows.Forms.Label();
            this.nameParentProductTextbox = new System.Windows.Forms.TextBox();
            this.nameParentProductLabel = new System.Windows.Forms.Label();
            this.transactionDescriptionTextbox = new System.Windows.Forms.TextBox();
            this.transactionDescriptionLabel = new System.Windows.Forms.Label();
            this.transactionTypeCombobox = new System.Windows.Forms.ComboBox();
            this.transactionTypeLabel = new System.Windows.Forms.Label();
            this.transactionPriceTextbox = new System.Windows.Forms.TextBox();
            this.transactionPriceLavel = new System.Windows.Forms.Label();
            this.transactionsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nBoughtSoldTextbox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.pageLeft = new System.Windows.Forms.Button();
            this.pageRight = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.pageNo = new System.Windows.Forms.Label();
            this.pageNoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // transactionsListView
            // 
            this.transactionsListView.Location = new System.Drawing.Point(12, 45);
            this.transactionsListView.MultiSelect = false;
            this.transactionsListView.Name = "transactionsListView";
            this.transactionsListView.Size = new System.Drawing.Size(392, 397);
            this.transactionsListView.TabIndex = 0;
            this.transactionsListView.UseCompatibleStateImageBehavior = false;
            this.transactionsListView.DoubleClick += new System.EventHandler(this.transactionsListView_DoubleClick);
            // 
            // transactionDateTextbox
            // 
            this.transactionDateTextbox.Enabled = false;
            this.transactionDateTextbox.Location = new System.Drawing.Point(739, 32);
            this.transactionDateTextbox.MaxLength = 100;
            this.transactionDateTextbox.Name = "transactionDateTextbox";
            this.transactionDateTextbox.Size = new System.Drawing.Size(182, 25);
            this.transactionDateTextbox.TabIndex = 1;
            // 
            // transactionDateLabel
            // 
            this.transactionDateLabel.AutoSize = true;
            this.transactionDateLabel.Location = new System.Drawing.Point(736, 12);
            this.transactionDateLabel.Name = "transactionDateLabel";
            this.transactionDateLabel.Size = new System.Drawing.Size(105, 17);
            this.transactionDateLabel.TabIndex = 2;
            this.transactionDateLabel.Text = "Transaction Date";
            // 
            // nameParentProductTextbox
            // 
            this.nameParentProductTextbox.Enabled = false;
            this.nameParentProductTextbox.Location = new System.Drawing.Point(427, 32);
            this.nameParentProductTextbox.MaxLength = 400;
            this.nameParentProductTextbox.Name = "nameParentProductTextbox";
            this.nameParentProductTextbox.Size = new System.Drawing.Size(306, 25);
            this.nameParentProductTextbox.TabIndex = 3;
            // 
            // nameParentProductLabel
            // 
            this.nameParentProductLabel.AutoSize = true;
            this.nameParentProductLabel.Location = new System.Drawing.Point(424, 12);
            this.nameParentProductLabel.Name = "nameParentProductLabel";
            this.nameParentProductLabel.Size = new System.Drawing.Size(101, 17);
            this.nameParentProductLabel.TabIndex = 4;
            this.nameParentProductLabel.Text = "Name of parent";
            // 
            // transactionDescriptionTextbox
            // 
            this.transactionDescriptionTextbox.Location = new System.Drawing.Point(427, 101);
            this.transactionDescriptionTextbox.MaxLength = 500;
            this.transactionDescriptionTextbox.Multiline = true;
            this.transactionDescriptionTextbox.Name = "transactionDescriptionTextbox";
            this.transactionDescriptionTextbox.Size = new System.Drawing.Size(494, 143);
            this.transactionDescriptionTextbox.TabIndex = 5;
            // 
            // transactionDescriptionLabel
            // 
            this.transactionDescriptionLabel.AutoSize = true;
            this.transactionDescriptionLabel.Location = new System.Drawing.Point(424, 81);
            this.transactionDescriptionLabel.Name = "transactionDescriptionLabel";
            this.transactionDescriptionLabel.Size = new System.Drawing.Size(141, 17);
            this.transactionDescriptionLabel.TabIndex = 6;
            this.transactionDescriptionLabel.Text = "Transaction Descripton";
            // 
            // transactionTypeCombobox
            // 
            this.transactionTypeCombobox.FormattingEnabled = true;
            this.transactionTypeCombobox.Location = new System.Drawing.Point(427, 287);
            this.transactionTypeCombobox.Name = "transactionTypeCombobox";
            this.transactionTypeCombobox.Size = new System.Drawing.Size(171, 25);
            this.transactionTypeCombobox.TabIndex = 7;
            // 
            // transactionTypeLabel
            // 
            this.transactionTypeLabel.AutoSize = true;
            this.transactionTypeLabel.Location = new System.Drawing.Point(434, 267);
            this.transactionTypeLabel.Name = "transactionTypeLabel";
            this.transactionTypeLabel.Size = new System.Drawing.Size(105, 17);
            this.transactionTypeLabel.TabIndex = 8;
            this.transactionTypeLabel.Text = "Transaction Type";
            // 
            // transactionPriceTextbox
            // 
            this.transactionPriceTextbox.Location = new System.Drawing.Point(742, 287);
            this.transactionPriceTextbox.Name = "transactionPriceTextbox";
            this.transactionPriceTextbox.Size = new System.Drawing.Size(179, 25);
            this.transactionPriceTextbox.TabIndex = 9;
            // 
            // transactionPriceLavel
            // 
            this.transactionPriceLavel.AutoSize = true;
            this.transactionPriceLavel.Location = new System.Drawing.Point(739, 267);
            this.transactionPriceLavel.Name = "transactionPriceLavel";
            this.transactionPriceLavel.Size = new System.Drawing.Size(106, 17);
            this.transactionPriceLavel.TabIndex = 10;
            this.transactionPriceLavel.Text = "Transaction Price";
            // 
            // transactionsLabel
            // 
            this.transactionsLabel.AutoSize = true;
            this.transactionsLabel.Location = new System.Drawing.Point(9, 15);
            this.transactionsLabel.Name = "transactionsLabel";
            this.transactionsLabel.Size = new System.Drawing.Size(119, 17);
            this.transactionsLabel.TabIndex = 11;
            this.transactionsLabel.Text = "Transaction History";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Number bought/sold";
            // 
            // nBoughtSoldTextbox
            // 
            this.nBoughtSoldTextbox.Location = new System.Drawing.Point(604, 287);
            this.nBoughtSoldTextbox.Name = "nBoughtSoldTextbox";
            this.nBoughtSoldTextbox.Size = new System.Drawing.Size(132, 25);
            this.nBoughtSoldTextbox.TabIndex = 12;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(427, 403);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(494, 39);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.TabStop = false;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.saveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChangesButton.Location = new System.Drawing.Point(427, 343);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(494, 39);
            this.saveChangesButton.TabIndex = 14;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = false;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // pageLeft
            // 
            this.pageLeft.BackColor = System.Drawing.Color.White;
            this.pageLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.pageLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pageLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageLeft.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.pageLeft.Location = new System.Drawing.Point(164, 3);
            this.pageLeft.Name = "pageLeft";
            this.pageLeft.Size = new System.Drawing.Size(41, 36);
            this.pageLeft.TabIndex = 18;
            this.pageLeft.Text = "<";
            this.pageLeft.UseVisualStyleBackColor = false;
            this.pageLeft.Click += new System.EventHandler(this.pageLeft_Click);
            // 
            // pageRight
            // 
            this.pageRight.BackColor = System.Drawing.Color.White;
            this.pageRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.pageRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pageRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageRight.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.pageRight.Location = new System.Drawing.Point(314, 3);
            this.pageRight.Name = "pageRight";
            this.pageRight.Size = new System.Drawing.Size(41, 36);
            this.pageRight.TabIndex = 17;
            this.pageRight.Text = ">";
            this.pageRight.UseVisualStyleBackColor = false;
            this.pageRight.Click += new System.EventHandler(this.pageRight_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.White;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.refreshButton.Location = new System.Drawing.Point(370, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(34, 36);
            this.refreshButton.TabIndex = 16;
            this.refreshButton.Text = "↻";
            this.refreshButton.UseVisualStyleBackColor = false;
            // 
            // pageNo
            // 
            this.pageNo.AutoSize = true;
            this.pageNo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNo.Location = new System.Drawing.Point(268, 9);
            this.pageNo.Name = "pageNo";
            this.pageNo.Size = new System.Drawing.Size(22, 25);
            this.pageNo.TabIndex = 19;
            this.pageNo.Text = "0";
            // 
            // pageNoLabel
            // 
            this.pageNoLabel.AutoSize = true;
            this.pageNoLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNoLabel.Location = new System.Drawing.Point(211, 9);
            this.pageNoLabel.Name = "pageNoLabel";
            this.pageNoLabel.Size = new System.Drawing.Size(62, 25);
            this.pageNoLabel.TabIndex = 20;
            this.pageNoLabel.Text = "Page: ";
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 451);
            this.Controls.Add(this.pageNoLabel);
            this.Controls.Add(this.pageNo);
            this.Controls.Add(this.pageLeft);
            this.Controls.Add(this.pageRight);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nBoughtSoldTextbox);
            this.Controls.Add(this.transactionsLabel);
            this.Controls.Add(this.transactionPriceLavel);
            this.Controls.Add(this.transactionPriceTextbox);
            this.Controls.Add(this.transactionTypeLabel);
            this.Controls.Add(this.transactionTypeCombobox);
            this.Controls.Add(this.transactionDescriptionLabel);
            this.Controls.Add(this.transactionDescriptionTextbox);
            this.Controls.Add(this.nameParentProductLabel);
            this.Controls.Add(this.nameParentProductTextbox);
            this.Controls.Add(this.transactionDateLabel);
            this.Controls.Add(this.transactionDateTextbox);
            this.Controls.Add(this.transactionsListView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Transactions";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Transactions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView transactionsListView;
        private System.Windows.Forms.TextBox transactionDateTextbox;
        private System.Windows.Forms.Label transactionDateLabel;
        private System.Windows.Forms.TextBox nameParentProductTextbox;
        private System.Windows.Forms.Label nameParentProductLabel;
        private System.Windows.Forms.TextBox transactionDescriptionTextbox;
        private System.Windows.Forms.Label transactionDescriptionLabel;
        private System.Windows.Forms.ComboBox transactionTypeCombobox;
        private System.Windows.Forms.Label transactionTypeLabel;
        private System.Windows.Forms.TextBox transactionPriceTextbox;
        private System.Windows.Forms.Label transactionPriceLavel;
        private System.Windows.Forms.Label transactionsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nBoughtSoldTextbox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button pageLeft;
        private System.Windows.Forms.Button pageRight;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label pageNo;
        private System.Windows.Forms.Label pageNoLabel;
    }
}