using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMarket.Backend.Enums;

namespace SuperMarket.Frontend.UserControls
{
    public partial class AddChocolate : UserControl
    {
        public TextBox cocoaPercent { get { return txtCprecent; } }
        public ComboBox choclateType {  get { return cmbCkinds; } }
        public ComboBox choclateExtras {  get { return cmbCextras; } }
        public CheckBox IsSugar {  get { return cbSugar; } }
        public CheckBox IsDairy { get { return cbDairy; } }
        public CheckBox IsNuts { get { return cbNuts; } }
        public CheckBox IsGluten { get { return cbGluten; } }

        public AddChocolate()
        {
            InitializeComponent();
            cmbCkinds.DataSource = Enum.GetValues(typeof(eChocolateKinds));
            cmbCextras.DataSource = Enum.GetValues(typeof(eChocolateExtras));
        }
    }
}
