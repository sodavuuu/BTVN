namespace WinFormsExercises
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMessageLabel = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.picBig = new System.Windows.Forms.PictureBox();
            this.picSmall = new System.Windows.Forms.PictureBox();
            this.grpColor.SuspendLayout();
            this.grpAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(177, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Message Formatter";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblMessageLabel
            // 
            this.lblMessageLabel.AutoSize = true;
            this.lblMessageLabel.Location = new System.Drawing.Point(13, 72);
            this.lblMessageLabel.Name = "lblMessageLabel";
            this.lblMessageLabel.Size = new System.Drawing.Size(53, 13);
            this.lblMessageLabel.TabIndex = 2;
            this.lblMessageLabel.Text = "Message:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(72, 69);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(200, 20);
            this.txtMessage.TabIndex = 4;
            // 
            // grpColor
            // 
            this.grpColor.Controls.Add(this.radBlack);
            this.grpColor.Controls.Add(this.radBlue);
            this.grpColor.Controls.Add(this.radGreen);
            this.grpColor.Controls.Add(this.radRed);
            this.grpColor.Location = new System.Drawing.Point(16, 95);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(70, 115);
            this.grpColor.TabIndex = 5;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color";
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Location = new System.Drawing.Point(6, 88);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(52, 17);
            this.radBlack.TabIndex = 3;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Location = new System.Drawing.Point(6, 65);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(46, 17);
            this.radBlue.TabIndex = 2;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Location = new System.Drawing.Point(6, 42);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(54, 17);
            this.radGreen.TabIndex = 1;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Checked = true;
            this.radRed.Location = new System.Drawing.Point(6, 19);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(45, 17);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Location = new System.Drawing.Point(92, 95);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(102, 17);
            this.chkVisible.TabIndex = 6;
            this.chkVisible.Text = "Message Visible";
            this.chkVisible.UseVisualStyleBackColor = true;
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.btnExit);
            this.grpAction.Controls.Add(this.btnClear);
            this.grpAction.Controls.Add(this.btnDisplay);
            this.grpAction.Location = new System.Drawing.Point(92, 118);
            this.grpAction.Name = "grpAction";
            this.grpAction.Size = new System.Drawing.Size(180, 92);
            this.grpAction.TabIndex = 7;
            this.grpAction.TabStop = false;
            this.grpAction.Text = "Action";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(6, 63);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 40);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(168, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(6, 17);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(168, 23);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Location = new System.Drawing.Point(16, 213);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(256, 23);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Visible = false;
            // 
            // picBig
            // 
            this.picBig.Image = ((System.Drawing.Image)(resources.GetObject("picBig.Image")));
            this.picBig.Location = new System.Drawing.Point(278, 43);
            this.picBig.Name = "picBig";
            this.picBig.Size = new System.Drawing.Size(100, 100);
            this.picBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBig.TabIndex = 9;
            this.picBig.TabStop = false;
            this.picBig.Click += new System.EventHandler(this.picBig_Click);
            // 
            // picSmall
            // 
            this.picSmall.Image = ((System.Drawing.Image)(resources.GetObject("picSmall.Image")));
            this.picSmall.Location = new System.Drawing.Point(278, 149);
            this.picSmall.Name = "picSmall";
            this.picSmall.Size = new System.Drawing.Size(100, 100);
            this.picSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSmall.TabIndex = 10;
            this.picSmall.TabStop = false;
            this.picSmall.Click += new System.EventHandler(this.picSmall_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 261);
            this.Controls.Add(this.picSmall);
            this.Controls.Add(this.picBig);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.grpAction);
            this.Controls.Add(this.chkVisible);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMessageLabel);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form6";
            this.Text = "Message Formatter";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            this.grpAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMessageLabel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.CheckBox chkVisible;
        private System.Windows.Forms.GroupBox grpAction;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox picBig;
        private System.Windows.Forms.PictureBox picSmall;
    }
}

