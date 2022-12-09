namespace QLGIAY
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtun = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCloser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(220, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(246, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu :";
            // 
            // txtun
            // 
            this.txtun.Location = new System.Drawing.Point(396, 168);
            this.txtun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(533, 30);
            this.txtun.TabIndex = 2;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(396, 256);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(533, 30);
            this.txtpass.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogin.Location = new System.Drawing.Point(414, 341);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(137, 45);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnCloser
            // 
            this.btnCloser.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCloser.Location = new System.Drawing.Point(769, 357);
            this.btnCloser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCloser.Name = "btnCloser";
            this.btnCloser.Size = new System.Drawing.Size(137, 45);
            this.btnCloser.TabIndex = 3;
            this.btnCloser.Text = "Thoát";
            this.btnCloser.UseVisualStyleBackColor = true;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1339, 699);
            this.Controls.Add(this.btnCloser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmDangNhap";
            this.Text = "Trang đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtun;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCloser;
    }
}