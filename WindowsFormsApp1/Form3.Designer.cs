namespace WinFormsExercises
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
            this.lblHo = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnHoTen = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Location = new System.Drawing.Point(12, 15);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(24, 13);
            this.lblHo.TabIndex = 0;
            this.lblHo.Text = "Họ:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(12, 41);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(29, 13);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Tên:";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(47, 12);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(225, 20);
            this.txtHo.TabIndex = 2;
            this.txtHo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHo_KeyDown);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(47, 38);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(225, 20);
            this.txtTen.TabIndex = 3;
            this.txtTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTen_KeyDown);
            // 
            // btnHoTen
            // 
            this.btnHoTen.Location = new System.Drawing.Point(47, 64);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(75, 23);
            this.btnHoTen.TabIndex = 4;
            this.btnHoTen.Text = "Họ && Tên";
            this.btnHoTen.UseVisualStyleBackColor = true;
            this.btnHoTen.Click += new System.EventHandler(this.btnHoTen_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(128, 64);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(209, 64);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát Chương Trình";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHoTen.Location = new System.Drawing.Point(47, 100);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(225, 23);
            this.lblHoTen.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHoTen);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblHo);
            this.Name = "Form3";
            this.Text = "Bài Tập Họ Tên";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnHoTen;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblHoTen;
    }
}

