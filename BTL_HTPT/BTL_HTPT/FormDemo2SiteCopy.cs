using System;
using System.Windows.Forms;

namespace BTL_HTPT
{
    public partial class FormDemo2SiteCopy : Form
    {
        public FormDemo2SiteCopy()
        {
            InitializeComponent();
            controlProductSiteCopyFirst.SetVisibleButton(false);
            controlProductSiteCopyNext.SetVisibleButton(false);
            controlProductSiteCopyNext.SetVisivlePropagateButton(false);
        }

        private void tabControlSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControlProduct controlProduct = (ControlProduct)tabControlSite.SelectedTab.Controls[0];
            controlProduct.LoadData();
        }
    }
}
