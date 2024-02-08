
namespace BTL_HTPT
{
    partial class FormDemo6Site
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
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.controlProductSiteOwner = new BTL_HTPT.ControlProduct();
            this.controlProductSiteCopy1 = new BTL_HTPT.ControlProduct();
            this.controlProductSiteCopy2 = new BTL_HTPT.ControlProduct();
            this.controlProductSiteCopy3 = new BTL_HTPT.ControlProduct();
            this.controlProductSiteCopy4 = new BTL_HTPT.ControlProduct();
            this.controlProductSiteCopy5 = new BTL_HTPT.ControlProduct();
            this.tabControlSite.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSite
            // 
            this.tabControlSite.Controls.Add(this.tabPageMain);
            this.tabControlSite.Controls.Add(this.tabPage2);
            this.tabControlSite.Controls.Add(this.tabPage3);
            this.tabControlSite.Controls.Add(this.tabPage4);
            this.tabControlSite.Controls.Add(this.tabPage5);
            this.tabControlSite.Controls.Add(this.tabPage1);
            this.tabControlSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSite.Location = new System.Drawing.Point(0, 0);
            this.tabControlSite.Name = "tabControlSite";
            this.tabControlSite.SelectedIndex = 0;
            this.tabControlSite.Size = new System.Drawing.Size(984, 561);
            this.tabControlSite.TabIndex = 0;
            this.tabControlSite.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.controlProductSiteOwner);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(976, 535);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Site Chủ";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.controlProductSiteCopy1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bản sao 1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.controlProductSiteCopy2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(776, 535);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bản sao 2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.controlProductSiteCopy3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(776, 535);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Bản sao 3";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.controlProductSiteCopy4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(776, 535);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Bản sao 4";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.controlProductSiteCopy5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 535);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Bản sao 5";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // controlProductSiteOwner
            // 
            this.controlProductSiteOwner.ConnectionString = "Data Source=DESKTOP-7B6MP5S;Initial Catalog=ProductManagementDB;User ID=sa;Passwo" +
    "rd=123;Encrypt=True;TrustServerCertificate=True;";
            this.controlProductSiteOwner.ConnectionStringNext = "Data Source=DESKTOP-7B6MP5S\\MSSQLSERVER1;Initial Catalog=ProductManagementDB;User" +
    " ID=sa;Password=123;Encrypt=True;TrustServerCertificate=True;";
            this.controlProductSiteOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlProductSiteOwner.Location = new System.Drawing.Point(3, 3);
            this.controlProductSiteOwner.Name = "controlProductSiteOwner";
            this.controlProductSiteOwner.Size = new System.Drawing.Size(970, 529);
            this.controlProductSiteOwner.TabIndex = 0;
            // 
            // controlProductSiteCopy1
            // 
            this.controlProductSiteCopy1.ConnectionString = "Data Source=DESKTOP-7B6MP5S\\MSSQLSERVER1;Initial Catalog=ProductManagementDB;User" +
    " ID=sa;Password=123;Encrypt=True;TrustServerCertificate=True;";
            this.controlProductSiteCopy1.ConnectionStringNext = "Data Source=DESKTOP-7B6MP5S;Initial Catalog=ProductManagementDB;User ID=sa;Passwo" +
    "rd=123;Encrypt=True;TrustServerCertificate=True;";
            this.controlProductSiteCopy1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlProductSiteCopy1.Location = new System.Drawing.Point(3, 3);
            this.controlProductSiteCopy1.Name = "controlProductSiteCopy1";
            this.controlProductSiteCopy1.Size = new System.Drawing.Size(770, 529);
            this.controlProductSiteCopy1.TabIndex = 0;
            // 
            // controlProductSiteCopy2
            // 
            this.controlProductSiteCopy2.ConnectionString = "Data Source=DESKTOP-7B6MP5S;Initial Catalog=ProductManagementDB;User ID=sa;Passwo" +
    "rd=123;Encrypt=True;TrustServerCertificate=True;";
            this.controlProductSiteCopy2.ConnectionStringNext = "Data Source=DESKTOP-7B6MP5S;Initial Catalog=ProductManagementDB;User ID=sa;Passwo" +
    "rd=123;Encrypt=True;TrustServerCertificate=True;";
            this.controlProductSiteCopy2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlProductSiteCopy2.Location = new System.Drawing.Point(3, 3);
            this.controlProductSiteCopy2.Name = "controlProductSiteCopy2";
            this.controlProductSiteCopy2.Size = new System.Drawing.Size(770, 529);
            this.controlProductSiteCopy2.TabIndex = 0;
            // 
            // controlProductSiteCopy3
            // 
            this.controlProductSiteCopy3.ConnectionString = "Data Source=DESKTOP-7B6MP5S;Initial Catalog=ProductManagementDB;User ID=sa;Passwo" +
    "rd=123;Encrypt=True;TrustServerCertificate=True;";
            this.controlProductSiteCopy3.ConnectionStringNext = "Data Source=DESKTOP-7B6MP5S;Initial Catalog=ProductManagementDB;User ID=sa;Passwo" +
    "rd=123;Encrypt=True;TrustServerCertificate=True;";
            this.controlProductSiteCopy3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlProductSiteCopy3.Location = new System.Drawing.Point(3, 3);
            this.controlProductSiteCopy3.Name = "controlProductSiteCopy3";
            this.controlProductSiteCopy3.Size = new System.Drawing.Size(770, 529);
            this.controlProductSiteCopy3.TabIndex = 0;
            // 
            // controlProductSiteCopy4
            // 
            this.controlProductSiteCopy4.ConnectionString = "Data Source=DESKTOP-7B6MP5S;Initial Catalog=ProductManagementDB;User ID=sa;Passwo" +
    "rd=123;Encrypt=True;TrustServerCertificate=True;";
            this.controlProductSiteCopy4.ConnectionStringNext = "Data Source=DESKTOP-7B6MP5S;Initial Catalog=ProductManagementDB;User ID=sa;Passwo" +
    "rd=123;Encrypt=True;TrustServerCertificate=True;";
            this.controlProductSiteCopy4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlProductSiteCopy4.Location = new System.Drawing.Point(3, 3);
            this.controlProductSiteCopy4.Name = "controlProductSiteCopy4";
            this.controlProductSiteCopy4.Size = new System.Drawing.Size(770, 529);
            this.controlProductSiteCopy4.TabIndex = 0;
            // 
            // controlProductSiteCopy5
            // 
            this.controlProductSiteCopy5.ConnectionString = "Data Source=DESKTOP-7B6MP5S;Initial Catalog=ProductManagementDB;User ID=sa;Passwo" +
    "rd=123;Encrypt=True;TrustServerCertificate=True;";
            this.controlProductSiteCopy5.ConnectionStringNext = "Data Source=DESKTOP-7B6MP5S;Initial Catalog=ProductManagementDB;User ID=sa;Passwo" +
    "rd=123;Encrypt=True;TrustServerCertificate=True;";
            this.controlProductSiteCopy5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlProductSiteCopy5.Location = new System.Drawing.Point(3, 3);
            this.controlProductSiteCopy5.Name = "controlProductSiteCopy5";
            this.controlProductSiteCopy5.Size = new System.Drawing.Size(770, 529);
            this.controlProductSiteCopy5.TabIndex = 1;
            // 
            // FormDemo6Site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControlSite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDemo6Site";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo1";
            this.tabControlSite.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSite;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private ControlProduct controlProductSiteOwner;
        private ControlProduct controlProductSiteCopy1;
        private ControlProduct controlProductSiteCopy2;
        private ControlProduct controlProductSiteCopy3;
        private ControlProduct controlProductSiteCopy4;
        private System.Windows.Forms.TabPage tabPage1;
        private ControlProduct controlProductSiteCopy5;
    }
}