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
            Nama = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            Deskripsi = new DataGridViewTextBoxColumn();
            namaTextBox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deskripsiTextBox = new TextBox();
            stokNumericUpDown = new NumericUpDown();
            HargaNumericUpDown = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tambahProdukButton = new Button();
            refreshButton = new Button();
            tabControl1 = new TabControl();
            HomePage = new TabPage();
            PesananPage = new TabPage();
            ((System.ComponentModel.ISupportInitialize)produkGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stokNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HargaNumericUpDown).BeginInit();
            tabControl1.SuspendLayout();
            HomePage.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(17, 15);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(92, 15);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Selamat datang ";
            // 
            // produkGridView
            // 
            produkGridView.AllowUserToAddRows = false;
            produkGridView.AllowUserToDeleteRows = false;
            produkGridView.AllowUserToResizeColumns = false;
            produkGridView.AllowUserToResizeRows = false;
            produkGridView.BackgroundColor = Color.White;
            produkGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            produkGridView.Columns.AddRange(new DataGridViewColumn[] { Nama, Harga, Deskripsi });
            produkGridView.Location = new Point(17, 274);
            produkGridView.Name = "produkGridView";
            produkGridView.RowHeadersVisible = false;
            produkGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            produkGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            produkGridView.Size = new Size(332, 140);
            produkGridView.TabIndex = 2;
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
            // namaTextBox
            // 
            namaTextBox.Location = new Point(107, 58);
            namaTextBox.Name = "namaTextBox";
            namaTextBox.Size = new Size(100, 23);
            namaTextBox.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // deskripsiTextBox
            // 
            deskripsiTextBox.Location = new Point(107, 123);
            deskripsiTextBox.Multiline = true;
            deskripsiTextBox.Name = "deskripsiTextBox";
            deskripsiTextBox.Size = new Size(181, 53);
            deskripsiTextBox.TabIndex = 3;
            // 
            // stokNumericUpDown
            // 
            stokNumericUpDown.Location = new Point(107, 182);
            stokNumericUpDown.Name = "stokNumericUpDown";
            stokNumericUpDown.Size = new Size(120, 23);
            stokNumericUpDown.TabIndex = 4;
            // 
            // HargaNumericUpDown
            // 
            HargaNumericUpDown.Location = new Point(107, 87);
            HargaNumericUpDown.Name = "HargaNumericUpDown";
            HargaNumericUpDown.Size = new Size(120, 23);
            HargaNumericUpDown.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 58);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 6;
            label1.Text = "Nama:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 87);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 7;
            label2.Text = "Harga:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 123);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 8;
            label3.Text = "Deskripsi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 182);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 9;
            label4.Text = "Stok:";
            // 
            // tambahProdukButton
            // 
            tambahProdukButton.Location = new Point(107, 229);
            tambahProdukButton.Name = "tambahProdukButton";
            tambahProdukButton.Size = new Size(101, 23);
            tambahProdukButton.TabIndex = 10;
            tambahProdukButton.Text = "Tambah Produk";
            tambahProdukButton.UseVisualStyleBackColor = true;
            tambahProdukButton.Click += tambahProdukButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(355, 391);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(75, 23);
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
            HomePage.Controls.Add(produkGridView);
            HomePage.Controls.Add(welcomeLabel);
            HomePage.Controls.Add(tambahProdukButton);
            HomePage.Controls.Add(refreshButton);
            HomePage.Controls.Add(namaTextBox);
            HomePage.Controls.Add(deskripsiTextBox);
            HomePage.Controls.Add(label4);
            HomePage.Controls.Add(stokNumericUpDown);
            HomePage.Controls.Add(label3);
            HomePage.Controls.Add(HargaNumericUpDown);
            HomePage.Controls.Add(label2);
            HomePage.Controls.Add(label1);
            HomePage.Location = new Point(4, 24);
            HomePage.Name = "HomePage";
            HomePage.Padding = new Padding(3);
            HomePage.Size = new Size(670, 422);
            HomePage.TabIndex = 0;
            HomePage.Text = "Home";
            HomePage.UseVisualStyleBackColor = true;
            // 
            // PesananPage
            // 
            PesananPage.Location = new Point(4, 24);
            PesananPage.Name = "PesananPage";
            PesananPage.Padding = new Padding(3);
            PesananPage.Size = new Size(670, 422);
            PesananPage.TabIndex = 1;
            PesananPage.Text = "Pesanan";
            PesananPage.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)produkGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)stokNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)HargaNumericUpDown).EndInit();
            tabControl1.ResumeLayout(false);
            HomePage.ResumeLayout(false);
            HomePage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label welcomeLabel;
        private DataGridView produkGridView;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Deskripsi;
        private TextBox namaTextBox;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox deskripsiTextBox;
        private NumericUpDown stokNumericUpDown;
        private NumericUpDown HargaNumericUpDown;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button tambahProdukButton;
        private Button refreshButton;
        private TabControl tabControl1;
        private TabPage HomePage;
        private TabPage PesananPage;
    }
}