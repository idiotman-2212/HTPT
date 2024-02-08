
namespace BTL_HTPT
{
    partial class FormDemo2SiteCopy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlSite = new System.Windows.Forms.TabControl();
            this.tabPageSiteFirst = new System.Windows.Forms.TabPage();
            this.controlProductSiteCopyFirst = new BTL_HTPT.ControlProduct();
            this.tabPageSiteNext = new System.Windows.Forms.TabPage();
            this.controlProductSiteCopyNext = new BTL_HTPT.ControlProduct();
            this.tabControlSite.SuspendLayout();
            this.tabPageSiteFirst.SuspendLayout();
            this.tabPageSiteNext.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSite
            // 
            this.tabControlSite.Controls.Add(this.tabPageSiteFirst);
            this.tabControlSite.Controls.Add(this.tabPageSiteNext);
            this.tabControlSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSite.Location = new System.Drawing.Point(0, 0);
            this.tabControlSite.Name = "tabControlSite";
            this.tabControlSite.SelectedIndex = 0;
            this.tabControlSite.Size = new System.Drawing.Size(984, 561);
            this.tabControlSite.TabIndex = 0;
            this.tabControlSite.SelectedIndexChanged += new System.EventHandler(this.tabControlSite_SelectedIndexChanged);
            // 
            // tabPageSiteFirst
            // 
            this.tabPageSiteFirst.Controls.Add(this.controlProductSiteCopyFirst);
            this.tabPageSiteFirst.Location = new System.Drawing.Point(4, 22);
            this.tabPageSiteFirst.Name = "tabPageSiteFirst";
            this.tabPageSiteFirst.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSiteFirst.Size = new System.Drawing.Size(976, 535);
            this.tabPageSiteFirst.TabIndex = 0;
            this.tabPageSiteFirst.Text = "Site Copy 1";
            this.tabPageSiteFirst.UseVisualStyleBackColor = true;
            // 
            // controlProductSiteCopyFirst
            // 
            this.controlProductSiteCopyFirst.ConnectionString = "Data Source=10.252.2.142;Initial Catalog=ProductManagementDB;User ID=sa;Password=" +
    "123;Encrypt=True;TrustServerCertificate=True;";
            this.controlProductSiteCopyFirst.ConnectionStringNext = "Data Source=DESKTOP-7B6MP5S;Initial Catalog=ProductManagementDB;User ID=sa;Passwo" +
    "rd=123;Encrypt=True;TrustServerCertificate=True;";
            this.controlProductSiteCopyFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlProductSiteCopyFirst.Location = new System.Drawing.Point(3, 3);
            this.controlProductSiteCopyFirst.Name = "controlProductSiteCopyFirst";
            this.controlProductSiteCopyFirst.Size = new System.Drawing.Size(970, 529);
            this.controlProductSiteCopyFirst.TabIndex = 0;
            // 
            // tabPageSiteNext
            // 
            this.tabPageSiteNext.Controls.Add(this.controlProductSiteCopyNext);
            this.tabPageSiteNext.Location = new System.Drawing.Point(4, 22);
            this.tabPageSiteNext.Name = "tabPageSiteNext";
            this.tabPageSiteNext.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSiteNext.Size = new System.Drawing.Size(976, 535);
            this.tabPageSiteNext.TabIndex = 1;
            this.tabPageSiteNext.Text = "Site Copy 2";
            this.tabPageSiteNext.UseVisualStyleBackColor = true;
            // 
            // controlProductSiteCopyNext
            // 
            this.controlProductSiteCopyNext.ConnectionString = "Data Source=DESKTOP-7B6MP5S;Initial Catalog=ProductManagementDB;User ID=sa;Passwo" +
    "rd=123;Encrypt=True;TrustServerCertificate=True;";
            this.controlProductSiteCopyNext.ConnectionStringNext = null;
            this.controlProductSiteCopyNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlProductSiteCopyNext.Location = new System.Drawing.Point(3, 3);
            this.controlProductSiteCopyNext.Name = "controlProductSiteCopyNext";
            this.controlProductSiteCopyNext.Size = new System.Drawing.Size(970, 529);
            this.controlProductSiteCopyNext.TabIndex = 0;
            // 
            // FormDemo2SiteCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControlSite);
            this.Name = "FormDemo2SiteCopy";
            this.Text = "DemoForm4";
            this.tabControlSite.ResumeLayout(false);
            this.tabPageSiteFirst.ResumeLayout(false);
            this.tabPageSiteNext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlSite;
        private System.Windows.Forms.TabPage tabPageSiteFirst;
        private ControlProduct controlProductSiteCopyFirst;
        private System.Windows.Forms.TabPage tabPageSiteNext;
        private ControlProduct controlProductSiteCopyNext;
    }
}