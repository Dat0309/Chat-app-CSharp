namespace server
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.UserLv = new System.Windows.Forms.ListView();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.ServeLv = new System.Windows.Forms.ListView();
            this.DisConBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ConBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.gunaLabel1.Location = new System.Drawing.Point(27, 26);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(46, 24);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "IP :";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.gunaLabel2.Location = new System.Drawing.Point(27, 71);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(65, 24);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Port :";
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.Location = new System.Drawing.Point(113, 63);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 10;
            this.gunaTextBox2.SelectedText = "";
            this.gunaTextBox2.Size = new System.Drawing.Size(196, 38);
            this.gunaTextBox2.TabIndex = 3;
            this.gunaTextBox2.Text = "9999";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.UserLv);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel1.Location = new System.Drawing.Point(404, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(396, 450);
            this.gunaPanel1.TabIndex = 4;
            // 
            // UserLv
            // 
            this.UserLv.HideSelection = false;
            this.UserLv.Location = new System.Drawing.Point(0, 48);
            this.UserLv.Name = "UserLv";
            this.UserLv.Size = new System.Drawing.Size(396, 402);
            this.UserLv.TabIndex = 2;
            this.UserLv.UseCompatibleStateImageBehavior = false;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.gunaLabel3.Location = new System.Drawing.Point(91, 9);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(237, 24);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Danh sách người dùng";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.gunaGroupBox1.BorderSize = 2;
            this.gunaGroupBox1.Controls.Add(this.ServeLv);
            this.gunaGroupBox1.Controls.Add(this.DisConBtn);
            this.gunaGroupBox1.Controls.Add(this.ConBtn);
            this.gunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaGroupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.gunaGroupBox1.LineTop = 2;
            this.gunaGroupBox1.Location = new System.Drawing.Point(0, 128);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 10;
            this.gunaGroupBox1.Size = new System.Drawing.Size(404, 322);
            this.gunaGroupBox1.TabIndex = 5;
            this.gunaGroupBox1.Text = "Server";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // ServeLv
            // 
            this.ServeLv.HideSelection = false;
            this.ServeLv.Location = new System.Drawing.Point(4, 41);
            this.ServeLv.Name = "ServeLv";
            this.ServeLv.Size = new System.Drawing.Size(397, 194);
            this.ServeLv.TabIndex = 9;
            this.ServeLv.UseCompatibleStateImageBehavior = false;
            this.ServeLv.SelectedIndexChanged += new System.EventHandler(this.ServeLv_SelectedIndexChanged);
            // 
            // DisConBtn
            // 
            this.DisConBtn.AnimationHoverSpeed = 0.07F;
            this.DisConBtn.AnimationSpeed = 0.03F;
            this.DisConBtn.BackColor = System.Drawing.Color.Transparent;
            this.DisConBtn.BaseColor = System.Drawing.Color.White;
            this.DisConBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.DisConBtn.BorderSize = 2;
            this.DisConBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.DisConBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.DisConBtn.CheckedForeColor = System.Drawing.Color.White;
            this.DisConBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("DisConBtn.CheckedImage")));
            this.DisConBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.DisConBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DisConBtn.FocusedColor = System.Drawing.Color.Empty;
            this.DisConBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisConBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.DisConBtn.Image = null;
            this.DisConBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.DisConBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.DisConBtn.Location = new System.Drawing.Point(214, 257);
            this.DisConBtn.Name = "DisConBtn";
            this.DisConBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.DisConBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.DisConBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.DisConBtn.OnHoverImage = null;
            this.DisConBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.DisConBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.DisConBtn.Radius = 10;
            this.DisConBtn.Size = new System.Drawing.Size(121, 53);
            this.DisConBtn.TabIndex = 8;
            this.DisConBtn.Text = "Tắt Server";
            this.DisConBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DisConBtn.Click += new System.EventHandler(this.DisConBtn_Click);
            // 
            // ConBtn
            // 
            this.ConBtn.AnimationHoverSpeed = 0.07F;
            this.ConBtn.AnimationSpeed = 0.03F;
            this.ConBtn.BackColor = System.Drawing.Color.Transparent;
            this.ConBtn.BaseColor = System.Drawing.Color.White;
            this.ConBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.ConBtn.BorderSize = 2;
            this.ConBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ConBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.ConBtn.CheckedForeColor = System.Drawing.Color.White;
            this.ConBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ConBtn.CheckedImage")));
            this.ConBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ConBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ConBtn.FocusedColor = System.Drawing.Color.Empty;
            this.ConBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.ConBtn.Image = null;
            this.ConBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.ConBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.ConBtn.Location = new System.Drawing.Point(55, 257);
            this.ConBtn.Name = "ConBtn";
            this.ConBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.ConBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.ConBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.ConBtn.OnHoverImage = null;
            this.ConBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.ConBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.ConBtn.Radius = 10;
            this.ConBtn.Size = new System.Drawing.Size(121, 53);
            this.ConBtn.TabIndex = 7;
            this.ConBtn.Text = "Bật Server";
            this.ConBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ConBtn.Click += new System.EventHandler(this.ConBtn_Click);
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.Location = new System.Drawing.Point(113, 19);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(196, 38);
            this.gunaTextBox1.TabIndex = 6;
            this.gunaTextBox1.Text = "127.0.0.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaTextBox2);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.ListView UserLv;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.ListView ServeLv;
        private Guna.UI.WinForms.GunaAdvenceButton DisConBtn;
        private Guna.UI.WinForms.GunaAdvenceButton ConBtn;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
    }
}

