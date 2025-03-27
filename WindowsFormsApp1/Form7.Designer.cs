namespace WinFormsExercises
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.picLight = new System.Windows.Forms.PictureBox();
            this.btnLight = new System.Windows.Forms.Button();
            this.lblDesignedBy = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(56, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Jack";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // picLight
            // 
            this.picLight.Image = ((System.Drawing.Image)(resources.GetObject("picLight.Image")));
            this.picLight.Location = new System.Drawing.Point(126, 38);
            this.picLight.Name = "picLight";
            this.picLight.Size = new System.Drawing.Size(64, 64);
            this.picLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLight.TabIndex = 2;
            this.picLight.TabStop = false;
            // 
            // btnLight
            // 
            this.btnLight.Location = new System.Drawing.Point(15, 108);
            this.btnLight.Name = "btnLight";
            this.btnLight.Size = new System.Drawing.Size(257, 23);
            this.btnLight.TabIndex = 3;
            this.btnLight.Text = "Jack - Turn OFF the Light, please!";
            this.btnLight.UseVisualStyleBackColor = true;
            this.btnLight.Click += new System.EventHandler(this.btnLight_Click);
            // 
            // lblDesignedBy
            // 
            this.lblDesignedBy.AutoSize = true;
            this.lblDesignedBy.Location = new System.Drawing.Point(12, 143);
            this.lblDesignedBy.Name = "lblDesignedBy";
            this.lblDesignedBy.Size = new System.Drawing.Size(70, 13);
            this.lblDesignedBy.TabIndex = 4;
            this.lblDesignedBy.Text = "Designed by:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 138);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDesignedBy);
            this.Controls.Add(this.btnLight);
            this.Controls.Add(this.picLight);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form7";
            this.Text = "Tool Tip!";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox picLight;
        private System.Windows.Forms.Button btnLight;
        private System.Windows.Forms.Label lblDesignedBy;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

