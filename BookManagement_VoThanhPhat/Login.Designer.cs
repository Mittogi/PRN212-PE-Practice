namespace BookManagement_VoThanhPhat
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnQuit = new Button();
            btnLogin = new Button();
            textBox1 = new TextBox();
            txtPassword = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(178, 39);
            label1.Name = "label1";
            label1.Size = new Size(448, 81);
            label1.TabIndex = 1;
            label1.Text = "Book Manager";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnQuit);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Yellow;
            groupBox1.Location = new Point(70, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(659, 401);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " Account Info ";
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.ForeColor = Color.Black;
            btnQuit.Location = new Point(398, 253);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(181, 69);
            btnQuit.TabIndex = 3;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(157, 253);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(181, 69);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(157, 150);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(422, 43);
            textBox1.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(6, 150);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(139, 38);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(157, 52);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(422, 43);
            txtEmail.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(20, 52);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(89, 38);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 574);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label lblEmail;
        private Label txtPassword;
        private TextBox txtEmail;
        private Button btnQuit;
        private Button btnLogin;
        private TextBox textBox1;
    }
}