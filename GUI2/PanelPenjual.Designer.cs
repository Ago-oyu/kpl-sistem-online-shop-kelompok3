namespace GUI
{
    partial class PanelPenjual
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
            welcomeLabel = new Label();
            produkGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            Deskripsi = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tambahProdukButton = new Button();
            refreshButton = new Button();
            tabControl1 = new TabControl();
            HomePage = new TabPage();
            button2 = new Button();
            PesananPage = new TabPage();
            label1 = new Label();
            jumlahPesananComboBox = new ComboBox();
            button1 = new Button();
            pesananDataGridView = new DataGridView();
            PembeliNama = new DataGridViewTextBoxColumn();
            ProdukNama = new DataGridViewTextBoxColumn();
            Jumlah = new DataGridViewTextBoxColumn();
            TotalHarga = new DataGridViewTextBoxColumn();
            Alamat = new DataGridViewTextBoxColumn();
            ProdukID = new DataGridViewTextBoxColumn();
            StatusPesanan = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            Penjual = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)produkGridView).BeginInit();
            tabControl1.SuspendLayout();
            HomePage.SuspendLayout();
            PesananPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pesananDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(17, 15);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(127, 21);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Selamat datang ";
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
            produkGridView.Columns.AddRange(new DataGridViewColumn[] { ID, Nama, Harga, Deskripsi });
            produkGridView.Location = new Point(17, 74);
            produkGridView.Name = "produkGridView";
            produkGridView.RowHeadersVisible = false;
            produkGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            produkGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            produkGridView.Size = new Size(332, 340);
            produkGridView.TabIndex = 2;
            produkGridView.CellClick += produkGridView_CellClick;
            produkGridView.CellDoubleClick += produkGridView_CellDoubleClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tambahProdukButton
            // 
            tambahProdukButton.Location = new Point(383, 117);
            tambahProdukButton.Name = "tambahProdukButton";
            tambahProdukButton.Size = new Size(101, 23);
            tambahProdukButton.TabIndex = 10;
            tambahProdukButton.Text = "Tambah Produk";
            tambahProdukButton.UseVisualStyleBackColor = true;
            tambahProdukButton.Click += tambahProdukButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(383, 176);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(101, 23);
            refreshButton.TabIndex = 11;
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
            tabControl1.Size = new Size(678, 450);
            tabControl1.TabIndex = 12;
            // 
            // HomePage
            // 
            HomePage.Controls.Add(button2);
            HomePage.Controls.Add(produkGridView);
            HomePage.Controls.Add(welcomeLabel);
            HomePage.Controls.Add(tambahProdukButton);
            HomePage.Controls.Add(refreshButton);
            HomePage.Location = new Point(4, 24);
            HomePage.Name = "HomePage";
            HomePage.Padding = new Padding(3);
            HomePage.Size = new Size(670, 422);
            HomePage.TabIndex = 0;
            HomePage.Text = "Home";
            HomePage.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(383, 146);
            button2.Name = "button2";
            button2.Size = new Size(101, 23);
            button2.TabIndex = 12;
            button2.Text = "Hapus Produk";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PesananPage
            // 
            PesananPage.Controls.Add(label1);
            PesananPage.Controls.Add(jumlahPesananComboBox);
            PesananPage.Controls.Add(button1);
            PesananPage.Controls.Add(pesananDataGridView);
            PesananPage.Location = new Point(4, 24);
            PesananPage.Name = "PesananPage";
            PesananPage.Padding = new Padding(3);
            PesananPage.Size = new Size(670, 422);
            PesananPage.TabIndex = 1;
            PesananPage.Text = "Pesanan";
            PesananPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 179);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 21;
            label1.Text = "Jumlah pesanan:";
            // 
            // jumlahPesananComboBox
            // 
            jumlahPesananComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            jumlahPesananComboBox.FormattingEnabled = true;
            jumlahPesananComboBox.Items.AddRange(new object[] { "Banyak", "Sedang", "Sedikit" });
            jumlahPesananComboBox.Location = new Point(450, 180);
            jumlahPesananComboBox.Margin = new Padding(3, 2, 3, 2);
            jumlahPesananComboBox.Name = "jumlahPesananComboBox";
            jumlahPesananComboBox.Size = new Size(133, 23);
            jumlahPesananComboBox.TabIndex = 20;
            jumlahPesananComboBox.SelectedIndexChanged += jumlahPesananComboBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(589, 179);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
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
            pesananDataGridView.Columns.AddRange(new DataGridViewColumn[] { PembeliNama, ProdukNama, Jumlah, TotalHarga, Alamat, ProdukID, StatusPesanan });
            pesananDataGridView.Dock = DockStyle.Bottom;
            pesananDataGridView.Location = new Point(3, 208);
            pesananDataGridView.Name = "pesananDataGridView";
            pesananDataGridView.ReadOnly = true;
            pesananDataGridView.RowHeadersVisible = false;
            pesananDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            pesananDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pesananDataGridView.Size = new Size(664, 211);
            pesananDataGridView.TabIndex = 3;
            pesananDataGridView.CellDoubleClick += pesananDataGridView_CellDoubleClick_1;
            // 
            // PembeliNama
            // 
            PembeliNama.HeaderText = "Pembeli";
            PembeliNama.Name = "PembeliNama";
            PembeliNama.ReadOnly = true;
            // 
            // ProdukNama
            // 
            ProdukNama.HeaderText = "Produk";
            ProdukNama.Name = "ProdukNama";
            ProdukNama.ReadOnly = true;
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
            // ProdukID
            // 
            ProdukID.HeaderText = "ProdukID";
            ProdukID.Name = "ProdukID";
            ProdukID.ReadOnly = true;
            ProdukID.Visible = false;
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
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Penjual, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView1.Location = new Point(58, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(555, 140);
            dataGridView1.TabIndex = 5;
            // 
            // Penjual
            // 
            Penjual.HeaderText = "Penjual";
            Penjual.Name = "Penjual";
            Penjual.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Produk";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Jumlah";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Total Harga";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Alamat";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // PanelPenjual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(678, 450);
            Controls.Add(tabControl1);
            Name = "PanelPenjual";
            Text = "PanelPenjual";
            FormClosed += PanelPenjual_FormClosed;
            ((System.ComponentModel.ISupportInitialize)produkGridView).EndInit();
            tabControl1.ResumeLayout(false);
            HomePage.ResumeLayout(false);
            HomePage.PerformLayout();
            PesananPage.ResumeLayout(false);
            PesananPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pesananDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label welcomeLabel;
        private DataGridView produkGridView;
        private ContextMenuStrip contextMenuStrip1;
        private Button tambahProdukButton;
        private Button refreshButton;
        private TabControl tabControl1;
        private TabPage HomePage;
        private TabPage PesananPage;
        private DataGridView pesananDataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Deskripsi;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Penjual;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button button2;
        private DataGridViewTextBoxColumn PembeliNama;
        private DataGridViewTextBoxColumn ProdukNama;
        private DataGridViewTextBoxColumn Jumlah;
        private DataGridViewTextBoxColumn TotalHarga;
        private DataGridViewTextBoxColumn Alamat;
        private DataGridViewTextBoxColumn ProdukID;
        private DataGridViewTextBoxColumn StatusPesanan;
        private ComboBox jumlahPesananComboBox;
        private Label label1;
    }
}