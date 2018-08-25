namespace IMS_UI
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
            this.productModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pageRight = new System.Windows.Forms.Button();
            this.pageLeft = new System.Windows.Forms.Button();
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
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(451, 20);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // productModelBindingSource
            // 
            this.productModelBindingSource.DataSource = typeof(IMSLibrary.ProductModel);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 759);
            this.Controls.Add(this.pageLeft);
            this.Controls.Add(this.pageRight);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.dataListView);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
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
    }
}