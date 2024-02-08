using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HTPT
{
    public partial class FormDemoOwnerAndCopy : Form
    {
        public FormDemoOwnerAndCopy()
        {
            InitializeComponent();
            controlProductCopy.SetVisibleButton(false);
            controlProductCopy.SetVisivlePropagateButton(false);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControlProduct controlProduct = (ControlProduct)tabControl1.SelectedTab.Controls[0];
            controlProduct.LoadData();
        }
    }
}
