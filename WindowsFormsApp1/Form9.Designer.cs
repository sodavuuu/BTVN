namespace WinFormsExercises
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.lnkWindowsForms = new System.Windows.Forms.LinkLabel();
            this.lnkCalculator = new System.Windows.Forms.LinkLabel();
            this.lnkCDrive = new System.Windows.Forms.LinkLabel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.picTurnOn = new System.Windows.Forms.PictureBox();
            this.picTurnOff = new System.Windows.Forms.PictureBox();
            this.lblLight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTurnOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTurnOff)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkWindowsForms
            // 
            this.lnkWindowsForms.AutoSize = true;
            this.lnkWindowsForms.Location = new System.Drawing.Point(12, 15);
            this.lnkWindowsForms.Name = "lnkWindowsForms";
            this.lnkWindowsForms.Size = new System.Drawing.Size(156, 13);
            this.lnkWindowsForms.TabIndex = 0;
            this.lnkWindowsForms.TabStop = true;
            this.lnkWindowsForms.Text = "Windows Forms Community Website";
            this.lnkWindowsForms.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWindowsForms_LinkClicked);
            // 
            // lnkCalculator
            // 
            this.lnkCalculator.AutoSize = true;
            this.lnkCalculator.Location = new System.Drawing.Point(12, 40);
            this.lnkCalculator.Name = "lnkCalculator";
            this.lnkCalculator.Size = new System.Drawing.Size(97, 13);
            this.lnkCalculator.TabIndex = 1;
            this.lnkCalculator.TabStop = true;
            this.lnkCalculator.Text = "Launch Calculator";
            this.lnkCalculator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCalculator_LinkClicked);
            // 
            // lnkCDrive
            // 
            this.lnkCDrive.AutoSize = true;
            this.lnkCDrive.Location = new System.Drawing.Point(12, 65);
            this.lnkCDrive.Name = "lnkCDrive";
            this.lnkCDrive.Size = new System.Drawing.Size(45, 13);
            this.lnkCDrive.TabIndex = 2;
            this.lnkCDrive.TabStop = true;
            this.lnkCDrive.Text = "C: Drive";
            this.lnkCDrive.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCDrive_LinkClicked);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(56, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 20);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "Jack";
            // 
            // picTurnOn
            // 
            this.picTurnOn.Image = ((System.Drawing.Image)(resources.GetObject("picTurnOn.Image")));
            this.picTurnOn.Location = new System.Drawing.Point(126, 123);
            this.picTurnOn.Name = "picTurnOn";
            this.picTurnOn.Size = new System.Drawing.Size(64, 64);
            this.picTurnOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTurnOn.TabIndex = 5;
            this.picTurnOn.TabStop = false;
            this.picTurnOn.Click += new System.EventHandler(this.picTurnOn_Click);
            // 
            // picTurnOff
            // 
            this.picTurnOff.Image = ((System.Drawing.Image)(resources.GetObject("picTurnOff.Image")));
            this.picTurnOff.Location = new System.Drawing.Point(126, 123);
            this.picTurnOff.Name = "picTurnOff";
            this.picTurnOff.Size = new System.Drawing.Size(64, 64);
            this.picTurnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTurnOff.TabIndex = 6;
            this.picTurnOff.TabStop = false;
            this.picTurnOff.Visible = false;
            this.picTurnOff.Click += new System.EventHandler(this.picTurnOff_Click);
            // 
            // lblLight
            // 
            this.lblLight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLight.Location = new System.Drawing.Point(15, 200);
            this.lblLight.Name = "lblLight";
            this.lblLight.Size = new System.Drawing.Size(257, 23);
            this.lblLight.TabIndex = 7;
            this.lblLight.Text = "Jack - Turn OFF the Light, please!";
            this.lblLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 241);
            this.Controls.Add(this.lblLight);
            this.Controls.Add(this.picTurnOff);
            this.Controls.Add(this.picTurnOn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lnkCDrive);
            this.Controls.Add(this.lnkCalculator);
            this.Controls.Add(this.lnkWindowsForms);
            this.Name = "Form9";
            this.Text = "LinkLabel Demo";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTurnOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTurnOff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkWindowsForms;
        private System.Windows.Forms.LinkLabel lnkCalculator;
        private System.Windows.Forms.LinkLabel lnkCDrive;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox picTurnOn;
        private System.Windows.Forms.PictureBox picTurnOff;
        private System.Windows.Forms.Label lblLight;
    }
}

