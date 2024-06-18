namespace GUI
{
    partial class PanelTambahProduk
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
            namaProdukTextBox = new TextBox();
            hargaNumericUpDown = new NumericUpDown();
            deskripsiTextBox = new TextBox();
            stokNumericUpDown = new NumericUpDown();
            tambahBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)hargaNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stokNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(301, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 0;
            label1.Text = "Tambah Produk";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 67);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 1;
            label2.Text = "Nama Produk";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 124);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Harga";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 178);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Deskripsi";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(167, 288);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 4;
            label5.Text = "Stok";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // namaProdukTextBox
            // 
            namaProdukTextBox.Location = new Point(238, 64);
            namaProdukTextBox.Name = "namaProdukTextBox";
            namaProdukTextBox.Size = new Size(408, 27);
            namaProdukTextBox.TabIndex = 5;
            // 
            // hargaNumericUpDown
            // 
            hargaNumericUpDown.Location = new Point(238, 121);
            hargaNumericUpDown.Name = "hargaNumericUpDown";
            hargaNumericUpDown.Size = new Size(166, 27);
            hargaNumericUpDown.TabIndex = 6;
            hargaNumericUpDown.TextAlign = HorizontalAlignment.Right;
            // 
            // deskripsiTextBox
            // 
            deskripsiTextBox.Location = new Point(238, 178);
            deskripsiTextBox.Multiline = true;
            deskripsiTextBox.Name = "deskripsiTextBox";
            deskripsiTextBox.Size = new Size(408, 77);
            deskripsiTextBox.TabIndex = 7;
            // 
            // stokNumericUpDown
            // 
            stokNumericUpDown.Location = new Point(238, 285);
            stokNumericUpDown.Name = "stokNumericUpDown";
            stokNumericUpDown.Size = new Size(150, 27);
            stokNumericUpDown.TabIndex = 8;
            // 
            // tambahBtn
            // 
            tambahBtn.Location = new Point(345, 383);
            tambahBtn.Name = "tambahBtn";
            tambahBtn.Size = new Size(94, 29);
            tambahBtn.TabIndex = 9;
            tambahBtn.Text = "Tambah";
            tambahBtn.UseVisualStyleBackColor = true;
            tambahBtn.Click += tambahBtn_Click;
            // 
            // PanelTambahProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tambahBtn);
            Controls.Add(stokNumericUpDown);
            Controls.Add(deskripsiTextBox);
            Controls.Add(hargaNumericUpDown);
            Controls.Add(namaProdukTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PanelTambahProduk";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)hargaNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)stokNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox namaProdukTextBox;
        private NumericUpDown hargaNumericUpDown;
        private TextBox deskripsiTextBox;
        private NumericUpDown stokNumericUpDown;
        private Button tambahBtn;
    }
}