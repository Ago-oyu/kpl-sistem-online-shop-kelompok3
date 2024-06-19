namespace GUI
{
    partial class Login
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
            passwordTextBox = new TextBox();
            button1 = new Button();
            btnToRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pembeliRadioButton = new RadioButton();
            penjualRadioButton = new RadioButton();
            label5 = new Label();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTextBox.Location = new Point(165, 90);
            usernameTextBox.Margin = new Padding(4);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(296, 23);
            usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(165, 148);
            passwordTextBox.Margin = new Padding(4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(296, 23);
            passwordTextBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(341, 254);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(120, 26);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnToRegister
            // 
            btnToRegister.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnToRegister.Location = new Point(165, 254);
            btnToRegister.Margin = new Padding(4);
            btnToRegister.Name = "btnToRegister";
            btnToRegister.Size = new Size(127, 26);
            btnToRegister.TabIndex = 3;
            btnToRegister.Text = "Create account";
            btnToRegister.UseVisualStyleBackColor = true;
            btnToRegister.Click += btnToRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 7);
            label1.Name = "label1";
            label1.Size = new Size(78, 29);
            label1.TabIndex = 4;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 93);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 151);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // pembeliRadioButton
            // 
            pembeliRadioButton.AutoSize = true;
            pembeliRadioButton.Location = new Point(165, 204);
            pembeliRadioButton.Name = "pembeliRadioButton";
            pembeliRadioButton.Size = new Size(68, 19);
            pembeliRadioButton.TabIndex = 7;
            pembeliRadioButton.TabStop = true;
            pembeliRadioButton.Text = "Pembeli";
            pembeliRadioButton.UseVisualStyleBackColor = true;
            // 
            // penjualRadioButton
            // 
            penjualRadioButton.AutoSize = true;
            penjualRadioButton.Location = new Point(252, 202);
            penjualRadioButton.Name = "penjualRadioButton";
            penjualRadioButton.Size = new Size(64, 19);
            penjualRadioButton.TabIndex = 8;
            penjualRadioButton.TabStop = true;
            penjualRadioButton.Text = "Penjual";
            penjualRadioButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(56, 204);
            label5.Name = "label5";
            label5.Size = new Size(60, 17);
            label5.TabIndex = 10;
            label5.Text = "Sebagai";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 424);
            Controls.Add(label5);
            Controls.Add(penjualRadioButton);
            Controls.Add(pembeliRadioButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnToRegister);
            Controls.Add(button1);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Close;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnToRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RadioButton pembeliRadioButton;
        private RadioButton penjualRadioButton;
        private Label label5;
    }
}

