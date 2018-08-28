using System;
using IMSLibrary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IMS_UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            Decimal parsedVal;

            if (String.IsNullOrWhiteSpace(nameTextbox.Text)) isValid = false;
            if (String.IsNullOrWhiteSpace(statusTextbox.Text)) isValid = false;
            if (String.IsNullOrWhiteSpace(categoryTextbox.Text)) isValid = false;
            if (!Decimal.TryParse(soldPriceTextBox.Text, out parsedVal)) isValid = false;

            return isValid;
        }

        #region private vars
        private ProductModel selectedProduct;
        #endregion

        #region AlterListViewMethods

        public async void LoadDataIntoListView()
        {
            dataListView.Items.Clear();

            var products = await GlobalConfig.Connections[0].LoadData();

            var results = products.Where(x => x.Name.Contains(searchTextBox.Text)).ToArray();

            if (GlobalConfig.DataViewPageNo > (results.GetLength(0) - 1) / GlobalConfig.resultsPerPage) GlobalConfig.DataViewPageNo = results.GetLength(0) - 1 / GlobalConfig.resultsPerPage;
            if (GlobalConfig.DataViewPageNo < 0) GlobalConfig.DataViewPageNo = 0;

            for (int i = GlobalConfig.DataViewPageNo; i < GlobalConfig.DataViewPageNo + GlobalConfig.resultsPerPage; i++)
            {
                if (i > results.GetLength(0) - 1) break;
                var p = results[i];
                dataListView.Items.Add(new ListViewItem (new string[] {p.Id.ToString(), p.Name, p.Category, p.Status, p.isSold ? "Yes" : "No", p.DateAdded.ToShortDateString() }));
            }
        }

        private void LoadDataIntoForm(ProductModel product)
        {
            nameTextbox.Text = product.Name;
            descriptionTextbox.Text = product.Description;
            categoryTextbox.Text = product.Category;
            statusTextbox.Text = product.Status;
            urlTextbox.Text = product.ProductURL;
            imagePathTextbox.Text = product.ImagePath;
            dateAddedTextbox.Text = product.DateAdded.ToLongDateString();


            if (product.isSold)
            {
                soldCheckBox.Checked = true;
                sellDateTextBox.Text = product.DateSold.ToLongDateString();
                soldPriceTextBox.Text = product.SoldPrice.ToString();
            }
            else
            {
                soldCheckBox.Checked = false;
                sellDateTextBox.Text = "";
                soldPriceTextBox.Text = "";
            }
        }

        #endregion

        #region UI Events

        private void Main_Load(object sender, EventArgs e)
        {
            dataListView.View = View.Details;
            dataListView.FullRowSelect = true;
            dataListView.GridLines = true;
            dataListView.Columns.Add("Id", 28);
            dataListView.Columns.Add("Name", 200);
            dataListView.Columns.Add("Category", 120);
            dataListView.Columns.Add("Status", 120);
            dataListView.Columns.Add("Sold", 60);
            dataListView.Columns.Add("Date Added", 90);
            LoadDataIntoListView();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await GlobalConfig.Connections[0].ReloadData();
            LoadDataIntoListView();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadDataIntoListView();
        }

        private async void dataListView_DoubleClick(object sender, EventArgs e)
        {
            Guid ProductId = Guid.Empty;
            Guid.TryParse(dataListView.SelectedItems[0].SubItems[0].Text.ToString(), out ProductId);

            ProductModel product = new ProductModel();

            if (ProductId != Guid.Empty)
            {
                product = await GlobalConfig.Connections[0].RetrieveEntryByGuid(ProductId);
            }

            this.selectedProduct = product;
            LoadDataIntoForm(product);
        }

        private void pageLeft_Click(object sender, EventArgs e)
        {
            GlobalConfig.DataViewPageNo--;
            LoadDataIntoListView();
        }

        private void pageRight_Click(object sender, EventArgs e)
        {
            GlobalConfig.DataViewPageNo++;
            LoadDataIntoListView();
        }

        private void soldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (soldCheckBox.Checked)
            {
                soldPriceTextBox.Enabled = true;
                sellDateTextBox.Text = DateTime.Now.ToLongDateString();
            }
            else
            {
                soldPriceTextBox.Enabled = false;
                soldPriceTextBox.Text = "";
                sellDateTextBox.Text = "";
            }
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Invalid input data");
                return;
            };

            var model = new ProductModel();

            model.Id = selectedProduct.Id;
            model.Name = nameTextbox.Text;
            model.Description = descriptionTextbox.Text;
            model.Category = categoryTextbox.Text;
            model.Status = statusTextbox.Text;
            model.ProductURL = urlTextbox.Text;
            model.ImagePath = imagePathTextbox.Text;
            model.DateAdded = selectedProduct.DateAdded;
            model.isSold = soldCheckBox.Checked;
            model.SoldPrice = Decimal.Parse(soldPriceTextBox.Text);
            model.DateSold = soldCheckBox.Checked ? DateTime.Now : DateTime.MinValue;

            GlobalConfig.Connections[0].SaveChanges(model);
            LoadDataIntoListView();

            MessageBox.Show("Changes saved successfully!");
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            var addnewform = new AddProductForm();
            addnewform.UpdateListView += LoadDataIntoListView;
            addnewform.Show();
        }

        private async void createBackupButton_Click(object sender, MouseEventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to create a backup?", "Generate backup", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.No)
            {
                return;
            }

            bool successful = await GlobalConfig.Connections[0].GenerateBackup();

            if (successful)
            {
                MessageBox.Show("Backup created successfully.");
            }
            else
            {
                MessageBox.Show("Oops! Something wen't wrong");
            }

        }

        private void createBackupButton_Click(object sender, EventArgs e)
        {

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

            if (!FileUtilities.IsValidImage(imagePathTextbox.Text))
            {
                imagePathErrorLabel.Text = "Invalid file format";
                imagePreviewPicturebox.Image = null;
                return;
            }

            imagePathErrorLabel.Text = "";
            imagePreviewPicturebox.Image = Image.FromFile(imagePathTextbox.Text);
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (FileUtilities.IsValidImage(files[0]))
            {
                imagePathErrorLabel.Text = "";
                imagePreviewPicturebox.Image = Image.FromFile(files[0]);
                imagePathTextbox.Text = files[0];
            }
        }

        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            }
        }


        #region Unused ui events
        private void dataListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void imagePreviewLabel_Click(object sender, EventArgs e)
        {

        }

        private void poundLabel_Click(object sender, EventArgs e)
        {

        }

        private void soldPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void soldGroupBox_Enter(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion
   
    }
}
