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
    public partial class AddSalty : UserControl
    {
        public ComboBox saltyTypes { get { return cbSaltyTypes; } }
        public CheckBox IsSugar { get { return cbSugar; } }
        public CheckBox IsDairy { get { return cbDairy; } }
        public CheckBox IsNuts { get { return cbNuts; } }
        public CheckBox IsGluten { get { return cbGluten; } }

        public AddSalty()
        {
            InitializeComponent();
            cbSaltyTypes.DataSource = Enum.GetValues(typeof(eSaltyTypes));
        }
    }
}
