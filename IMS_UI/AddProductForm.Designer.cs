namespace IMS_UI
{
    partial class AddProductForm
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
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryTextbox = new System.Windows.Forms.TextBox();
            this.statusTextbox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.imagePathTextbox = new System.Windows.Forms.TextBox();
            this.imagePathLabel = new System.Windows.Forms.Label();
            this.imagePreviewPicturebox = new System.Windows.Forms.PictureBox();
            this.imagePreviewLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.urlTextbox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.imagePathErrorLabel = new System.Windows.Forms.Label();
            this.initialStockTextbox = new System.Windows.Forms.TextBox();
            this.initialStockLabel = new System.Windows.Forms.Label();
            this.tAddBtn = new System.Windows.Forms.Button();
            this.tRemoveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagePreviewPicturebox)).BeginInit();
            this.picturePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(8, 296);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(73, 21);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "Category";
            // 
            // categoryTextbox
            // 
            this.categoryTextbox.Location = new System.Drawing.Point(12, 320);
            this.categoryTextbox.Name = "categoryTextbox";
            this.categoryTextbox.Size = new System.Drawing.Size(361, 29);
            this.categoryTextbox.TabIndex = 3;
            // 
            // statusTextbox
            // 
            this.statusTextbox.Location = new System.Drawing.Point(12, 387);
            this.statusTextbox.Name = "statusTextbox";
            this.statusTextbox.Size = new System.Drawing.Size(361, 29);
            this.statusTextbox.TabIndex = 4;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(8, 363);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(52, 21);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Status";
            // 
            // imagePathTextbox
            // 
            this.imagePathTextbox.Location = new System.Drawing.Point(12, 520);
            this.imagePathTextbox.Name = "imagePathTextbox";
            this.imagePathTextbox.Size = new System.Drawing.Size(361, 29);
            this.imagePathTextbox.TabIndex = 6;
            this.imagePathTextbox.TextChanged += new System.EventHandler(this.imagePathTextbox_TextChanged);
            // 
            // imagePathLabel
            // 
            this.imagePathLabel.AutoSize = true;
            this.imagePathLabel.Location = new System.Drawing.Point(8, 496);
            this.imagePathLabel.Name = "imagePathLabel";
            this.imagePathLabel.Size = new System.Drawing.Size(88, 21);
            this.imagePathLabel.TabIndex = 4;
            this.imagePathLabel.Text = "Image path";
            // 
            // imagePreviewPicturebox
            // 
            this.imagePreviewPicturebox.Location = new System.Drawing.Point(-1, -2);
            this.imagePreviewPicturebox.Name = "imagePreviewPicturebox";
            this.imagePreviewPicturebox.Size = new System.Drawing.Size(319, 230);
            this.imagePreviewPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePreviewPicturebox.TabIndex = 6;
            this.imagePreviewPicturebox.TabStop = false;
            // 
            // imagePreviewLabel
            // 
            this.imagePreviewLabel.AutoSize = true;
            this.imagePreviewLabel.Location = new System.Drawing.Point(391, 297);
            this.imagePreviewLabel.Name = "imagePreviewLabel";
            this.imagePreviewLabel.Size = new System.Drawing.Size(112, 21);
            this.imagePreviewLabel.TabIndex = 7;
            this.imagePreviewLabel.Text = "Image preview";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(12, 630);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(361, 39);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(395, 630);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(319, 39);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.TabStop = false;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(12, 35);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(702, 29);
            this.nameTextbox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(8, 11);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 21);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name";
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(12, 100);
            this.descriptionTextbox.MaxLength = 500;
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(702, 182);
            this.descriptionTextbox.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(8, 76);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(89, 21);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.Text = "Description";
            // 
            // picturePanel
            // 
            this.picturePanel.BackColor = System.Drawing.Color.White;
            this.picturePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePanel.Controls.Add(this.imagePreviewPicturebox);
            this.picturePanel.Location = new System.Drawing.Point(395, 320);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(319, 229);
            this.picturePanel.TabIndex = 14;
            // 
            // urlTextbox
            // 
            this.urlTextbox.Location = new System.Drawing.Point(12, 582);
            this.urlTextbox.Name = "urlTextbox";
            this.urlTextbox.Size = new System.Drawing.Size(702, 29);
            this.urlTextbox.TabIndex = 5;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(8, 558);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(39, 21);
            this.urlLabel.TabIndex = 15;
            this.urlLabel.Text = "URL";
            // 
            // imagePathErrorLabel
            // 
            this.imagePathErrorLabel.AutoSize = true;
            this.imagePathErrorLabel.BackColor = System.Drawing.Color.White;
            this.imagePathErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imagePathErrorLabel.Location = new System.Drawing.Point(99, 496);
            this.imagePathErrorLabel.Name = "imagePathErrorLabel";
            this.imagePathErrorLabel.Size = new System.Drawing.Size(0, 21);
            this.imagePathErrorLabel.TabIndex = 17;
            // 
            // initialStockTextbox
            // 
            this.initialStockTextbox.Location = new System.Drawing.Point(12, 451);
            this.initialStockTextbox.Name = "initialStockTextbox";
            this.initialStockTextbox.Size = new System.Drawing.Size(361, 29);
            this.initialStockTextbox.TabIndex = 19;
            // 
            // initialStockLabel
            // 
            this.initialStockLabel.AutoSize = true;
            this.initialStockLabel.Location = new System.Drawing.Point(8, 427);
            this.initialStockLabel.Name = "initialStockLabel";
            this.initialStockLabel.Size = new System.Drawing.Size(88, 21);
            this.initialStockLabel.TabIndex = 18;
            this.initialStockLabel.Text = "Initial stock";
            // 
            // tAddBtn
            // 
            this.tAddBtn.Location = new System.Drawing.Point(620, 553);
            this.tAddBtn.Name = "tAddBtn";
            this.tAddBtn.Size = new System.Drawing.Size(75, 26);
            this.tAddBtn.TabIndex = 20;
            this.tAddBtn.Text = "tAdd";
            this.tAddBtn.UseVisualStyleBackColor = true;
            this.tAddBtn.Click += new System.EventHandler(this.tAddBtn_Click);
            // 
            // tRemoveBtn
            // 
            this.tRemoveBtn.Location = new System.Drawing.Point(520, 553);
            this.tRemoveBtn.Name = "tRemoveBtn";
            this.tRemoveBtn.Size = new System.Drawing.Size(84, 26);
            this.tRemoveBtn.TabIndex = 21;
            this.tRemoveBtn.Text = "tRemove";
            this.tRemoveBtn.UseVisualStyleBackColor = true;
            this.tRemoveBtn.Click += new System.EventHandler(this.tRemoveBtn_Click);
            // 
            // AddProductForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 681);
            this.Controls.Add(this.tRemoveBtn);
            this.Controls.Add(this.tAddBtn);
            this.Controls.Add(this.initialStockTextbox);
            this.Controls.Add(this.initialStockLabel);
            this.Controls.Add(this.imagePathErrorLabel);
            this.Controls.Add(this.urlTextbox);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.picturePanel);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.imagePreviewLabel);
            this.Controls.Add(this.imagePathTextbox);
            this.Controls.Add(this.imagePathLabel);
            this.Controls.Add(this.statusTextbox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.categoryTextbox);
            this.Controls.Add(this.categoryLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProductForm";
            this.Text = "Add New";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.AddProductForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.AddProductForm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.imagePreviewPicturebox)).EndInit();
            this.picturePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox categoryTextbox;
        private System.Windows.Forms.TextBox statusTextbox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox imagePathTextbox;
        private System.Windows.Forms.Label imagePathLabel;
        private System.Windows.Forms.PictureBox imagePreviewPicturebox;
        private System.Windows.Forms.Label imagePreviewLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel picturePanel;
        private System.Windows.Forms.TextBox urlTextbox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label imagePathErrorLabel;
        private System.Windows.Forms.TextBox initialStockTextbox;
        private System.Windows.Forms.Label initialStockLabel;
        private System.Windows.Forms.Button tAddBtn;
        private System.Windows.Forms.Button tRemoveBtn;
    }
}

