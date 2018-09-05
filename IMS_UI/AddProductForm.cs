using IMSLibrary;
using IMSLibrary.Products;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static IMSLibrary.Shared.ValidiationUtils;

namespace IMS_UI
{
    public partial class AddProductForm : Form
    {
        private IProductManager _productManager;
        public AddProductForm(IProductManager productManager)
        {
            InitializeComponent();
            _productManager = productManager;
        }

        public delegate void UpdateListViewEventHandler();

        public UpdateListViewEventHandler UpdateListView;

        protected virtual void OnUpdateListView()
        {
            UpdateListView?.Invoke();
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (!IsValidInt(initialStockTextbox.Text)) output = false;
            if (String.IsNullOrWhiteSpace(nameTextbox.Text)) output = false;
            if (String.IsNullOrWhiteSpace(statusTextbox.Text)) output = false;
            if (String.IsNullOrWhiteSpace(categoryTextbox.Text)) output = false;

            return output;
        }

        #region UI Events

        private async void addButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Please provide a name, category and status.");
                return;
            }


            ProductModel model = new ProductModel();

            model.Id = Guid.NewGuid();
            model.Name = nameTextbox.Text;
            model.Description = descriptionTextbox.Text;
            model.Category = categoryTextbox.Text;
            model.Status = statusTextbox.Text;
            model.ProductURL = urlTextbox.Text;
            model.ImagePath = imagePathTextbox.Text;
            model.DateAdded = DateTime.Now;
            model.IntialStock = int.Parse(initialStockTextbox.Text);
            model.StockTransactions = new List<StockTransaction>();

            try
            {
                await _productManager.AddProductAsync(model);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops, something wen't wrong! Please try again.");
                return;
            }
            
            nameTextbox.Text = "";
            descriptionTextbox.Text = "";
            categoryTextbox.Text = "";
            statusTextbox.Text = "";
            urlTextbox.Text = "";
            imagePathTextbox.Text = "";
            initialStockTextbox.Text = "";
            imagePreviewPicturebox.Image = null;

            OnUpdateListView();
        }

        private void imagePathTextbox_TextChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(imagePathTextbox.Text))
            {
                imagePathErrorLabel.Text = "";
                imagePreviewPicturebox.Image = null;
                return;
            }

            if (!File.Exists(imagePathTextbox.Text))
            {
                imagePathErrorLabel.Text = "File doesn't exist";
                imagePreviewPicturebox.Image = null;
                return;
            }

            if (!FileUtils.IsValidImage(imagePathTextbox.Text))
            {
                imagePathErrorLabel.Text = "Invalid file format";
                imagePreviewPicturebox.Image = null;
                return;
            }

            imagePathErrorLabel.Text = "";
            imagePreviewPicturebox.Image = Image.FromFile(imagePathTextbox.Text);
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.No)
            {
                return;
            }
            
            this.Close();
        }

        private void AddProductForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (FileUtils.IsValidImage(files[0]))
            {
                imagePathErrorLabel.Text = "";
                imagePreviewPicturebox.Image = Image.FromFile(files[0]);
                imagePathTextbox.Text = files[0];
            }
        }

        private void AddProductForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        #endregion
    }
}
