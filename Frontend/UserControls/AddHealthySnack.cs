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
    public partial class AddHealthySnack : UserControl
    {
        public TextBox gramOfProtein { get { return txtGOP; } }
        public ComboBox Purpose { get { return cbPurpose; } }
        public CheckBox IsSugar { get { return cbSugar; } }
        public CheckBox IsDairy { get { return cbDairy; } }
        public CheckBox IsNuts { get { return cbNuts; } }
        public CheckBox IsGluten { get { return cbGluten; } }

        public AddHealthySnack()
        {
            InitializeComponent();
            cbPurpose.DataSource = Enum.GetValues(typeof(eHealthySnackPurposes));
        }
    }
}
