namespace GUI
{
    partial class Register
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
            usernameTextBox = new TextBox();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            ulangiTextBox = new TextBox();
            ArNTTextBox = new TextBox();
            penjualRadioButton = new RadioButton();
            PembeliRadioButton = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnRegister = new Button();
            button2 = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTextBox.Location = new Point(188, 88);
            usernameTextBox.Margin = new Padding(4);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(276, 23);
            usernameTextBox.TabIndex = 0;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.Location = new Point(188, 128);
            emailTextBox.Margin = new Padding(4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(276, 23);
            emailTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(188, 169);
            passwordTextBox.Margin = new Padding(4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(276, 23);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // ulangiTextBox
            // 
            ulangiTextBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ulangiTextBox.Location = new Point(188, 209);
            ulangiTextBox.Margin = new Padding(4);
            ulangiTextBox.Name = "ulangiTextBox";
            ulangiTextBox.Size = new Size(276, 23);
            ulangiTextBox.TabIndex = 3;
            // 
            // ArNTTextBox
            // 
            ArNTTextBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ArNTTextBox.Location = new Point(188, 309);
            ArNTTextBox.Margin = new Padding(4);
            ArNTTextBox.Name = "ArNTTextBox";
            ArNTTextBox.Size = new Size(276, 23);
            ArNTTextBox.TabIndex = 4;
            ArNTTextBox.Visible = false;
            // 
            // penjualRadioButton
            // 
            penjualRadioButton.AutoSize = true;
            penjualRadioButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            penjualRadioButton.Location = new Point(188, 280);
            penjualRadioButton.Margin = new Padding(4);
            penjualRadioButton.Name = "penjualRadioButton";
            penjualRadioButton.Size = new Size(73, 21);
            penjualRadioButton.TabIndex = 5;
            penjualRadioButton.Text = "Penjual";
            penjualRadioButton.UseVisualStyleBackColor = true;
            penjualRadioButton.CheckedChanged += penjualRadioButton_CheckedChanged;
            // 
            // PembeliRadioButton
            // 
            PembeliRadioButton.AutoSize = true;
            PembeliRadioButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PembeliRadioButton.Location = new Point(188, 251);
            PembeliRadioButton.Margin = new Padding(4);
            PembeliRadioButton.Name = "PembeliRadioButton";
            PembeliRadioButton.Size = new Size(76, 21);
            PembeliRadioButton.TabIndex = 6;
            PembeliRadioButton.Text = "Pembeli";
            PembeliRadioButton.UseVisualStyleBackColor = true;
            PembeliRadioButton.CheckedChanged += PembeliRadioButton_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 91);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 17);
            label1.TabIndex = 7;
            label1.Text = "Nama:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 131);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 8;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 172);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 9;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(72, 212);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 10;
            label4.Text = "Ulangi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(72, 312);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(17, 17);
            label5.TabIndex = 11;
            label5.Text = "-:";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(72, 251);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(50, 17);
            label6.TabIndex = 12;
            label6.Text = "Peran:";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(219, 382);
            btnRegister.Margin = new Padding(4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(88, 26);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(174, 483);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(178, 26);
            button2.TabIndex = 14;
            button2.Text = "Sudah mempunyai akun";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(191, 8);
            label7.Name = "label7";
            label7.Size = new Size(129, 29);
            label7.TabIndex = 15;
            label7.Text = "Buat Akun";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 519);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(btnRegister);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(penjualRadioButton);
            Controls.Add(ArNTTextBox);
            Controls.Add(ulangiTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(PembeliRadioButton);
            Margin = new Padding(4);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox ulangiTextBox;
        private System.Windows.Forms.TextBox ArNTTextBox;
        private System.Windows.Forms.RadioButton penjualRadioButton;
        private System.Windows.Forms.RadioButton PembeliRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
    }
}