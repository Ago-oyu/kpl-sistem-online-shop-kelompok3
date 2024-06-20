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
            label1.Location = new Point(235, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 21);
            label1.TabIndex = 0;
            label1.Text = "Tambah Produk";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 52);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama Produk";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 95);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Harga";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 136);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Deskripsi";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 218);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 4;
            label5.Text = "Stok";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // namaProdukTextBox
            // 
            namaProdukTextBox.Location = new Point(180, 50);
            namaProdukTextBox.Margin = new Padding(3, 2, 3, 2);
            namaProdukTextBox.Name = "namaProdukTextBox";
            namaProdukTextBox.Size = new Size(358, 23);
            namaProdukTextBox.TabIndex = 5;
            // 
            // hargaNumericUpDown
            // 
            hargaNumericUpDown.Increment = new decimal(new int[] { 2000, 0, 0, 0 });
            hargaNumericUpDown.Location = new Point(180, 93);
            hargaNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            hargaNumericUpDown.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            hargaNumericUpDown.Name = "hargaNumericUpDown";
            hargaNumericUpDown.Size = new Size(145, 23);
            hargaNumericUpDown.TabIndex = 6;
            hargaNumericUpDown.TextAlign = HorizontalAlignment.Right;
            // 
            // deskripsiTextBox
            // 
            deskripsiTextBox.Location = new Point(180, 136);
            deskripsiTextBox.Margin = new Padding(3, 2, 3, 2);
            deskripsiTextBox.Multiline = true;
            deskripsiTextBox.Name = "deskripsiTextBox";
            deskripsiTextBox.Size = new Size(358, 59);
            deskripsiTextBox.TabIndex = 7;
            // 
            // stokNumericUpDown
            // 
            stokNumericUpDown.Location = new Point(180, 216);
            stokNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            stokNumericUpDown.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            stokNumericUpDown.Name = "stokNumericUpDown";
            stokNumericUpDown.Size = new Size(131, 23);
            stokNumericUpDown.TabIndex = 8;
            stokNumericUpDown.TextAlign = HorizontalAlignment.Right;
            // 
            // tambahBtn
            // 
            tambahBtn.Location = new Point(256, 290);
            tambahBtn.Margin = new Padding(3, 2, 3, 2);
            tambahBtn.Name = "tambahBtn";
            tambahBtn.Size = new Size(82, 22);
            tambahBtn.TabIndex = 9;
            tambahBtn.Text = "Tambah";
            tambahBtn.UseVisualStyleBackColor = true;
            tambahBtn.Click += tambahBtn_Click;
            // 
            // PanelTambahProduk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 338);
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
            Margin = new Padding(3, 2, 3, 2);
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