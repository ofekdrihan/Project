using SuperMarket.Backend.Enums;
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
    public partial class AddVegtable : UserControl
    {
        public ComboBox vegType { get { return cbVegType; } }
        public CheckBox IsOrganic { get { return cbOrganic; } }
        public CheckBox IsFresh { get { return cbFresh; } }
        public AddVegtable()
        {
            InitializeComponent();
            cbVegType.DataSource = Enum.GetValues(typeof(eVegetables));
        }
    }
}
