namespace SoftwareFormsApp1
{
    partial class DeliveryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pending_cmb = new System.Windows.Forms.ComboBox();
            this.showpendingorders = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.canceledLabel = new System.Windows.Forms.Label();
            this.showcanceledorders = new System.Windows.Forms.Button();
            this.submit_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pending Orders";
            // 
            // pending_cmb
            // 
            this.pending_cmb.FormattingEnabled = true;
            this.pending_cmb.Location = new System.Drawing.Point(356, 117);
            this.pending_cmb.Name = "pending_cmb";
            this.pending_cmb.Size = new System.Drawing.Size(130, 24);
            this.pending_cmb.TabIndex = 1;
            // 
            // showpendingorders
            // 
            this.showpendingorders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.showpendingorders.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpendingorders.Location = new System.Drawing.Point(511, 112);
            this.showpendingorders.Margin = new System.Windows.Forms.Padding(4);
            this.showpendingorders.Name = "showpendingorders";
            this.showpendingorders.Size = new System.Drawing.Size(103, 36);
            this.showpendingorders.TabIndex = 12;
            this.showpendingorders.Text = "Show";
            this.showpendingorders.UseVisualStyleBackColor = false;
            this.showpendingorders.Click += new System.EventHandler(this.showpendingorders_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Number Of Canceled Orders";
            // 
            // canceledLabel
            // 
            this.canceledLabel.AutoSize = true;
            this.canceledLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canceledLabel.ForeColor = System.Drawing.Color.Maroon;
            this.canceledLabel.Location = new System.Drawing.Point(389, 245);
            this.canceledLabel.Name = "canceledLabel";
            this.canceledLabel.Size = new System.Drawing.Size(97, 37);
            this.canceledLabel.TabIndex = 14;
            this.canceledLabel.Text = "          ";
            // 
            // showcanceledorders
            // 
            this.showcanceledorders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.showcanceledorders.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showcanceledorders.Location = new System.Drawing.Point(511, 245);
            this.showcanceledorders.Margin = new System.Windows.Forms.Padding(4);
            this.showcanceledorders.Name = "showcanceledorders";
            this.showcanceledorders.Size = new System.Drawing.Size(103, 36);
            this.showcanceledorders.TabIndex = 15;
            this.showcanceledorders.Text = "Show";
            this.showcanceledorders.UseVisualStyleBackColor = false;
            this.showcanceledorders.Click += new System.EventHandler(this.showcanceledorders_Click);
            // 
            // submit_btn
            // 
            this.submit_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submit_btn.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.Location = new System.Drawing.Point(939, 509);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(153, 78);
            this.submit_btn.TabIndex = 16;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = false;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.home_btn.Font = new System.Drawing.Font("Harlow Solid Italic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.Location = new System.Drawing.Point(13, 13);
            this.home_btn.Margin = new System.Windows.Forms.Padding(4);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(144, 48);
            this.home_btn.TabIndex = 17;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1197, 670);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.showcanceledorders);
            this.Controls.Add(this.canceledLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showpendingorders);
            this.Controls.Add(this.pending_cmb);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "DeliveryForm";
            this.Text = "DeliveryForm";
            this.Load += new System.EventHandler(this.DeliveryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pending_cmb;
        private System.Windows.Forms.Button showpendingorders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label canceledLabel;
        private System.Windows.Forms.Button showcanceledorders;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Button home_btn;
    }
}