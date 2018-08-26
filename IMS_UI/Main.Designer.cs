﻿namespace IMS_UI
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.dataListView = new System.Windows.Forms.ListView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.pageRight = new System.Windows.Forms.Button();
            this.pageLeft = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.imagePathErrorLabel = new System.Windows.Forms.Label();
            this.urlTextbox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.imagePreviewPicturebox = new System.Windows.Forms.PictureBox();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.imagePreviewLabel = new System.Windows.Forms.Label();
            this.imagePathTextbox = new System.Windows.Forms.TextBox();
            this.imagePathLabel = new System.Windows.Forms.Label();
            this.statusTextbox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.categoryTextbox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.soldGroupBox = new System.Windows.Forms.GroupBox();
            this.sellDateTextBox = new System.Windows.Forms.TextBox();
            this.dateSoldLabel = new System.Windows.Forms.Label();
            this.soldCheckBox = new System.Windows.Forms.CheckBox();
            this.soldPriceLabel = new System.Windows.Forms.Label();
            this.soldPriceTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dateAddedLabel = new System.Windows.Forms.Label();
            this.dateAddedTextbox = new System.Windows.Forms.TextBox();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.createBackupButton = new System.Windows.Forms.Button();
            this.addNewButton = new System.Windows.Forms.Button();
            this.productModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePreviewPicturebox)).BeginInit();
            this.soldGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListView
            // 
            this.dataListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListView.Location = new System.Drawing.Point(12, 63);
            this.dataListView.MultiSelect = false;
            this.dataListView.Name = "dataListView";
            this.dataListView.Size = new System.Drawing.Size(612, 684);
            this.dataListView.TabIndex = 0;
            this.dataListView.UseCompatibleStateImageBehavior = false;
            this.dataListView.SelectedIndexChanged += new System.EventHandler(this.dataListView_SelectedIndexChanged);
            this.dataListView.DoubleClick += new System.EventHandler(this.dataListView_DoubleClick);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.White;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.refreshButton.Location = new System.Drawing.Point(590, 25);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(34, 36);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "↻";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 25);
            this.searchTextBox.MaxLength = 400;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(451, 20);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // pageRight
            // 
            this.pageRight.BackColor = System.Drawing.Color.White;
            this.pageRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.pageRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pageRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageRight.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.pageRight.Location = new System.Drawing.Point(534, 25);
            this.pageRight.Name = "pageRight";
            this.pageRight.Size = new System.Drawing.Size(41, 36);
            this.pageRight.TabIndex = 3;
            this.pageRight.Text = ">";
            this.pageRight.UseVisualStyleBackColor = false;
            this.pageRight.Click += new System.EventHandler(this.pageRight_Click);
            // 
            // pageLeft
            // 
            this.pageLeft.BackColor = System.Drawing.Color.White;
            this.pageLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.pageLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pageLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageLeft.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.pageLeft.Location = new System.Drawing.Point(487, 25);
            this.pageLeft.Name = "pageLeft";
            this.pageLeft.Size = new System.Drawing.Size(41, 36);
            this.pageLeft.TabIndex = 4;
            this.pageLeft.Text = "<";
            this.pageLeft.UseVisualStyleBackColor = false;
            this.pageLeft.Click += new System.EventHandler(this.pageLeft_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(9, 5);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(101, 17);
            this.searchLabel.TabIndex = 6;
            this.searchLabel.Text = "Search by name";
            // 
            // imagePathErrorLabel
            // 
            this.imagePathErrorLabel.AutoSize = true;
            this.imagePathErrorLabel.BackColor = System.Drawing.Color.White;
            this.imagePathErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePathErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imagePathErrorLabel.Location = new System.Drawing.Point(725, 466);
            this.imagePathErrorLabel.Name = "imagePathErrorLabel";
            this.imagePathErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.imagePathErrorLabel.TabIndex = 32;
            // 
            // urlTextbox
            // 
            this.urlTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlTextbox.Location = new System.Drawing.Point(644, 443);
            this.urlTextbox.MaxLength = 300;
            this.urlTextbox.Name = "urlTextbox";
            this.urlTextbox.Size = new System.Drawing.Size(217, 25);
            this.urlTextbox.TabIndex = 25;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(640, 419);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(31, 17);
            this.urlLabel.TabIndex = 31;
            this.urlLabel.Text = "URL";
            // 
            // picturePanel
            // 
            this.picturePanel.BackColor = System.Drawing.Color.White;
            this.picturePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePanel.Controls.Add(this.imagePreviewPicturebox);
            this.picturePanel.Location = new System.Drawing.Point(901, 310);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(245, 229);
            this.picturePanel.TabIndex = 30;
            // 
            // imagePreviewPicturebox
            // 
            this.imagePreviewPicturebox.Location = new System.Drawing.Point(-1, -1);
            this.imagePreviewPicturebox.Name = "imagePreviewPicturebox";
            this.imagePreviewPicturebox.Size = new System.Drawing.Size(245, 230);
            this.imagePreviewPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePreviewPicturebox.TabIndex = 6;
            this.imagePreviewPicturebox.TabStop = false;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextbox.Location = new System.Drawing.Point(644, 90);
            this.descriptionTextbox.MaxLength = 500;
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(502, 182);
            this.descriptionTextbox.TabIndex = 20;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(640, 66);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(74, 17);
            this.descriptionLabel.TabIndex = 29;
            this.descriptionLabel.Text = "Description";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextbox.Location = new System.Drawing.Point(644, 25);
            this.nameTextbox.MaxLength = 400;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(347, 25);
            this.nameTextbox.TabIndex = 19;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(641, 5);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 17);
            this.nameLabel.TabIndex = 28;
            this.nameLabel.Text = "Name";
            // 
            // imagePreviewLabel
            // 
            this.imagePreviewLabel.AutoSize = true;
            this.imagePreviewLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePreviewLabel.Location = new System.Drawing.Point(898, 286);
            this.imagePreviewLabel.Name = "imagePreviewLabel";
            this.imagePreviewLabel.Size = new System.Drawing.Size(93, 17);
            this.imagePreviewLabel.TabIndex = 27;
            this.imagePreviewLabel.Text = "Image preview";
            this.imagePreviewLabel.Click += new System.EventHandler(this.imagePreviewLabel_Click);
            // 
            // imagePathTextbox
            // 
            this.imagePathTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePathTextbox.Location = new System.Drawing.Point(644, 510);
            this.imagePathTextbox.MaxLength = 300;
            this.imagePathTextbox.Name = "imagePathTextbox";
            this.imagePathTextbox.Size = new System.Drawing.Size(217, 25);
            this.imagePathTextbox.TabIndex = 26;
            // 
            // imagePathLabel
            // 
            this.imagePathLabel.AutoSize = true;
            this.imagePathLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePathLabel.Location = new System.Drawing.Point(640, 486);
            this.imagePathLabel.Name = "imagePathLabel";
            this.imagePathLabel.Size = new System.Drawing.Size(74, 17);
            this.imagePathLabel.TabIndex = 23;
            this.imagePathLabel.Text = "Image path";
            // 
            // statusTextbox
            // 
            this.statusTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTextbox.Location = new System.Drawing.Point(644, 377);
            this.statusTextbox.MaxLength = 100;
            this.statusTextbox.Name = "statusTextbox";
            this.statusTextbox.Size = new System.Drawing.Size(217, 25);
            this.statusTextbox.TabIndex = 24;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(640, 353);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 17);
            this.statusLabel.TabIndex = 21;
            this.statusLabel.Text = "Status";
            // 
            // categoryTextbox
            // 
            this.categoryTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTextbox.Location = new System.Drawing.Point(644, 310);
            this.categoryTextbox.MaxLength = 100;
            this.categoryTextbox.Name = "categoryTextbox";
            this.categoryTextbox.Size = new System.Drawing.Size(217, 25);
            this.categoryTextbox.TabIndex = 22;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(640, 286);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(61, 17);
            this.categoryLabel.TabIndex = 18;
            this.categoryLabel.Text = "Category";
            // 
            // soldGroupBox
            // 
            this.soldGroupBox.Controls.Add(this.sellDateTextBox);
            this.soldGroupBox.Controls.Add(this.dateSoldLabel);
            this.soldGroupBox.Controls.Add(this.soldCheckBox);
            this.soldGroupBox.Controls.Add(this.soldPriceLabel);
            this.soldGroupBox.Controls.Add(this.soldPriceTextBox);
            this.soldGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldGroupBox.Location = new System.Drawing.Point(643, 554);
            this.soldGroupBox.Name = "soldGroupBox";
            this.soldGroupBox.Size = new System.Drawing.Size(502, 63);
            this.soldGroupBox.TabIndex = 33;
            this.soldGroupBox.TabStop = false;
            this.soldGroupBox.Text = "Sale";
            this.soldGroupBox.Enter += new System.EventHandler(this.soldGroupBox_Enter);
            // 
            // sellDateTextBox
            // 
            this.sellDateTextBox.Enabled = false;
            this.sellDateTextBox.Location = new System.Drawing.Point(350, 22);
            this.sellDateTextBox.Name = "sellDateTextBox";
            this.sellDateTextBox.Size = new System.Drawing.Size(146, 29);
            this.sellDateTextBox.TabIndex = 6;
            // 
            // dateSoldLabel
            // 
            this.dateSoldLabel.AutoSize = true;
            this.dateSoldLabel.Location = new System.Drawing.Point(272, 25);
            this.dateSoldLabel.Name = "dateSoldLabel";
            this.dateSoldLabel.Size = new System.Drawing.Size(72, 21);
            this.dateSoldLabel.TabIndex = 5;
            this.dateSoldLabel.Text = "Sell date:";
            // 
            // soldCheckBox
            // 
            this.soldCheckBox.AutoSize = true;
            this.soldCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.soldCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldCheckBox.Location = new System.Drawing.Point(1, 24);
            this.soldCheckBox.Name = "soldCheckBox";
            this.soldCheckBox.Size = new System.Drawing.Size(60, 25);
            this.soldCheckBox.TabIndex = 4;
            this.soldCheckBox.Text = "Sold";
            this.soldCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.soldCheckBox.UseVisualStyleBackColor = true;
            this.soldCheckBox.CheckedChanged += new System.EventHandler(this.soldCheckBox_CheckedChanged);
            // 
            // soldPriceLabel
            // 
            this.soldPriceLabel.AutoSize = true;
            this.soldPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldPriceLabel.Location = new System.Drawing.Point(67, 25);
            this.soldPriceLabel.Name = "soldPriceLabel";
            this.soldPriceLabel.Size = new System.Drawing.Size(99, 21);
            this.soldPriceLabel.TabIndex = 1;
            this.soldPriceLabel.Text = "Sell Price (£):";
            this.soldPriceLabel.Click += new System.EventHandler(this.soldPriceLabel_Click);
            // 
            // soldPriceTextBox
            // 
            this.soldPriceTextBox.Enabled = false;
            this.soldPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldPriceTextBox.Location = new System.Drawing.Point(169, 21);
            this.soldPriceTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.soldPriceTextBox.MaxLength = 50;
            this.soldPriceTextBox.Name = "soldPriceTextBox";
            this.soldPriceTextBox.Size = new System.Drawing.Size(100, 29);
            this.soldPriceTextBox.TabIndex = 0;
            // 
            // dateAddedLabel
            // 
            this.dateAddedLabel.AutoSize = true;
            this.dateAddedLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAddedLabel.Location = new System.Drawing.Point(1008, 5);
            this.dateAddedLabel.Name = "dateAddedLabel";
            this.dateAddedLabel.Size = new System.Drawing.Size(78, 17);
            this.dateAddedLabel.TabIndex = 34;
            this.dateAddedLabel.Text = "Date Added";
            // 
            // dateAddedTextbox
            // 
            this.dateAddedTextbox.Enabled = false;
            this.dateAddedTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAddedTextbox.Location = new System.Drawing.Point(1011, 25);
            this.dateAddedTextbox.Name = "dateAddedTextbox";
            this.dateAddedTextbox.Size = new System.Drawing.Size(134, 25);
            this.dateAddedTextbox.TabIndex = 35;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.saveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChangesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.Location = new System.Drawing.Point(644, 623);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(501, 55);
            this.saveChangesButton.TabIndex = 36;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = false;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // createBackupButton
            // 
            this.createBackupButton.BackColor = System.Drawing.Color.White;
            this.createBackupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBackupButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBackupButton.Location = new System.Drawing.Point(901, 692);
            this.createBackupButton.Name = "createBackupButton";
            this.createBackupButton.Size = new System.Drawing.Size(243, 55);
            this.createBackupButton.TabIndex = 37;
            this.createBackupButton.Text = "Generate Backup";
            this.createBackupButton.UseVisualStyleBackColor = false;
            this.createBackupButton.Click += new System.EventHandler(this.createBackupButton_Click);
            this.createBackupButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.createBackupButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.BackColor = System.Drawing.Color.White;
            this.addNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewButton.Location = new System.Drawing.Point(644, 692);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(243, 55);
            this.addNewButton.TabIndex = 38;
            this.addNewButton.Text = "Add New";
            this.addNewButton.UseVisualStyleBackColor = false;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // productModelBindingSource
            // 
            this.productModelBindingSource.DataSource = typeof(IMSLibrary.ProductModel);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 759);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.createBackupButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.dateAddedTextbox);
            this.Controls.Add(this.dateAddedLabel);
            this.Controls.Add(this.soldGroupBox);
            this.Controls.Add(this.imagePathErrorLabel);
            this.Controls.Add(this.urlTextbox);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.picturePanel);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.imagePreviewLabel);
            this.Controls.Add(this.imagePathTextbox);
            this.Controls.Add(this.imagePathLabel);
            this.Controls.Add(this.statusTextbox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.categoryTextbox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.pageLeft);
            this.Controls.Add(this.pageRight);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.dataListView);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "IMS";
            this.Load += new System.EventHandler(this.Main_Load);
            this.picturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagePreviewPicturebox)).EndInit();
            this.soldGroupBox.ResumeLayout(false);
            this.soldGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView dataListView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.BindingSource productModelBindingSource;
        private System.Windows.Forms.Button pageRight;
        private System.Windows.Forms.Button pageLeft;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label imagePathErrorLabel;
        private System.Windows.Forms.TextBox urlTextbox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Panel picturePanel;
        private System.Windows.Forms.PictureBox imagePreviewPicturebox;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label imagePreviewLabel;
        private System.Windows.Forms.TextBox imagePathTextbox;
        private System.Windows.Forms.Label imagePathLabel;
        private System.Windows.Forms.TextBox statusTextbox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox categoryTextbox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.GroupBox soldGroupBox;
        private System.Windows.Forms.Label soldPriceLabel;
        private System.Windows.Forms.TextBox soldPriceTextBox;
        private System.Windows.Forms.CheckBox soldCheckBox;
        private System.Windows.Forms.TextBox sellDateTextBox;
        private System.Windows.Forms.Label dateSoldLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label dateAddedLabel;
        private System.Windows.Forms.TextBox dateAddedTextbox;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button createBackupButton;
        private System.Windows.Forms.Button addNewButton;
    }
}