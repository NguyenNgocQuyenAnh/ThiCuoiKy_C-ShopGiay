namespace QLGIAY
{
    partial class frmTimHoadon
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radten = new System.Windows.Forms.RadioButton();
            this.raddtb = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 51);
            this.button2.TabIndex = 8;
            this.button2.Text = "cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(72, 207);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(91, 51);
            this.btnsearch.TabIndex = 9;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(67, 140);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(333, 26);
            this.txttim.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập thông tin cần tìm";
            // 
            // radten
            // 
            this.radten.AutoSize = true;
            this.radten.Checked = true;
            this.radten.Location = new System.Drawing.Point(72, 45);
            this.radten.Name = "radten";
            this.radten.Size = new System.Drawing.Size(173, 24);
            this.radten.TabIndex = 4;
            this.radten.TabStop = true;
            this.radten.Text = "Tra cứu theo MaHD";
            this.radten.UseVisualStyleBackColor = true;
            // 
            // raddtb
            // 
            this.raddtb.AutoSize = true;
            this.raddtb.Location = new System.Drawing.Point(292, 45);
            this.raddtb.Name = "raddtb";
            this.raddtb.Size = new System.Drawing.Size(171, 24);
            this.raddtb.TabIndex = 5;
            this.raddtb.Text = "Tra cứu theo MaKH";
            this.raddtb.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(490, 45);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(158, 24);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tra cứu theo năm";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(675, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(168, 24);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tra cứu theo tháng";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // frmTimHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 592);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radten);
            this.Controls.Add(this.raddtb);
            this.Name = "frmTimHoadon";
            this.Text = "Tìm Hóa Đơn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radten;
        private System.Windows.Forms.RadioButton raddtb;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}