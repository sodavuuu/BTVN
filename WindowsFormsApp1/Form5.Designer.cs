namespace WinFormsExercises
{
    partial class Form5
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
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.grpFont = new System.Windows.Forms.GroupBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.lblLapTrinh = new System.Windows.Forms.Label();
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpColor.SuspendLayout();
            this.grpFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpColor
            // 
            this.grpColor.Controls.Add(this.radBlack);
            this.grpColor.Controls.Add(this.radBlue);
            this.grpColor.Controls.Add(this.radGreen);
            this.grpColor.Controls.Add(this.radRed);
            this.grpColor.Location = new System.Drawing.Point(12, 12);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(120, 120);
            this.grpColor.TabIndex = 0;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color";
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Location = new System.Drawing.Point(6, 92);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(52, 17);
            this.radBlack.TabIndex = 3;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Location = new System.Drawing.Point(6, 69);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(46, 17);
            this.radBlue.TabIndex = 2;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Location = new System.Drawing.Point(6, 46);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(54, 17);
            this.radGreen.TabIndex = 1;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Location = new System.Drawing.Point(6, 23);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(45, 17);
            this.radRed.TabIndex = 0;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // grpFont
            // 
            this.grpFont.Controls.Add(this.chkUnderline);
            this.grpFont.Controls.Add(this.chkItalic);
            this.grpFont.Controls.Add(this.chkBold);
            this.grpFont.Location = new System.Drawing.Point(138, 12);
            this.grpFont.Name = "grpFont";
            this.grpFont.Size = new System.Drawing.Size(120, 120);
            this.grpFont.TabIndex = 1;
            this.grpFont.TabStop = false;
            this.grpFont.Text = "Font";
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Location = new System.Drawing.Point(6, 69);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(71, 17);
            this.chkUnderline.TabIndex = 2;
            this.chkUnderline.Text = "Underline";
            this.chkUnderline.UseVisualStyleBackColor = true;
            this.chkUnderline.CheckedChanged += new System.EventHandler(this.chkUnderline_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(6, 46);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(48, 17);
            this.chkItalic.TabIndex = 1;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(6, 23);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(47, 17);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // lblLapTrinh
            // 
            this.lblLapTrinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLapTrinh.Location = new System.Drawing.Point(12, 138);
            this.lblLapTrinh.Name = "lblLapTrinh";
            this.lblLapTrinh.Size = new System.Drawing.Size(246, 23);
            this.lblLapTrinh.TabIndex = 2;
            this.lblLapTrinh.Text = "Lập Trình";
            this.lblLapTrinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNhapTen
            // 
            this.txtNhapTen.Location = new System.Drawing.Point(12, 164);
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(246, 20);
            this.txtNhapTen.TabIndex = 3;
            this.txtNhapTen.TextChanged += new System.EventHandler(this.txtNhapTen_TextChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(183, 190);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 221);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtNhapTen);
            this.Controls.Add(this.lblLapTrinh);
            this.Controls.Add(this.grpFont);
            this.Controls.Add(this.grpColor);
            this.Name = "Form5";
            this.Text = "Định Dạng(Formatter)";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            this.grpFont.ResumeLayout(false);
            this.grpFont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.GroupBox grpFont;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.Label lblLapTrinh;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.Button btnThoat;
    }
}

