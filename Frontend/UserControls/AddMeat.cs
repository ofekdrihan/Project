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
    public partial class AddMeat : UserControl
    {
        public ComboBox meatType { get { return cbCMeattype; } }
        public CheckBox Isfresh { get { return cbFresh; } }
        public AddMeat()
        {
            InitializeComponent();
            cbCMeattype.DataSource = Enum.GetValues(typeof(eMeatTypes));
        }
    }
}
