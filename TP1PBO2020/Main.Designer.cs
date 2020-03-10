namespace TP1PBO2020
{
    partial class Main
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.tcMenu = new System.Windows.Forms.TabControl();
            this.tpMenuBeli = new System.Windows.Forms.TabPage();
            this.tpMenuBeliDetail = new System.Windows.Forms.TabPage();
            this.btMenuBeli = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tpMenuKatalog = new System.Windows.Forms.TabPage();
            this.flpMenuBeli = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbJenisProduk = new System.Windows.Forms.ComboBox();
            this.cbHargaProduk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCari = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btLogout = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pnlSideBar.SuspendLayout();
            this.tcMenu.SuspendLayout();
            this.tpMenuBeli.SuspendLayout();
            this.tpMenuKatalog.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(951, 39);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlSideBar.Controls.Add(this.btLogout);
            this.pnlSideBar.Controls.Add(this.button1);
            this.pnlSideBar.Controls.Add(this.btMenuBeli);
            this.pnlSideBar.Location = new System.Drawing.Point(0, 38);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(174, 563);
            this.pnlSideBar.TabIndex = 1;
            // 
            // tcMenu
            // 
            this.tcMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcMenu.Controls.Add(this.tpMenuBeli);
            this.tcMenu.Controls.Add(this.tpMenuBeliDetail);
            this.tcMenu.Controls.Add(this.tpMenuKatalog);
            this.tcMenu.Location = new System.Drawing.Point(174, 66);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.Size = new System.Drawing.Size(776, 535);
            this.tcMenu.TabIndex = 2;
            // 
            // tpMenuBeli
            // 
            this.tpMenuBeli.Controls.Add(this.flpMenuBeli);
            this.tpMenuBeli.Location = new System.Drawing.Point(4, 25);
            this.tpMenuBeli.Name = "tpMenuBeli";
            this.tpMenuBeli.Padding = new System.Windows.Forms.Padding(3);
            this.tpMenuBeli.Size = new System.Drawing.Size(768, 506);
            this.tpMenuBeli.TabIndex = 0;
            this.tpMenuBeli.Text = "tabPage1";
            this.tpMenuBeli.UseVisualStyleBackColor = true;
            // 
            // tpMenuBeliDetail
            // 
            this.tpMenuBeliDetail.Location = new System.Drawing.Point(4, 25);
            this.tpMenuBeliDetail.Name = "tpMenuBeliDetail";
            this.tpMenuBeliDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tpMenuBeliDetail.Size = new System.Drawing.Size(768, 506);
            this.tpMenuBeliDetail.TabIndex = 1;
            this.tpMenuBeliDetail.Text = "tabPage2";
            this.tpMenuBeliDetail.UseVisualStyleBackColor = true;
            // 
            // btMenuBeli
            // 
            this.btMenuBeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenuBeli.Location = new System.Drawing.Point(0, 85);
            this.btMenuBeli.Name = "btMenuBeli";
            this.btMenuBeli.Size = new System.Drawing.Size(174, 34);
            this.btMenuBeli.TabIndex = 0;
            this.btMenuBeli.Text = "Menu Beli";
            this.btMenuBeli.UseVisualStyleBackColor = true;
            this.btMenuBeli.Click += new System.EventHandler(this.btMenuBeli_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Menu Katalog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tpMenuKatalog
            // 
            this.tpMenuKatalog.Controls.Add(this.webBrowser1);
            this.tpMenuKatalog.Location = new System.Drawing.Point(4, 25);
            this.tpMenuKatalog.Name = "tpMenuKatalog";
            this.tpMenuKatalog.Size = new System.Drawing.Size(768, 506);
            this.tpMenuKatalog.TabIndex = 2;
            this.tpMenuKatalog.Text = "tabPage3";
            this.tpMenuKatalog.UseVisualStyleBackColor = true;
            // 
            // flpMenuBeli
            // 
            this.flpMenuBeli.AutoScroll = true;
            this.flpMenuBeli.Location = new System.Drawing.Point(0, 0);
            this.flpMenuBeli.Name = "flpMenuBeli";
            this.flpMenuBeli.Size = new System.Drawing.Size(768, 505);
            this.flpMenuBeli.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btCari);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbHargaProduk);
            this.panel1.Controls.Add(this.cbJenisProduk);
            this.panel1.Location = new System.Drawing.Point(173, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 53);
            this.panel1.TabIndex = 3;
            // 
            // cbJenisProduk
            // 
            this.cbJenisProduk.DisplayMember = "sd";
            this.cbJenisProduk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJenisProduk.FormattingEnabled = true;
            this.cbJenisProduk.Items.AddRange(new object[] {
            "-Jenis Produk-",
            "Baju",
            "Elektronik",
            "Makanan"});
            this.cbJenisProduk.Location = new System.Drawing.Point(436, 25);
            this.cbJenisProduk.Name = "cbJenisProduk";
            this.cbJenisProduk.Size = new System.Drawing.Size(121, 21);
            this.cbJenisProduk.TabIndex = 0;
            // 
            // cbHargaProduk
            // 
            this.cbHargaProduk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHargaProduk.FormattingEnabled = true;
            this.cbHargaProduk.Items.AddRange(new object[] {
            "-Range Harga-",
            "100.000 - 200.000",
            "200.000 - 500.000",
            "500.000 - 1.000.000"});
            this.cbHargaProduk.Location = new System.Drawing.Point(563, 25);
            this.cbHargaProduk.Name = "cbHargaProduk";
            this.cbHargaProduk.Size = new System.Drawing.Size(121, 21);
            this.cbHargaProduk.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Urut Berdasarkan:";
            // 
            // btCari
            // 
            this.btCari.Location = new System.Drawing.Point(690, 24);
            this.btCari.Name = "btCari";
            this.btCari.Size = new System.Drawing.Size(75, 23);
            this.btCari.TabIndex = 3;
            this.btCari.Text = "Cari";
            this.btCari.UseVisualStyleBackColor = true;
            this.btCari.Click += new System.EventHandler(this.btCari_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Produk Tersedia:";
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.ForeColor = System.Drawing.Color.White;
            this.btLogout.Location = new System.Drawing.Point(0, 529);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(174, 34);
            this.btLogout.TabIndex = 2;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(768, 506);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://shopee.co.id", System.UriKind.Absolute);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcMenu);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSideBar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.tcMenu.ResumeLayout(false);
            this.tpMenuBeli.ResumeLayout(false);
            this.tpMenuKatalog.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.TabControl tcMenu;
        private System.Windows.Forms.TabPage tpMenuBeli;
        private System.Windows.Forms.TabPage tpMenuBeliDetail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btMenuBeli;
        private System.Windows.Forms.TabPage tpMenuKatalog;
        private System.Windows.Forms.FlowLayoutPanel flpMenuBeli;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHargaProduk;
        private System.Windows.Forms.ComboBox cbJenisProduk;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}