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
            ((System.ComponentModel.ISupportInitialize)StokNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // NamaTokoLabel
            // 
            NamaTokoLabel.AutoSize = true;
            NamaTokoLabel.Location = new Point(282, 30);
            NamaTokoLabel.Name = "NamaTokoLabel";
            NamaTokoLabel.Size = new Size(92, 15);
            NamaTokoLabel.TabIndex = 0;
            NamaTokoLabel.Text = "NamaTokoLabel";
            // 
            // NamaPenjualLabel
            // 
            NamaPenjualLabel.AutoSize = true;
            NamaPenjualLabel.Location = new Point(271, 60);
            NamaPenjualLabel.Name = "NamaPenjualLabel";
            NamaPenjualLabel.Size = new Size(106, 15);
            NamaPenjualLabel.TabIndex = 1;
            NamaPenjualLabel.Text = "NamaPenjualLabel";
            // 
            // NamaProdukLabel
            // 
            NamaProdukLabel.AutoSize = true;
            NamaProdukLabel.Location = new Point(269, 117);
            NamaProdukLabel.Name = "NamaProdukLabel";
            NamaProdukLabel.Size = new Size(105, 15);
            NamaProdukLabel.TabIndex = 2;
            NamaProdukLabel.Text = "NamaProdukLabel";
            // 
            // HargaProdukLabel
            // 
            HargaProdukLabel.AutoSize = true;
            HargaProdukLabel.Location = new Point(280, 156);
            HargaProdukLabel.Name = "HargaProdukLabel";
            HargaProdukLabel.Size = new Size(105, 15);
            HargaProdukLabel.TabIndex = 3;
            HargaProdukLabel.Text = "HargaProdukLabel";
            // 
            // StokProdukLabel
            // 
            StokProdukLabel.AutoSize = true;
            StokProdukLabel.Location = new Point(281, 199);
            StokProdukLabel.Name = "StokProdukLabel";
            StokProdukLabel.Size = new Size(96, 15);
            StokProdukLabel.TabIndex = 4;
            StokProdukLabel.Text = "StokProdukLabel";
            // 
            // DeskripsiProdukLabel
            // 
            DeskripsiProdukLabel.Location = new Point(220, 234);
            DeskripsiProdukLabel.Name = "DeskripsiProdukLabel";
            DeskripsiProdukLabel.Size = new Size(190, 75);
            DeskripsiProdukLabel.TabIndex = 5;
            DeskripsiProdukLabel.Text = "DeskripsiProdukLabel";
            // 
            // pesanProduk
            // 
            pesanProduk.Location = new Point(299, 368);
            pesanProduk.Name = "pesanProduk";
            pesanProduk.Size = new Size(75, 23);
            pesanProduk.TabIndex = 6;
            pesanProduk.Text = "Pesan";
            pesanProduk.UseVisualStyleBackColor = true;
            pesanProduk.Click += pesanProduk_Click;
            // 
            // StokNumericUpDown
            // 
            StokNumericUpDown.Location = new Point(269, 286);
            StokNumericUpDown.Name = "StokNumericUpDown";
            StokNumericUpDown.Size = new Size(120, 23);
            StokNumericUpDown.TabIndex = 7;
            StokNumericUpDown.ValueChanged += updateTotalHarga;
            // 
            // TotalHargaLabel
            // 
            TotalHargaLabel.AutoSize = true;
            TotalHargaLabel.Location = new Point(285, 335);
            TotalHargaLabel.Name = "TotalHargaLabel";
            TotalHargaLabel.Size = new Size(92, 15);
            TotalHargaLabel.TabIndex = 8;
            TotalHargaLabel.Text = "TotalHargaLabel";
            // 
            // PanelProdukDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}