namespace PreganancyApp
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImeKor = new System.Windows.Forms.TextBox();
            this.txtRegPass = new System.Windows.Forms.TextBox();
            this.txtRegPass2 = new System.Windows.Forms.TextBox();
            this.btnRegSubmit = new System.Windows.Forms.Button();
            this.lblTerminPoroda = new System.Windows.Forms.Label();
            this.dtpTerminPoroda = new System.Windows.Forms.DateTimePicker();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(92, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Unesite podatke za registraciju";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmail.Location = new System.Drawing.Point(76, 195);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(109, 20);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Unesite email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(76, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Unesite lozinku:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(76, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ponovite lozinku:";
            // 
            // txtImeKor
            // 
            this.txtImeKor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtImeKor.Location = new System.Drawing.Point(251, 150);
            this.txtImeKor.Margin = new System.Windows.Forms.Padding(2);
            this.txtImeKor.Name = "txtImeKor";
            this.txtImeKor.Size = new System.Drawing.Size(173, 26);
            this.txtImeKor.TabIndex = 0;
            // 
            // txtRegPass
            // 
            this.txtRegPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRegPass.Location = new System.Drawing.Point(251, 236);
            this.txtRegPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegPass.Name = "txtRegPass";
            this.txtRegPass.Size = new System.Drawing.Size(173, 26);
            this.txtRegPass.TabIndex = 2;
            // 
            // txtRegPass2
            // 
            this.txtRegPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRegPass2.Location = new System.Drawing.Point(251, 279);
            this.txtRegPass2.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegPass2.Name = "txtRegPass2";
            this.txtRegPass2.Size = new System.Drawing.Size(173, 26);
            this.txtRegPass2.TabIndex = 3;
            // 
            // btnRegSubmit
            // 
            this.btnRegSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnRegSubmit.Location = new System.Drawing.Point(156, 397);
            this.btnRegSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegSubmit.Name = "btnRegSubmit";
            this.btnRegSubmit.Size = new System.Drawing.Size(174, 47);
            this.btnRegSubmit.TabIndex = 5;
            this.btnRegSubmit.Text = "Potvrdi";
            this.btnRegSubmit.UseVisualStyleBackColor = true;
            this.btnRegSubmit.Click += new System.EventHandler(this.btnRegSubmit_Click);
            // 
            // lblTerminPoroda
            // 
            this.lblTerminPoroda.AutoSize = true;
            this.lblTerminPoroda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTerminPoroda.Location = new System.Drawing.Point(76, 324);
            this.lblTerminPoroda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTerminPoroda.Name = "lblTerminPoroda";
            this.lblTerminPoroda.Size = new System.Drawing.Size(115, 20);
            this.lblTerminPoroda.TabIndex = 10;
            this.lblTerminPoroda.Text = "Termin poroda:";
            // 
            // dtpTerminPoroda
            // 
            this.dtpTerminPoroda.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpTerminPoroda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpTerminPoroda.Location = new System.Drawing.Point(251, 323);
            this.dtpTerminPoroda.Name = "dtpTerminPoroda";
            this.dtpTerminPoroda.Size = new System.Drawing.Size(173, 26);
            this.dtpTerminPoroda.TabIndex = 4;
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRegEmail.Location = new System.Drawing.Point(251, 195);
            this.txtRegEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(173, 26);
            this.txtRegEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(76, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Unesite vaše ime:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 500);
            this.Controls.Add(this.txtRegEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTerminPoroda);
            this.Controls.Add(this.lblTerminPoroda);
            this.Controls.Add(this.btnRegSubmit);
            this.Controls.Add(this.txtRegPass2);
            this.Controls.Add(this.txtRegPass);
            this.Controls.Add(this.txtImeKor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegisterForm";
            this.Text = "Registracija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImeKor;
        private System.Windows.Forms.TextBox txtRegPass;
        private System.Windows.Forms.TextBox txtRegPass2;
        private System.Windows.Forms.Button btnRegSubmit;
        private System.Windows.Forms.Label lblTerminPoroda;
        private System.Windows.Forms.DateTimePicker dtpTerminPoroda;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.Label label2;
    }
}