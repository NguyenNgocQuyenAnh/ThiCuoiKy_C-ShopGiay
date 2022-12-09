namespace QLGIAY
{
    partial class frmTimGiay
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
            this.radsize = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.magiay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengiay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 51);
            this.button2.TabIndex = 8;
            this.button2.Text = "cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(287, 159);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(91, 51);
            this.btnsearch.TabIndex = 9;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(282, 92);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(333, 26);
            this.txttim.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập thông tin cần tìm";
            // 
            // radten
            // 
            this.radten.AutoSize = true;
            this.radten.Checked = true;
            this.radten.Location = new System.Drawing.Point(55, 51);
            this.radten.Name = "radten";
            this.radten.Size = new System.Drawing.Size(150, 24);
            this.radten.TabIndex = 4;
            this.radten.TabStop = true;
            this.radten.Text = "Tra cứu theo tên";
            this.radten.UseVisualStyleBackColor = true;
            // 
            // radsize
            // 
            this.radsize.AutoSize = true;
            this.radsize.Location = new System.Drawing.Point(55, 98);
            this.radsize.Name = "radsize";
            this.radsize.Size = new System.Drawing.Size(158, 24);
            this.radsize.TabIndex = 5;
            this.radsize.Text = "Tra cứu theo Size";
            this.radsize.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.magiay,
            this.tengiay,
            this.size,
            this.soluong});
            this.dataGridView1.Location = new System.Drawing.Point(62, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(794, 334);
            this.dataGridView1.TabIndex = 10;
            // 
            // magiay
            // 
            this.magiay.HeaderText = "Mã Giày";
            this.magiay.Name = "magiay";
            this.magiay.Width = 200;
            // 
            // tengiay
            // 
            this.tengiay.HeaderText = "Tên Giày";
            this.tengiay.Name = "tengiay";
            this.tengiay.Width = 200;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.Name = "soluong";
            // 
            // frmTimGiay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 596);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radten);
            this.Controls.Add(this.radsize);
            this.Name = "frmTimGiay";
            this.Text = "Tìm Giày";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radten;
        private System.Windows.Forms.RadioButton radsize;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn magiay;
        private System.Windows.Forms.DataGridViewTextBoxColumn tengiay;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
    }
}