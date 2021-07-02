namespace PreganancyApp
{
    partial class LoginForm
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNewUser = new System.Windows.Forms.Label();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.txtLoginPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblLogin.Location = new System.Drawing.Point(120, 55);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(111, 24);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Prijavite se";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(41, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(41, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lozinka:";
            // 
            // lblNewUser
            // 
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline);
            this.lblNewUser.Location = new System.Drawing.Point(55, 323);
            this.lblNewUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(243, 24);
            this.lblNewUser.TabIndex = 3;
            this.lblNewUser.Text = "Novi korisnik? Registriraj se!";
            this.lblNewUser.Click += new System.EventHandler(this.lblNewUser_Click);
            // 
            // txtLoginName
            // 
            this.txtLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLoginName.Location = new System.Drawing.Point(159, 111);
            this.txtLoginName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(140, 26);
            this.txtLoginName.TabIndex = 4;
            // 
            // txtLoginPass
            // 
            this.txtLoginPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLoginPass.Location = new System.Drawing.Point(159, 160);
            this.txtLoginPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.PasswordChar = '*';
            this.txtLoginPass.Size = new System.Drawing.Size(140, 26);
            this.txtLoginPass.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLogin.Location = new System.Drawing.Point(124, 225);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 58);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Prijava";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 393);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLoginPass);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.lblNewUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNewUser;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.TextBox txtLoginPass;
        private System.Windows.Forms.Button btnLogin;
    }
}

