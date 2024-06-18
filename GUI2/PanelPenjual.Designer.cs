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
            PesananPage = new TabPage();
            button1 = new Button();
            pesananDataGridView = new DataGridView();
            Pembeli = new DataGridViewTextBoxColumn();
            Produk = new DataGridViewTextBoxColumn();
            Jumlah = new DataGridViewTextBoxColumn();
            TotalHarga = new DataGridViewTextBoxColumn();
            Alamat = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)produkGridView).BeginInit();
            tabControl1.SuspendLayout();
            HomePage.SuspendLayout();
            PesananPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pesananDataGridView).BeginInit();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(19, 20);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(159, 28);
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
            produkGridView.Columns.AddRange(new DataGridViewColumn[] { Nama, Harga, Deskripsi });
            produkGridView.Location = new Point(19, 99);
            produkGridView.Margin = new Padding(3, 4, 3, 4);
            produkGridView.Name = "produkGridView";
            produkGridView.RowHeadersVisible = false;
            produkGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            produkGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            produkGridView.Size = new Size(379, 453);
            produkGridView.TabIndex = 2;
            produkGridView.CellContentClick += produkGridView_CellContentClick;
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tambahProdukButton
            // 
            tambahProdukButton.Location = new Point(432, 99);
            tambahProdukButton.Margin = new Padding(3, 4, 3, 4);
            tambahProdukButton.Name = "tambahProdukButton";
            tambahProdukButton.Size = new Size(115, 31);
            tambahProdukButton.TabIndex = 10;
            tambahProdukButton.Text = "Tambah Produk";
            tambahProdukButton.UseVisualStyleBackColor = true;
            tambahProdukButton.Click += tambahProdukButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(432, 138);
            refreshButton.Margin = new Padding(3, 4, 3, 4);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(115, 31);
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
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(775, 600);
            tabControl1.TabIndex = 12;
            // 
            // HomePage
            // 
            HomePage.Controls.Add(produkGridView);
            HomePage.Controls.Add(welcomeLabel);
            HomePage.Controls.Add(tambahProdukButton);
            HomePage.Controls.Add(refreshButton);
            HomePage.Location = new Point(4, 29);
            HomePage.Margin = new Padding(3, 4, 3, 4);
            HomePage.Name = "HomePage";
            HomePage.Padding = new Padding(3, 4, 3, 4);
            HomePage.Size = new Size(767, 567);
            HomePage.TabIndex = 0;
            HomePage.Text = "Home";
            HomePage.UseVisualStyleBackColor = true;
            // 
            // PesananPage
            // 
            PesananPage.Location = new Point(4, 29);
            PesananPage.Margin = new Padding(3, 4, 3, 4);
            PesananPage.Name = "PesananPage";
            PesananPage.Padding = new Padding(3, 4, 3, 4);
            PesananPage.Size = new Size(767, 567);
            PesananPage.TabIndex = 1;
            PesananPage.Text = "Pesanan";
            PesananPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(546, 228);
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
            pesananDataGridView.Columns.AddRange(new DataGridViewColumn[] { Pembeli, Produk, Jumlah, TotalHarga, Alamat });
            pesananDataGridView.Location = new Point(66, 46);
            pesananDataGridView.Name = "pesananDataGridView";
            pesananDataGridView.ReadOnly = true;
            pesananDataGridView.RowHeadersVisible = false;
            pesananDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            pesananDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pesananDataGridView.Size = new Size(555, 140);
            pesananDataGridView.TabIndex = 3;
            // 
            // Pembeli
            // 
            Pembeli.HeaderText = "Pembeli";
            Pembeli.Name = "Pembeli";
            Pembeli.ReadOnly = true;
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
            // PanelPenjual
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(775, 600);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PanelPenjual";
            Text = "PanelPenjual";
            FormClosed += PanelPenjual_FormClosed;
            ((System.ComponentModel.ISupportInitialize)produkGridView).EndInit();
            tabControl1.ResumeLayout(false);
            HomePage.ResumeLayout(false);
            HomePage.PerformLayout();
            PesananPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pesananDataGridView).EndInit();
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
        private DataGridViewTextBoxColumn Pembeli;
        private DataGridViewTextBoxColumn Produk;
        private DataGridViewTextBoxColumn Jumlah;
        private DataGridViewTextBoxColumn TotalHarga;
        private DataGridViewTextBoxColumn Alamat;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Deskripsi;
        private Button button1;
    }
}