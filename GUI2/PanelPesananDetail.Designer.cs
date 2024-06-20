namespace GUI
{
    partial class PanelPesananDetail
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ubahStatus = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            namaProduk = new TextBox();
            namaPembeli = new TextBox();
            jumlahProduk = new TextBox();
            totalHarga = new TextBox();
            alamatPembeli = new TextBox();
            statusSaatIni = new TextBox();
            updateStatus = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 33);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Produk:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 149);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Total Harga:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 71);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Nama Pembeli:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 110);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 3;
            label4.Text = "Jumlah Produk:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 187);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 4;
            label5.Text = "Alamat Pembeli:";
            // 
            // ubahStatus
            // 
            ubahStatus.FormattingEnabled = true;
            ubahStatus.Items.AddRange(new object[] { "ter packing", "sampai", "diterima" });
            ubahStatus.Location = new Point(144, 266);
            ubahStatus.Name = "ubahStatus";
            ubahStatus.Size = new Size(121, 23);
            ubahStatus.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 269);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 6;
            label6.Text = "Ubah Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 227);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 7;
            label7.Text = "Status Saat Ini:";
            // 
            // namaProduk
            // 
            namaProduk.Location = new Point(144, 30);
            namaProduk.Name = "namaProduk";
            namaProduk.Size = new Size(215, 23);
            namaProduk.TabIndex = 8;
            // 
            // namaPembeli
            // 
            namaPembeli.Location = new Point(144, 71);
            namaPembeli.Name = "namaPembeli";
            namaPembeli.Size = new Size(215, 23);
            namaPembeli.TabIndex = 9;
            // 
            // jumlahProduk
            // 
            jumlahProduk.Location = new Point(144, 110);
            jumlahProduk.Name = "jumlahProduk";
            jumlahProduk.Size = new Size(215, 23);
            jumlahProduk.TabIndex = 10;
            // 
            // totalHarga
            // 
            totalHarga.Location = new Point(144, 149);
            totalHarga.Name = "totalHarga";
            totalHarga.Size = new Size(215, 23);
            totalHarga.TabIndex = 11;
            // 
            // alamatPembeli
            // 
            alamatPembeli.Location = new Point(145, 187);
            alamatPembeli.Name = "alamatPembeli";
            alamatPembeli.Size = new Size(214, 23);
            alamatPembeli.TabIndex = 12;
            // 
            // statusSaatIni
            // 
            statusSaatIni.Location = new Point(145, 227);
            statusSaatIni.Name = "statusSaatIni";
            statusSaatIni.Size = new Size(120, 23);
            statusSaatIni.TabIndex = 13;
            // 
            // updateStatus
            // 
            updateStatus.Location = new Point(145, 308);
            updateStatus.Name = "updateStatus";
            updateStatus.Size = new Size(105, 23);
            updateStatus.TabIndex = 14;
            updateStatus.Text = "Update Status";
            updateStatus.UseVisualStyleBackColor = true;
            updateStatus.Click += button1_Click;
            // 
            // PanelPesananDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 450);
            Controls.Add(updateStatus);
            Controls.Add(statusSaatIni);
            Controls.Add(alamatPembeli);
            Controls.Add(totalHarga);
            Controls.Add(jumlahProduk);
            Controls.Add(namaPembeli);
            Controls.Add(namaProduk);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(ubahStatus);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PanelPesananDetail";
            Text = "t";
            Load += PanelPesananDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox ubahStatus;
        private Label label6;
        private Label label7;
        private TextBox namaProduk;
        private TextBox namaPembeli;
        private TextBox jumlahProduk;
        private TextBox totalHarga;
        private TextBox alamatPembeli;
        private TextBox statusSaatIni;
        private Button updateStatus;
    }
}