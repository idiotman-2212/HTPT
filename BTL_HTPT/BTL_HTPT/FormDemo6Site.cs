using System;
using System.Windows.Forms;

namespace BTL_HTPT
{
    public partial class FormDemo6Site : Form
    {
        public FormDemo6Site()
        {
            InitializeComponent();
            controlProductSiteCopy1.SetVisibleButton(false);
            controlProductSiteCopy2.SetVisibleButton(false);
            controlProductSiteCopy3.SetVisibleButton(false);
            controlProductSiteCopy4.SetVisibleButton(false);
            controlProductSiteCopy5.SetVisibleButton(false);
            controlProductSiteCopy5.SetVisivlePropagateButton(false);
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControlProduct controlProduct = (ControlProduct)tabControlSite.SelectedTab.Controls[0];
            controlProduct.LoadData();
        }
    }
}
