
namespace BTL_HTPT
{
    partial class FormDemoOwnerAndCopy
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSiteOwner = new System.Windows.Forms.TabPage();
            this.controlProductOwner = new BTL_HTPT.ControlProduct();
            this.tabPageSiteCopy1 = new System.Windows.Forms.TabPage();
            this.controlProductCopy = new BTL_HTPT.ControlProduct();
            this.tabControl1.SuspendLayout();
            this.tabPageSiteOwner.SuspendLayout();
            this.tabPageSiteCopy1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSiteOwner);
            this.tabControl1.Controls.Add(this.tabPageSiteCopy1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 561);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageSiteOwner
            // 
            this.tabPageSiteOwner.Controls.Add(this.controlProductOwner);
            this.tabPageSiteOwner.Location = new System.Drawing.Point(4, 22);
            this.tabPageSiteOwner.Name = "tabPageSiteOwner";
            this.tabPageSiteOwner.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSiteOwner.Size = new System.Drawing.Size(976, 535);
            this.tabPageSiteOwner.TabIndex = 0;
            this.tabPageSiteOwner.Text = "Site Chủ";
            this.tabPageSiteOwner.UseVisualStyleBackColor = true;
            // 
            // controlProductOwner
            // 
            this.controlProductOwner.ConnectionString = "Data Source=10.252.2.142;Initial Catalog=ProductManagementDB;User ID=sa;Password=" +
    "123;Encrypt=True;TrustServerCertificate=True;";
            this.controlProductOwner.ConnectionStringNext = "Data Source=DESKTOP-7B6MP5S;Initial Catalog=ProductManagementDB;User ID=sa;Passwo" +
    "rd=123;Encrypt=True;TrustServerCertificate=True;";
            this.controlProductOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlProductOwner.Location = new System.Drawing.Point(3, 3);
            this.controlProductOwner.Name = "controlProductOwner";
            this.controlProductOwner.Size = new System.Drawing.Size(970, 529);
            this.controlProductOwner.TabIndex = 0;
            // 
            // tabPageSiteCopy1
            // 
            this.tabPageSiteCopy1.Controls.Add(this.controlProductCopy);
            this.tabPageSiteCopy1.Location = new System.Drawing.Point(4, 22);
            this.tabPageSiteCopy1.Name = "tabPageSiteCopy1";
            this.tabPageSiteCopy1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSiteCopy1.Size = new System.Drawing.Size(976, 535);
            this.tabPageSiteCopy1.TabIndex = 1;
            this.tabPageSiteCopy1.Text = "Site Copy 1";
            this.tabPageSiteCopy1.UseVisualStyleBackColor = true;
            // 
            // controlProductCopy
            // 
            this.controlProductCopy.ConnectionString = "Data Source=DESKTOP-7B6MP5S;Initial Catalog=ProductManagementDB;User ID=sa;Passwo" +
    "rd=123;Encrypt=True;TrustServerCertificate=True;";
            this.controlProductCopy.ConnectionStringNext = null;
            this.controlProductCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlProductCopy.Location = new System.Drawing.Point(3, 3);
            this.controlProductCopy.Name = "controlProductCopy";
            this.controlProductCopy.Size = new System.Drawing.Size(970, 529);
            this.controlProductCopy.TabIndex = 0;
            // 
            // FormDemoOwnerAndCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormDemoOwnerAndCopy";
            this.Text = "Demo2";
            this.tabControl1.ResumeLayout(false);
            this.tabPageSiteOwner.ResumeLayout(false);
            this.tabPageSiteCopy1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSiteOwner;
        private System.Windows.Forms.TabPage tabPageSiteCopy1;
        private ControlProduct controlProductOwner;
        private ControlProduct controlProductCopy;
    }
}