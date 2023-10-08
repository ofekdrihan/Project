using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.Frontend.UserControls
{
    public partial class AddProduct : UserControl
    {
        public TextBox textBoxName { get { return txtName; } }
        public TextBox textBoxPrice { get { return txtPrice; } }
        public TextBox textBoxWeight { get { return txtWeight; } }
        public DateTimePicker dateTimePickerExpired { get { return cbDateExpired; } }
        public AddProduct()
        {
            InitializeComponent();
        }
    }
}
