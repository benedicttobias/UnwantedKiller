using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnwantedKiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initializeFileList();
        }

        private void initializeFileList()
        {
            // Add Column
            fileList.Columns.Add("Files", -2);

            // Edit properties for searched items
            fileList.View = View.Details;
            fileList.GridLines = true;
            fileList.Sorting = SortOrder.Ascending;
            fileList.CheckBoxes = true;
        }

        void searchButton_Click(object sender, EventArgs e)
        {

            string[] collection;

            collection = Directory.GetFiles(locationTextbox.Text);

            foreach (string file in collection)
            {
                fileList.Items.Add(file);
            }
        }

    }
}
