using IMSLibrary;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace IMS_UI
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) {
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
            model.isSold = false;
            model.SoldPrice = 0;
            model.DateSold = DateTime.Now;

            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                bool succeeded = await db.AddProductAsync(model);

                if (!succeeded)
                {
                    MessageBox.Show("Oops, something wen't wrong! Please try again.");
                    return;
                }
            }

            nameTextbox.Text = "";
            descriptionTextbox.Text = "";
            categoryTextbox.Text = "";
            statusTextbox.Text = "";
            urlTextbox.Text = "";
            imagePathTextbox.Text = "";

        }

        private bool ValidateForm()
        {
            bool output = true;

            if (String.IsNullOrWhiteSpace(nameTextbox.Text)) output = false;
            if (String.IsNullOrWhiteSpace(statusTextbox.Text)) output = false;
            if (String.IsNullOrWhiteSpace(categoryTextbox.Text)) output = false;

            return output;
        }

        private void imagePathTextbox_TextChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(imagePathTextbox.Text))
            {
                imagePathErrorLabel.Text = "";
                return;
            }

            if (!File.Exists(imagePathTextbox.Text))
            {
                imagePathErrorLabel.Text = "File doesn't exist";
                return;
            }

            if (!FileUtilities.IsValidImage(imagePathTextbox.Text))
            {
                imagePathErrorLabel.Text = "Invalid file format";
                return;
            }

            imagePathErrorLabel.Text = "";
            imagePreviewPicturebox.Image = Image.FromFile(imagePathTextbox.Text);


        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
