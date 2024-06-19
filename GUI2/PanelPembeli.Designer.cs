namespace GUI
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
            welcomeLabel = new Label();
            refreshButton = new Button();
            tabControl1 = new TabControl();
            HomePage = new TabPage();
            statusComboBox = new ComboBox();
            label1 = new Label();
            PesananPage = new TabPage();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            penjualId = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            Deskripsi = new DataGridViewTextBoxColumn();
            Stok = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)produkGridView).BeginInit();
            tabControl1.SuspendLayout();
            HomePage.SuspendLayout();
            PesananPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            produkGridView.Columns.AddRange(new DataGridViewColumn[] { ID, penjualId, Nama, Harga, Deskripsi, Stok });
            produkGridView.Location = new Point(9, 88);
            produkGridView.Margin = new Padding(3, 4, 3, 4);
            produkGridView.MultiSelect = false;
            produkGridView.Name = "produkGridView";
            produkGridView.ReadOnly = true;
            produkGridView.RowHeadersVisible = false;
            produkGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            produkGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            produkGridView.Size = new Size(503, 464);
            produkGridView.TabIndex = 3;
            produkGridView.CellDoubleClick += selectProduk;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(7, 20);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(118, 20);
            welcomeLabel.TabIndex = 4;
            welcomeLabel.Text = "Selamat datang ";
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(542, 175);
            refreshButton.Margin = new Padding(3, 4, 3, 4);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(86, 31);
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
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(914, 600);
            tabControl1.TabIndex = 13;
            // 
            // HomePage
            // 
            HomePage.Controls.Add(statusComboBox);
            HomePage.Controls.Add(label1);
            HomePage.Controls.Add(welcomeLabel);
            HomePage.Controls.Add(refreshButton);
            HomePage.Controls.Add(produkGridView);
            HomePage.Location = new Point(4, 29);
            HomePage.Margin = new Padding(3, 4, 3, 4);
            HomePage.Name = "HomePage";
            HomePage.Padding = new Padding(3, 4, 3, 4);
            HomePage.Size = new Size(906, 567);
            HomePage.TabIndex = 0;
            HomePage.Text = "Home";
            HomePage.UseVisualStyleBackColor = true;
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Items.AddRange(new object[] { "Semua", "Banyak", "Sedikit", "Habis" });
            statusComboBox.Location = new Point(542, 121);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(151, 28);
            statusComboBox.TabIndex = 14;
            statusComboBox.SelectedIndexChanged += statusComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(542, 89);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 13;
            label1.Text = "Stok";
            // 
            // PesananPage
            // 
            PesananPage.Controls.Add(dataGridView1);
            PesananPage.Location = new Point(4, 29);
            PesananPage.Margin = new Padding(3, 4, 3, 4);
            PesananPage.Name = "PesananPage";
            PesananPage.Padding = new Padding(3, 4, 3, 4);
            PesananPage.Size = new Size(906, 567);
            PesananPage.TabIndex = 1;
            PesananPage.Text = "Pesanan";
            PesananPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(302, 187);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(274, 200);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 125;
            // 
            // penjualId
            // 
            penjualId.HeaderText = "PenjualId";
            penjualId.MinimumWidth = 6;
            penjualId.Name = "penjualId";
            penjualId.ReadOnly = true;
            penjualId.Visible = false;
            penjualId.Width = 125;
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama";
            Nama.MinimumWidth = 6;
            Nama.Name = "Nama";
            Nama.ReadOnly = true;
            Nama.Width = 125;
            // 
            // Harga
            // 
            Harga.HeaderText = "Harga";
            Harga.MinimumWidth = 6;
            Harga.Name = "Harga";
            Harga.ReadOnly = true;
            Harga.Width = 125;
            // 
            // Deskripsi
            // 
            Deskripsi.HeaderText = "Deskripsi";
            Deskripsi.MinimumWidth = 6;
            Deskripsi.Name = "Deskripsi";
            Deskripsi.ReadOnly = true;
            Deskripsi.Width = 125;
            // 
            // Stok
            // 
            Stok.HeaderText = "Stok";
            Stok.MinimumWidth = 6;
            Stok.Name = "Stok";
            Stok.ReadOnly = true;
            Stok.Width = 125;
            // 
            // PanelPembeli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PanelPembeli";
            Text = "PanelPembeli";
            FormClosed += PanelPembeli_FormClosed;
            ((System.ComponentModel.ISupportInitialize)produkGridView).EndInit();
            tabControl1.ResumeLayout(false);
            HomePage.ResumeLayout(false);
            HomePage.PerformLayout();
            PesananPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView produkGridView;
        private Label welcomeLabel;
        private Button refreshButton;
        private TabControl tabControl1;
        private TabPage HomePage;
        private TabPage PesananPage;
        private DataGridView dataGridView1;
        private ComboBox statusComboBox;
        private Label label1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn penjualId;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Deskripsi;
        private DataGridViewTextBoxColumn Stok;
    }
}