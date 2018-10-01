namespace JaeYong_LeeInLabs_03
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
            this.lblRadisu = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtCounts = new System.Windows.Forms.TextBox();
            this.lblNumberOfCans = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnTotalVolume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRadisu
            // 
            this.lblRadisu.AutoSize = true;
            this.lblRadisu.Location = new System.Drawing.Point(55, 35);
            this.lblRadisu.Name = "lblRadisu";
            this.lblRadisu.Size = new System.Drawing.Size(43, 13);
            this.lblRadisu.TabIndex = 0;
            this.lblRadisu.Text = "Radius:";
           // this.lblRadisu.Click += new System.EventHandler(this.lblRadiu_Click);
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(104, 32);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(139, 20);
            this.txtRadius.TabIndex = 1;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(20, 110);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(223, 91);
            this.txtDisplay.TabIndex = 2;
           // this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(109, 207);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(179, 207);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(104, 58);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(139, 20);
            this.txtHeight.TabIndex = 8;
           // this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(57, 61);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 7;
            this.lblHeight.Text = "Height:";
            // 
            // txtCounts
            // 
            this.txtCounts.Location = new System.Drawing.Point(104, 84);
            this.txtCounts.Name = "txtCounts";
            this.txtCounts.Size = new System.Drawing.Size(139, 20);
            this.txtCounts.TabIndex = 10;
            // 
            // lblNumberOfCans
            // 
            this.lblNumberOfCans.AutoSize = true;
            this.lblNumberOfCans.Location = new System.Drawing.Point(36, 87);
            this.lblNumberOfCans.Name = "lblNumberOfCans";
            this.lblNumberOfCans.Size = new System.Drawing.Size(62, 13);
            this.lblNumberOfCans.TabIndex = 9;
            this.lblNumberOfCans.Text = "# of Can(s):";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(241, 18);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Total Sauce Volume Calculator";
            // 
            // btnTotalVolume
            // 
            this.btnTotalVolume.Location = new System.Drawing.Point(20, 207);
            this.btnTotalVolume.Name = "btnTotalVolume";
            this.btnTotalVolume.Size = new System.Drawing.Size(83, 23);
            this.btnTotalVolume.TabIndex = 12;
            this.btnTotalVolume.Text = "&Total Volume";
            this.btnTotalVolume.UseVisualStyleBackColor = true;
            this.btnTotalVolume.Click += new System.EventHandler(this.btnTotalVolume_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 235);
            this.Controls.Add(this.btnTotalVolume);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtCounts);
            this.Controls.Add(this.lblNumberOfCans);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblRadisu);
            this.Name = "Form1";
            this.Text = "InLab03 - By Jae Yong Lee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadisu;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtCounts;
        private System.Windows.Forms.Label lblNumberOfCans;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnTotalVolume;
    }
}

