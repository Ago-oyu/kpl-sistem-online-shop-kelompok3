namespace GUI
{
    partial class PanelEditProduk
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
            updateProdukButton = new Button();
            namaTextBox = new TextBox();
            deskripsiTextBox = new TextBox();
            label4 = new Label();
            stokNumericUpDown = new NumericUpDown();
            label3 = new Label();
            HargaNumericUpDown = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            batalButton = new Button();
            ((System.ComponentModel.ISupportInitialize)stokNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HargaNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // updateProdukButton
            // 
            updateProdukButton.Location = new Point(88, 202);
            updateProdukButton.Name = "updateProdukButton";
            updateProdukButton.Size = new Size(101, 23);
            updateProdukButton.TabIndex = 19;
            updateProdukButton.Text = "Update Produk";
            updateProdukButton.UseVisualStyleBackColor = true;
            updateProdukButton.Click += updateProdukButton_Click;
            // 
            // namaTextBox
            // 
            namaTextBox.Location = new Point(89, 23);
            namaTextBox.Name = "namaTextBox";
            namaTextBox.Size = new Size(100, 23);
            namaTextBox.TabIndex = 11;
            // 
            // deskripsiTextBox
            // 
            deskripsiTextBox.Location = new Point(89, 88);
            deskripsiTextBox.Multiline = true;
            deskripsiTextBox.Name = "deskripsiTextBox";
            deskripsiTextBox.Size = new Size(181, 53);
            deskripsiTextBox.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 147);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 18;
            label4.Text = "Stok:";
            // 
            // stokNumericUpDown
            // 
            stokNumericUpDown.Location = new Point(89, 147);
            stokNumericUpDown.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            stokNumericUpDown.Name = "stokNumericUpDown";
            stokNumericUpDown.Size = new Size(120, 23);
            stokNumericUpDown.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 88);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 17;
            label3.Text = "Deskripsi:";
            // 
            // HargaNumericUpDown
            // 
            HargaNumericUpDown.Increment = new decimal(new int[] { 2000, 0, 0, 0 });
            HargaNumericUpDown.Location = new Point(89, 52);
            HargaNumericUpDown.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            HargaNumericUpDown.Name = "HargaNumericUpDown";
            HargaNumericUpDown.Size = new Size(120, 23);
            HargaNumericUpDown.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 52);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 16;
            label2.Text = "Harga:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 23);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 15;
            label1.Text = "Nama:";
            // 
            // batalButton
            // 
            batalButton.Location = new Point(88, 245);
            batalButton.Name = "batalButton";
            batalButton.Size = new Size(101, 23);
            batalButton.TabIndex = 20;
            batalButton.Text = "Batal";
            batalButton.UseVisualStyleBackColor = true;
            batalButton.Click += batalButton_Click;
            // 
            // PanelEditProduk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 314);
            Controls.Add(batalButton);
            Controls.Add(updateProdukButton);
            Controls.Add(namaTextBox);
            Controls.Add(deskripsiTextBox);
            Controls.Add(label4);
            Controls.Add(stokNumericUpDown);
            Controls.Add(label3);
            Controls.Add(HargaNumericUpDown);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PanelEditProduk";
            Text = "PanelEditProduk";
            ((System.ComponentModel.ISupportInitialize)stokNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)HargaNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateProdukButton;
        private TextBox namaTextBox;
        private TextBox deskripsiTextBox;
        private Label label4;
        private NumericUpDown stokNumericUpDown;
        private Label label3;
        private NumericUpDown HargaNumericUpDown;
        private Label label2;
        private Label label1;
        private Button batalButton;
    }
}