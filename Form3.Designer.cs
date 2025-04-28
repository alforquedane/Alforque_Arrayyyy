namespace Alforque_Arrayyyy
{
    partial class Form3
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
            this.pnl_Bg = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_LoginForm = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.pnl_Bg.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Bg
            // 
            this.pnl_Bg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Bg.Controls.Add(this.button1);
            this.pnl_Bg.Controls.Add(this.lbl_LoginForm);
            this.pnl_Bg.Controls.Add(this.btn_Login);
            this.pnl_Bg.Controls.Add(this.txt_Password);
            this.pnl_Bg.Controls.Add(this.lbl_Password);
            this.pnl_Bg.Controls.Add(this.txt_Username);
            this.pnl_Bg.Controls.Add(this.lbl_Username);
            this.pnl_Bg.Location = new System.Drawing.Point(76, 124);
            this.pnl_Bg.Name = "pnl_Bg";
            this.pnl_Bg.Size = new System.Drawing.Size(460, 300);
            this.pnl_Bg.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(111, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Signup";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_LoginForm
            // 
            this.lbl_LoginForm.AutoSize = true;
            this.lbl_LoginForm.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginForm.Location = new System.Drawing.Point(119, 43);
            this.lbl_LoginForm.Name = "lbl_LoginForm";
            this.lbl_LoginForm.Size = new System.Drawing.Size(237, 37);
            this.lbl_LoginForm.TabIndex = 12;
            this.lbl_LoginForm.Text = "LOGIN FORM";
            // 
            // btn_Login
            // 
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(239, 217);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(118, 35);
            this.btn_Login.TabIndex = 15;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(184, 166);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(198, 23);
            this.txt_Password.TabIndex = 14;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(82, 164);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(104, 25);
            this.lbl_Password.TabIndex = 13;
            this.lbl_Password.Text = "Password:";
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(184, 125);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(198, 23);
            this.txt_Username.TabIndex = 12;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(78, 123);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(108, 25);
            this.lbl_Username.TabIndex = 11;
            this.lbl_Username.Text = "Username:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(607, 575);
            this.Controls.Add(this.pnl_Bg);
            this.Name = "Form3";
            this.Text = "Login";
            this.pnl_Bg.ResumeLayout(false);
            this.pnl_Bg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Bg;
        private System.Windows.Forms.Button btn_Login;
        public System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Password;
        public System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_LoginForm;
        private System.Windows.Forms.Button button1;
    }
}