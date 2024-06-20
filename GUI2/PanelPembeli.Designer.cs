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
            components = new System.ComponentModel.Container();
            produkGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            penjualId = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            Deskripsi = new DataGridViewTextBoxColumn();
            Stok = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            welcomeLabel = new Label();
            refreshButton = new Button();
            tabControl1 = new TabControl();
            HomePage = new TabPage();
            searchButton = new Button();
            searchTextBox = new TextBox();
            statusComboBox = new ComboBox();
            label1 = new Label();
            PesananPage = new TabPage();
            button1 = new Button();
            pesananDataGridView = new DataGridView();
            Penjual = new DataGridViewTextBoxColumn();
            Produk = new DataGridViewTextBoxColumn();
            Jumlah = new DataGridViewTextBoxColumn();
            TotalHarga = new DataGridViewTextBoxColumn();
            Alamat = new DataGridViewTextBoxColumn();
            StatusPesanan = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            databaseBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)produkGridView).BeginInit();
            tabControl1.SuspendLayout();
            HomePage.SuspendLayout();
            PesananPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pesananDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // produkGridView
            // 
            produkGridView.AllowUserToAddRows = false;
            produkGridView.AllowUserToDeleteRows = false;
            produkGridView.AllowUserToResizeColumns = false;
            produkGridView.AllowUserToResizeRows = false;
            produkGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            produkGridView.BackgroundColor = Color.White;
            produkGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            produkGridView.Columns.AddRange(new DataGridViewColumn[] { ID, penjualId, Nama, Harga, Deskripsi, Stok, Status });
            produkGridView.Location = new Point(8, 66);
            produkGridView.MultiSelect = false;
            produkGridView.Name = "produkGridView";
            produkGridView.ReadOnly = true;
            produkGridView.RowHeadersVisible = false;
            produkGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            produkGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            produkGridView.Size = new Size(533, 348);
            produkGridView.TabIndex = 3;
            produkGridView.CellDoubleClick += selectProduk;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // penjualId
            // 
            penjualId.HeaderText = "PenjualId";
            penjualId.MinimumWidth = 6;
            penjualId.Name = "penjualId";
            penjualId.ReadOnly = true;
            penjualId.Visible = false;
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama";
            Nama.MinimumWidth = 6;
            Nama.Name = "Nama";
            Nama.ReadOnly = true;
            // 
            // Harga
            // 
            Harga.HeaderText = "Harga";
            Harga.MinimumWidth = 6;
            Harga.Name = "Harga";
            Harga.ReadOnly = true;
            // 
            // Deskripsi
            // 
            Deskripsi.HeaderText = "Deskripsi";
            Deskripsi.MinimumWidth = 6;
            Deskripsi.Name = "Deskripsi";
            Deskripsi.ReadOnly = true;
            // 
            // Stok
            // 
            Stok.HeaderText = "Stok";
            Stok.MinimumWidth = 6;
            Stok.Name = "Stok";
            Stok.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
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
            refreshButton.Location = new Point(547, 391);
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
            HomePage.Controls.Add(searchButton);
            HomePage.Controls.Add(searchTextBox);
            HomePage.Controls.Add(statusComboBox);
            HomePage.Controls.Add(label1);
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
            HomePage.Click += HomePage_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(705, 65);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 17;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(551, 66);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(148, 23);
            searchTextBox.TabIndex = 15;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // statusComboBox
            // 
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Items.AddRange(new object[] { "Semua", "Banyak", "Sedikit", "Habis" });
            statusComboBox.Location = new Point(551, 122);
            statusComboBox.Margin = new Padding(3, 2, 3, 2);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(133, 23);
            statusComboBox.TabIndex = 14;
            statusComboBox.SelectedIndexChanged += statusComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(551, 98);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 13;
            label1.Text = "Stok";
            // 
            // PesananPage
            // 
            PesananPage.Controls.Add(button1);
            PesananPage.Controls.Add(pesananDataGridView);
            PesananPage.Location = new Point(4, 24);
            PesananPage.Margin = new Padding(3, 2, 3, 2);
            PesananPage.Name = "PesananPage";
            PesananPage.Padding = new Padding(3);
            PesananPage.Size = new Size(792, 422);
            PesananPage.TabIndex = 1;
            PesananPage.Text = "Pesanan";
            PesananPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(718, 11);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(66, 23);
            button1.TabIndex = 5;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += refreshButton_Click;
            // 
            // pesananDataGridView
            // 
            pesananDataGridView.AllowUserToAddRows = false;
            pesananDataGridView.AllowUserToDeleteRows = false;
            pesananDataGridView.AllowUserToResizeColumns = false;
            pesananDataGridView.AllowUserToResizeRows = false;
            pesananDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pesananDataGridView.BackgroundColor = Color.White;
            pesananDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pesananDataGridView.Columns.AddRange(new DataGridViewColumn[] { Penjual, Produk, Jumlah, TotalHarga, Alamat, StatusPesanan });
            pesananDataGridView.Dock = DockStyle.Bottom;
            pesananDataGridView.Location = new Point(3, 38);
            pesananDataGridView.Margin = new Padding(3, 2, 3, 2);
            pesananDataGridView.Name = "pesananDataGridView";
            pesananDataGridView.ReadOnly = true;
            pesananDataGridView.RowHeadersVisible = false;
            pesananDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            pesananDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pesananDataGridView.Size = new Size(786, 381);
            pesananDataGridView.TabIndex = 4;
            // 
            // Penjual
            // 
            Penjual.HeaderText = "Penjual";
            Penjual.Name = "Penjual";
            Penjual.ReadOnly = true;
            // 
            // Produk
            // 
            Produk.HeaderText = "Produk";
            Produk.Name = "Produk";
            Produk.ReadOnly = true;
            // 
            // Jumlah
            // 
            Jumlah.HeaderText = "Jumlah";
            Jumlah.Name = "Jumlah";
            Jumlah.ReadOnly = true;
            // 
            // TotalHarga
            // 
            TotalHarga.HeaderText = "Total Harga";
            TotalHarga.Name = "TotalHarga";
            TotalHarga.ReadOnly = true;
            // 
            // Alamat
            // 
            Alamat.HeaderText = "Alamat";
            Alamat.Name = "Alamat";
            Alamat.ReadOnly = true;
            // 
            // StatusPesanan
            // 
            StatusPesanan.HeaderText = "Status";
            StatusPesanan.Name = "StatusPesanan";
            StatusPesanan.ReadOnly = true;
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
            // databaseBindingSource
            // 
            databaseBindingSource.DataSource = typeof(ShopApiClient.Database);
            // 
            // PanelPembeli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "PanelPembeli";
            Text = "PanelPembeli";
            FormClosed += PanelPembeli_FormClosed;
            ((System.ComponentModel.ISupportInitialize)produkGridView).EndInit();
            tabControl1.ResumeLayout(false);
            HomePage.ResumeLayout(false);
            HomePage.PerformLayout();
            PesananPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pesananDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).EndInit();
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
        private DataGridView pesananDataGridView;
        private Button button1;
        private DataGridViewTextBoxColumn Penjual;
        private DataGridViewTextBoxColumn Produk;
        private DataGridViewTextBoxColumn Jumlah;
        private DataGridViewTextBoxColumn TotalHarga;
        private DataGridViewTextBoxColumn Alamat;
        private DataGridViewTextBoxColumn StatusPesanan;
        private TextBox searchTextBox;
        private BindingSource databaseBindingSource;
        private Button searchButton;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn penjualId;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Deskripsi;
        private DataGridViewTextBoxColumn Stok;
        private DataGridViewTextBoxColumn Status;
        private ComboBox hargaComboBox;
        private Label label2;
    }
}