namespace app_chat
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.lbSignIn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SignUpBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.txtAcc = new Guna.UI.WinForms.GunaTextBox();
            this.txtPass = new Guna.UI.WinForms.GunaTextBox();
            this.txtConfirmPass = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSignIn
            // 
            this.lbSignIn.AutoSize = true;
            this.lbSignIn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.lbSignIn.Location = new System.Drawing.Point(215, 520);
            this.lbSignIn.Name = "lbSignIn";
            this.lbSignIn.Size = new System.Drawing.Size(87, 18);
            this.lbSignIn.TabIndex = 24;
            this.lbSignIn.Text = "Đăng nhập";
            this.lbSignIn.Click += new System.EventHandler(this.lbSignIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(23, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Bạn đã có tài khoản ?";
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.CheckedImage")));
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Image = null;
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(332, 12);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Radius = 5;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(30, 30);
            this.gunaAdvenceButton2.TabIndex = 20;
            this.gunaAdvenceButton2.Text = "X";
            this.gunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton2.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.AnimationHoverSpeed = 0.07F;
            this.SignUpBtn.AnimationSpeed = 0.03F;
            this.SignUpBtn.BackColor = System.Drawing.Color.Transparent;
            this.SignUpBtn.BaseColor = System.Drawing.Color.White;
            this.SignUpBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.SignUpBtn.BorderSize = 2;
            this.SignUpBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.SignUpBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.SignUpBtn.CheckedForeColor = System.Drawing.Color.White;
            this.SignUpBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("SignUpBtn.CheckedImage")));
            this.SignUpBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SignUpBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SignUpBtn.FocusedColor = System.Drawing.Color.Empty;
            this.SignUpBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.SignUpBtn.Image = null;
            this.SignUpBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.SignUpBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.SignUpBtn.Location = new System.Drawing.Point(78, 417);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.SignUpBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.SignUpBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.SignUpBtn.OnHoverImage = null;
            this.SignUpBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.SignUpBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.SignUpBtn.Radius = 15;
            this.SignUpBtn.Size = new System.Drawing.Size(202, 53);
            this.SignUpBtn.TabIndex = 19;
            this.SignUpBtn.Text = "Đăng ký";
            this.SignUpBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::app_chat.Properties.Resources.fb_messenger1;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(145, 34);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(80, 80);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox1.TabIndex = 18;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // txtAcc
            // 
            this.txtAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtAcc.BaseColor = System.Drawing.Color.White;
            this.txtAcc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.txtAcc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAcc.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.txtAcc.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.txtAcc.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.txtAcc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.txtAcc.Location = new System.Drawing.Point(26, 181);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.PasswordChar = '\0';
            this.txtAcc.Radius = 10;
            this.txtAcc.SelectedText = "";
            this.txtAcc.Size = new System.Drawing.Size(312, 55);
            this.txtAcc.TabIndex = 25;
            this.txtAcc.Text = "   Tên";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.BaseColor = System.Drawing.Color.White;
            this.txtPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.txtPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.txtPass.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.txtPass.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.txtPass.Location = new System.Drawing.Point(26, 251);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.Radius = 10;
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(312, 55);
            this.txtPass.TabIndex = 26;
            this.txtPass.Text = "   Mật khẩu";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPass.BaseColor = System.Drawing.Color.White;
            this.txtConfirmPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.txtConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPass.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.txtConfirmPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.txtConfirmPass.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.txtConfirmPass.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.txtConfirmPass.Location = new System.Drawing.Point(26, 322);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '\0';
            this.txtConfirmPass.Radius = 10;
            this.txtConfirmPass.SelectedText = "";
            this.txtConfirmPass.Size = new System.Drawing.Size(312, 55);
            this.txtConfirmPass.TabIndex = 27;
            this.txtConfirmPass.Text = "  Xác nhận mật khẩu";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 601);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtAcc);
            this.Controls.Add(this.lbSignIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaAdvenceButton2);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSignIn;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private Guna.UI.WinForms.GunaAdvenceButton SignUpBtn;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaTextBox txtAcc;
        private Guna.UI.WinForms.GunaTextBox txtPass;
        private Guna.UI.WinForms.GunaTextBox txtConfirmPass;
    }
}