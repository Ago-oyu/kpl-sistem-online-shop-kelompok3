﻿namespace GUI
{
    partial class PanelPembeli
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
            produkGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            penjualId = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            Deskripsi = new DataGridViewTextBoxColumn();
            welcomeLabel = new Label();
            refreshButton = new Button();
            tabControl1 = new TabControl();
            HomePage = new TabPage();
            PesananPage = new TabPage();
            ((System.ComponentModel.ISupportInitialize)produkGridView).BeginInit();
            tabControl1.SuspendLayout();
            HomePage.SuspendLayout();
            SuspendLayout();
            // 
            // produkGridView
            // 
            produkGridView.AllowUserToAddRows = false;
            produkGridView.AllowUserToDeleteRows = false;
            produkGridView.AllowUserToResizeColumns = false;
            produkGridView.AllowUserToResizeRows = false;
            produkGridView.BackgroundColor = Color.White;
            produkGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            produkGridView.Columns.AddRange(new DataGridViewColumn[] { ID, penjualId, Nama, Harga, Deskripsi });
            produkGridView.Location = new Point(8, 66);
            produkGridView.MultiSelect = false;
            produkGridView.Name = "produkGridView";
            produkGridView.ReadOnly = true;
            produkGridView.RowHeadersVisible = false;
            produkGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            produkGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            produkGridView.Size = new Size(332, 348);
            produkGridView.TabIndex = 3;
            produkGridView.CellDoubleClick += selectProduk;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // penjualId
            // 
            penjualId.HeaderText = "PenjualId";
            penjualId.Name = "penjualId";
            penjualId.ReadOnly = true;
            penjualId.Visible = false;
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama";
            Nama.Name = "Nama";
            Nama.ReadOnly = true;
            // 
            // Harga
            // 
            Harga.HeaderText = "Harga";
            Harga.Name = "Harga";
            Harga.ReadOnly = true;
            // 
            // Deskripsi
            // 
            Deskripsi.HeaderText = "Deskripsi";
            Deskripsi.Name = "Deskripsi";
            Deskripsi.ReadOnly = true;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(6, 15);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(92, 15);
            welcomeLabel.TabIndex = 4;
            welcomeLabel.Text = "Selamat datang ";
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(380, 391);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(75, 23);
            refreshButton.TabIndex = 12;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(HomePage);
            tabControl1.Controls.Add(PesananPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 13;
            // 
            // HomePage
            // 
            HomePage.Controls.Add(welcomeLabel);
            HomePage.Controls.Add(refreshButton);
            HomePage.Controls.Add(produkGridView);
            HomePage.Location = new Point(4, 24);
            HomePage.Name = "HomePage";
            HomePage.Padding = new Padding(3);
            HomePage.Size = new Size(792, 422);
            HomePage.TabIndex = 0;
            HomePage.Text = "Home";
            HomePage.UseVisualStyleBackColor = true;
            // 
            // PesananPage
            // 
            PesananPage.Location = new Point(4, 24);
            PesananPage.Name = "PesananPage";
            PesananPage.Padding = new Padding(3);
            PesananPage.Size = new Size(792, 422);
            PesananPage.TabIndex = 1;
            PesananPage.Text = "Pesanan";
            PesananPage.UseVisualStyleBackColor = true;
            // 
            // PanelPembeli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "PanelPembeli";
            Text = "PanelPembeli";
            ((System.ComponentModel.ISupportInitialize)produkGridView).EndInit();
            tabControl1.ResumeLayout(false);
            HomePage.ResumeLayout(false);
            HomePage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView produkGridView;
        private Label welcomeLabel;
        private Button refreshButton;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn penjualId;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Deskripsi;
        private TabControl tabControl1;
        private TabPage HomePage;
        private TabPage PesananPage;
    }
}