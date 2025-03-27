namespace WinFormsExercises
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.radVNDtoUSD = new System.Windows.Forms.RadioButton();
            this.radUSDtoVND = new System.Windows.Forms.RadioButton();
            this.radVNDtoEUR = new System.Windows.Forms.RadioButton();
            this.radEURtoVND = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Orange;
            this.lblTitle.Location = new System.Drawing.Point(120, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(95, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐỔI TIỀN";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(12, 50);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Tiền gốc:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 130);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(47, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Kết quả:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(65, 47);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(257, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(65, 127);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(257, 20);
            this.txtResult.TabIndex = 8;
            // 
            // radVNDtoUSD
            // 
            this.radVNDtoUSD.AutoSize = true;
            this.radVNDtoUSD.Location = new System.Drawing.Point(65, 73);
            this.radVNDtoUSD.Name = "radVNDtoUSD";
            this.radVNDtoUSD.Size = new System.Drawing.Size(76, 17);
            this.radVNDtoUSD.TabIndex = 4;
            this.radVNDtoUSD.TabStop = true;
            this.radVNDtoUSD.Text = "VND->USD";
            this.radVNDtoUSD.UseVisualStyleBackColor = true;
            // 
            // radUSDtoVND
            // 
            this.radUSDtoVND.AutoSize = true;
            this.radUSDtoVND.Location = new System.Drawing.Point(147, 73);
            this.radUSDtoVND.Name = "radUSDtoVND";
            this.radUSDtoVND.Size = new System.Drawing.Size(76, 17);
            this.radUSDtoVND.TabIndex = 5;
            this.radUSDtoVND.TabStop = true;
            this.radUSDtoVND.Text = "USD->VND";
            this.radUSDtoVND.UseVisualStyleBackColor = true;
            // 
            // radVNDtoEUR
            // 
            this.radVNDtoEUR.AutoSize = true;
            this.radVNDtoEUR.Location = new System.Drawing.Point(65, 96);
            this.radVNDtoEUR.Name = "radVNDtoEUR";
            this.radVNDtoEUR.Size = new System.Drawing.Size(76, 17);
            this.radVNDtoEUR.TabIndex = 6;
            this.radVNDtoEUR.TabStop = true;
            this.radVNDtoEUR.Text = "VND->EUR";
            this.radVNDtoEUR.UseVisualStyleBackColor = true;
            // 
            // radEURtoVND
            // 
            this.radEURtoVND.AutoSize = true;
            this.radEURtoVND.Location = new System.Drawing.Point(147, 96);
            this.radEURtoVND.Name = "radEURtoVND";
            this.radEURtoVND.Size = new System.Drawing.Size(76, 17);
            this.radEURtoVND.TabIndex = 7;
            this.radEURtoVND.TabStop = true;
            this.radEURtoVND.Text = "EUR->VND";
            this.radEURtoVND.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(65, 153);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 9;
            this.btnConvert.Text = "Đổi";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(146, 153);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(227, 153);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 191);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.radEURtoVND);
            this.Controls.Add(this.radVNDtoEUR);
            this.Controls.Add(this.radUSDtoVND);
            this.Controls.Add(this.radVNDtoUSD);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form4";
            this.Text = "Chuyển đổi tiền tệ";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton radVNDtoUSD;
        private System.Windows.Forms.RadioButton radUSDtoVND;
        private System.Windows.Forms.RadioButton radVNDtoEUR;
        private System.Windows.Forms.RadioButton radEURtoVND;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

