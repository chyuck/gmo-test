using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui
{
    public partial class MasterDetailForm : Form
    {
        public MasterDetailForm()
        {
            InitializeComponent();
        }

        private void MasterDetailForm_Load(object sender, EventArgs e)
        {
            _listBoxProductNames.DataSource = DataLoader.LoadProductsFromFile();
        }

        private void ListBoxProductNames_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedItem = (ProductDescription)_listBoxProductNames.SelectedItem;

            _textBoxName.Text = selectedItem.Name;
            _textBoxDescription.Text = selectedItem.Description;
        }
    }
}
