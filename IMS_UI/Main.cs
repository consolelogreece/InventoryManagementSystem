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

namespace IMS_UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private async void LoadDataIntoListView()
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
                dataListView.Items.Add(new ListViewItem (new string[] { p.Name, p.Category, p.Status, p.isSold ? "Yes" : "No", p.DateAdded.ToShortDateString() }));
            }
        }


        private void Main_Load(object sender, EventArgs e)
        {
            dataListView.View = View.Details;
            dataListView.FullRowSelect = true;
            dataListView.GridLines = true;
            dataListView.Columns.Add("Name",200);
            dataListView.Columns.Add("Category", 120);
            dataListView.Columns.Add("Status", 120);
            dataListView.Columns.Add("Sold", 60);
            dataListView.Columns.Add("Date Added", 90);
            LoadDataIntoListView();
        }

        private void dataListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            LoadDataIntoListView();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadDataIntoListView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
