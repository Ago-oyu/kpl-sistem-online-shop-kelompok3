namespace GUI
{
    partial class PanelProdukDetail
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
            NamaTokoLabel = new Label();
            NamaPenjualLabel = new Label();
            NamaProdukLabel = new Label();
            HargaProdukLabel = new Label();
            StokProdukLabel = new Label();
            DeskripsiProdukLabel = new Label();
            pesanProduk = new Button();
            StokNumericUpDown = new NumericUpDown();
            TotalHargaLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)StokNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // NamaTokoLabel
            // 
            NamaTokoLabel.AutoSize = true;
            NamaTokoLabel.Location = new Point(17, 18);
            NamaTokoLabel.Name = "NamaTokoLabel";
            NamaTokoLabel.Size = new Size(92, 15);
            NamaTokoLabel.TabIndex = 0;
            NamaTokoLabel.Text = "NamaTokoLabel";
            // 
            // NamaPenjualLabel
            // 
            NamaPenjualLabel.AutoSize = true;
            NamaPenjualLabel.Location = new Point(44, 42);
            NamaPenjualLabel.Name = "NamaPenjualLabel";
            NamaPenjualLabel.Size = new Size(106, 15);
            NamaPenjualLabel.TabIndex = 1;
            NamaPenjualLabel.Text = "NamaPenjualLabel";
            // 
            // NamaProdukLabel
            // 
            NamaProdukLabel.AutoSize = true;
            NamaProdukLabel.Location = new Point(75, 86);
            NamaProdukLabel.Name = "NamaProdukLabel";
            NamaProdukLabel.Size = new Size(105, 15);
            NamaProdukLabel.TabIndex = 2;
            NamaProdukLabel.Text = "NamaProdukLabel";
            // 
            // HargaProdukLabel
            // 
            HargaProdukLabel.AutoSize = true;
            HargaProdukLabel.Location = new Point(75, 110);
            HargaProdukLabel.Name = "HargaProdukLabel";
            HargaProdukLabel.Size = new Size(105, 15);
            HargaProdukLabel.TabIndex = 3;
            HargaProdukLabel.Text = "HargaProdukLabel";
            // 
            // StokProdukLabel
            // 
            StokProdukLabel.AutoSize = true;
            StokProdukLabel.Location = new Point(75, 138);
            StokProdukLabel.Name = "StokProdukLabel";
            StokProdukLabel.Size = new Size(96, 15);
            StokProdukLabel.TabIndex = 4;
            StokProdukLabel.Text = "StokProdukLabel";
            // 
            // DeskripsiProdukLabel
            // 
            DeskripsiProdukLabel.Location = new Point(75, 166);
            DeskripsiProdukLabel.Name = "DeskripsiProdukLabel";
            DeskripsiProdukLabel.Size = new Size(133, 75);
            DeskripsiProdukLabel.TabIndex = 5;
            DeskripsiProdukLabel.Text = "DeskripsiProdukLabel";
            // 
            // pesanProduk
            // 
            pesanProduk.Location = new Point(48, 317);
            pesanProduk.Name = "pesanProduk";
            pesanProduk.Size = new Size(75, 23);
            pesanProduk.TabIndex = 6;
            pesanProduk.Text = "Pesan";
            pesanProduk.UseVisualStyleBackColor = true;
            pesanProduk.Click += pesanProduk_Click;
            // 
            // StokNumericUpDown
            // 
            StokNumericUpDown.Location = new Point(88, 246);
            StokNumericUpDown.Name = "StokNumericUpDown";
            StokNumericUpDown.Size = new Size(92, 23);
            StokNumericUpDown.TabIndex = 7;
            StokNumericUpDown.ValueChanged += updateTotalHarga;
            // 
            // TotalHargaLabel
            // 
            TotalHargaLabel.AutoSize = true;
            TotalHargaLabel.Location = new Point(88, 279);
            TotalHargaLabel.Name = "TotalHargaLabel";
            TotalHargaLabel.Size = new Size(92, 15);
            TotalHargaLabel.TabIndex = 8;
            TotalHargaLabel.Text = "TotalHargaLabel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 279);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 9;
            label1.Text = "Total Harga:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 166);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 10;
            label2.Text = "Deskripsi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 138);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 11;
            label3.Text = "Stok:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 110);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 12;
            label4.Text = "Harga:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 86);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 13;
            label5.Text = "Nama:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 254);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 14;
            label6.Text = "Jumlah:";
            // 
            // PanelProdukDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 357);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TotalHargaLabel);
            Controls.Add(StokNumericUpDown);
            Controls.Add(pesanProduk);
            Controls.Add(DeskripsiProdukLabel);
            Controls.Add(StokProdukLabel);
            Controls.Add(HargaProdukLabel);
            Controls.Add(NamaProdukLabel);
            Controls.Add(NamaPenjualLabel);
            Controls.Add(NamaTokoLabel);
            Name = "PanelProdukDetail";
            Text = "PanelProdukDetail";
            ((System.ComponentModel.ISupportInitialize)StokNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NamaTokoLabel;
        private Label NamaPenjualLabel;
        private Label NamaProdukLabel;
        private Label HargaProdukLabel;
        private Label StokProdukLabel;
        private Label DeskripsiProdukLabel;
        private Button pesanProduk;
        private NumericUpDown StokNumericUpDown;
        private Label TotalHargaLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}