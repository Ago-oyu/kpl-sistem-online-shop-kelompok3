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
            produkGridView = new DataGridView();
            welcomeLabel = new Label();
            refreshButton = new Button();
            ID = new DataGridViewTextBoxColumn();
            penjualId = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            Deskripsi = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)produkGridView).BeginInit();
            SuspendLayout();
            // 
            // produkGridView
            // 
            produkGridView.AllowUserToAddRows = false;
            produkGridView.AllowUserToDeleteRows = false;
            produkGridView.AllowUserToResizeColumns = false;
            produkGridView.AllowUserToResizeRows = false;
            produkGridView.BackgroundColor = Color.White;
            produkGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            produkGridView.Columns.AddRange(new DataGridViewColumn[] { ID, penjualId, Nama, Harga, Deskripsi });
            produkGridView.Location = new Point(99, 234);
            produkGridView.MultiSelect = false;
            produkGridView.Name = "produkGridView";
            produkGridView.ReadOnly = true;
            produkGridView.RowHeadersVisible = false;
            produkGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            produkGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            produkGridView.Size = new Size(332, 111);
            produkGridView.TabIndex = 3;
            produkGridView.CellDoubleClick += selectProduk;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(99, 59);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(92, 15);
            welcomeLabel.TabIndex = 4;
            welcomeLabel.Text = "Selamat datang ";
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(446, 322);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(75, 23);
            refreshButton.TabIndex = 12;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // penjualId
            // 
            penjualId.HeaderText = "PenjualId";
            penjualId.Name = "penjualId";
            penjualId.ReadOnly = true;
            penjualId.Visible = false;
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
            // PanelPembeli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(refreshButton);
            Controls.Add(welcomeLabel);
            Controls.Add(produkGridView);
            Name = "PanelPembeli";
            Text = "PanelPembeli";
            ((System.ComponentModel.ISupportInitialize)produkGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView produkGridView;
        private Label welcomeLabel;
        private Button refreshButton;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn penjualId;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Deskripsi;
    }
}