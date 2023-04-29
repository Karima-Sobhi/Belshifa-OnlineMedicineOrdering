namespace SWproject
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.Headerpanel = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.Backhome = new System.Windows.Forms.Button();
            this.Searchpb = new System.Windows.Forms.PictureBox();
            this.SearchT = new System.Windows.Forms.TextBox();
            this.Medpanel = new System.Windows.Forms.Panel();
            this.medavaq = new System.Windows.Forms.Label();
            this.medquantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MakeOrder = new System.Windows.Forms.Button();
            this.MedPrice = new System.Windows.Forms.Label();
            this.MedName = new System.Windows.Forms.Label();
            this.medPrlabel = new System.Windows.Forms.Label();
            this.MedNalabel1 = new System.Windows.Forms.Label();
            this.Medpic = new System.Windows.Forms.PictureBox();
            this.Pharmacypanel = new System.Windows.Forms.Panel();
            this.PharmacyPhone = new System.Windows.Forms.Label();
            this.PharmacyEmail = new System.Windows.Forms.Label();
            this.PharmacyAddress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plabel1 = new System.Windows.Forms.Label();
            this.PhramacyName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Searchpb)).BeginInit();
            this.Medpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Medpic)).BeginInit();
            this.Pharmacypanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Headerpanel
            // 
            this.Headerpanel.Controls.Add(this.Logout);
            this.Headerpanel.Controls.Add(this.Backhome);
            this.Headerpanel.Controls.Add(this.Searchpb);
            this.Headerpanel.Controls.Add(this.SearchT);
            this.Headerpanel.Location = new System.Drawing.Point(3, 4);
            this.Headerpanel.Margin = new System.Windows.Forms.Padding(4);
            this.Headerpanel.Name = "Headerpanel";
            this.Headerpanel.Size = new System.Drawing.Size(1104, 64);
            this.Headerpanel.TabIndex = 0;
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(39, 15);
            this.Logout.Margin = new System.Windows.Forms.Padding(4);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(113, 36);
            this.Logout.TabIndex = 3;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Backhome
            // 
            this.Backhome.Font = new System.Drawing.Font("SketchFlow Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backhome.Location = new System.Drawing.Point(467, 14);
            this.Backhome.Margin = new System.Windows.Forms.Padding(4);
            this.Backhome.Name = "Backhome";
            this.Backhome.Size = new System.Drawing.Size(147, 37);
            this.Backhome.TabIndex = 2;
            this.Backhome.Text = "Pharmacies";
            this.Backhome.UseVisualStyleBackColor = true;
            this.Backhome.Click += new System.EventHandler(this.Backhome_Click);
            // 
            // Searchpb
            // 
            this.Searchpb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Searchpb.Image = ((System.Drawing.Image)(resources.GetObject("Searchpb.Image")));
            this.Searchpb.Location = new System.Drawing.Point(780, 12);
            this.Searchpb.Margin = new System.Windows.Forms.Padding(4);
            this.Searchpb.Name = "Searchpb";
            this.Searchpb.Size = new System.Drawing.Size(57, 30);
            this.Searchpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Searchpb.TabIndex = 1;
            this.Searchpb.TabStop = false;
            this.Searchpb.Click += new System.EventHandler(this.Searchpb_Click);
            // 
            // SearchT
            // 
            this.SearchT.Location = new System.Drawing.Point(837, 12);
            this.SearchT.Margin = new System.Windows.Forms.Padding(4);
            this.SearchT.Multiline = true;
            this.SearchT.Name = "SearchT";
            this.SearchT.Size = new System.Drawing.Size(209, 30);
            this.SearchT.TabIndex = 0;
            // 
            // Medpanel
            // 
            this.Medpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Medpanel.Controls.Add(this.medavaq);
            this.Medpanel.Controls.Add(this.medquantity);
            this.Medpanel.Controls.Add(this.label7);
            this.Medpanel.Controls.Add(this.MakeOrder);
            this.Medpanel.Controls.Add(this.MedPrice);
            this.Medpanel.Controls.Add(this.MedName);
            this.Medpanel.Controls.Add(this.medPrlabel);
            this.Medpanel.Controls.Add(this.MedNalabel1);
            this.Medpanel.Controls.Add(this.Medpic);
            this.Medpanel.Location = new System.Drawing.Point(16, 75);
            this.Medpanel.Margin = new System.Windows.Forms.Padding(4);
            this.Medpanel.Name = "Medpanel";
            this.Medpanel.Size = new System.Drawing.Size(328, 379);
            this.Medpanel.TabIndex = 1;
            this.Medpanel.Visible = false;
            this.Medpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Medpanel_Paint);
            // 
            // medavaq
            // 
            this.medavaq.AutoSize = true;
            this.medavaq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medavaq.Location = new System.Drawing.Point(189, 252);
            this.medavaq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.medavaq.Name = "medavaq";
            this.medavaq.Size = new System.Drawing.Size(0, 20);
            this.medavaq.TabIndex = 14;
            // 
            // medquantity
            // 
            this.medquantity.Location = new System.Drawing.Point(113, 250);
            this.medquantity.Name = "medquantity";
            this.medquantity.Size = new System.Drawing.Size(54, 22);
            this.medquantity.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 250);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Quantity:";
            // 
            // MakeOrder
            // 
            this.MakeOrder.BackColor = System.Drawing.Color.Gray;
            this.MakeOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeOrder.Location = new System.Drawing.Point(177, 304);
            this.MakeOrder.Margin = new System.Windows.Forms.Padding(4);
            this.MakeOrder.Name = "MakeOrder";
            this.MakeOrder.Size = new System.Drawing.Size(113, 53);
            this.MakeOrder.TabIndex = 5;
            this.MakeOrder.Text = "Order";
            this.MakeOrder.UseVisualStyleBackColor = false;
            this.MakeOrder.Click += new System.EventHandler(this.MakeOrder_Click);
            // 
            // MedPrice
            // 
            this.MedPrice.AutoSize = true;
            this.MedPrice.Location = new System.Drawing.Point(92, 226);
            this.MedPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MedPrice.Name = "MedPrice";
            this.MedPrice.Size = new System.Drawing.Size(0, 17);
            this.MedPrice.TabIndex = 4;
            // 
            // MedName
            // 
            this.MedName.AutoSize = true;
            this.MedName.Location = new System.Drawing.Point(99, 178);
            this.MedName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MedName.Name = "MedName";
            this.MedName.Size = new System.Drawing.Size(0, 17);
            this.MedName.TabIndex = 3;
            // 
            // medPrlabel
            // 
            this.medPrlabel.AutoSize = true;
            this.medPrlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medPrlabel.Location = new System.Drawing.Point(21, 223);
            this.medPrlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.medPrlabel.Name = "medPrlabel";
            this.medPrlabel.Size = new System.Drawing.Size(59, 20);
            this.medPrlabel.TabIndex = 2;
            this.medPrlabel.Text = "Price:";
            // 
            // MedNalabel1
            // 
            this.MedNalabel1.AutoSize = true;
            this.MedNalabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedNalabel1.Location = new System.Drawing.Point(21, 175);
            this.MedNalabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MedNalabel1.Name = "MedNalabel1";
            this.MedNalabel1.Size = new System.Drawing.Size(63, 20);
            this.MedNalabel1.TabIndex = 1;
            this.MedNalabel1.Text = "Name:";
            // 
            // Medpic
            // 
            this.Medpic.Location = new System.Drawing.Point(4, 4);
            this.Medpic.Margin = new System.Windows.Forms.Padding(4);
            this.Medpic.Name = "Medpic";
            this.Medpic.Size = new System.Drawing.Size(320, 144);
            this.Medpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Medpic.TabIndex = 0;
            this.Medpic.TabStop = false;
            // 
            // Pharmacypanel
            // 
            this.Pharmacypanel.Controls.Add(this.PharmacyPhone);
            this.Pharmacypanel.Controls.Add(this.PharmacyEmail);
            this.Pharmacypanel.Controls.Add(this.PharmacyAddress);
            this.Pharmacypanel.Controls.Add(this.label2);
            this.Pharmacypanel.Controls.Add(this.label1);
            this.Pharmacypanel.Controls.Add(this.plabel1);
            this.Pharmacypanel.Controls.Add(this.PhramacyName);
            this.Pharmacypanel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pharmacypanel.Location = new System.Drawing.Point(3, 462);
            this.Pharmacypanel.Margin = new System.Windows.Forms.Padding(4);
            this.Pharmacypanel.Name = "Pharmacypanel";
            this.Pharmacypanel.Size = new System.Drawing.Size(1104, 90);
            this.Pharmacypanel.TabIndex = 2;
            // 
            // PharmacyPhone
            // 
            this.PharmacyPhone.AutoSize = true;
            this.PharmacyPhone.Location = new System.Drawing.Point(556, 65);
            this.PharmacyPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PharmacyPhone.Name = "PharmacyPhone";
            this.PharmacyPhone.Size = new System.Drawing.Size(0, 19);
            this.PharmacyPhone.TabIndex = 7;
            // 
            // PharmacyEmail
            // 
            this.PharmacyEmail.AutoSize = true;
            this.PharmacyEmail.Location = new System.Drawing.Point(847, 65);
            this.PharmacyEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PharmacyEmail.Name = "PharmacyEmail";
            this.PharmacyEmail.Size = new System.Drawing.Size(0, 19);
            this.PharmacyEmail.TabIndex = 6;
            // 
            // PharmacyAddress
            // 
            this.PharmacyAddress.AutoSize = true;
            this.PharmacyAddress.Location = new System.Drawing.Point(893, 17);
            this.PharmacyAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PharmacyAddress.Name = "PharmacyAddress";
            this.PharmacyAddress.Size = new System.Drawing.Size(0, 19);
            this.PharmacyAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(776, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email:";
            // 
            // plabel1
            // 
            this.plabel1.AutoSize = true;
            this.plabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plabel1.Location = new System.Drawing.Point(776, 17);
            this.plabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plabel1.Name = "plabel1";
            this.plabel1.Size = new System.Drawing.Size(84, 20);
            this.plabel1.TabIndex = 3;
            this.plabel1.Text = "Address:";
            // 
            // PhramacyName
            // 
            this.PhramacyName.AutoSize = true;
            this.PhramacyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhramacyName.Location = new System.Drawing.Point(52, 30);
            this.PhramacyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhramacyName.Name = "PhramacyName";
            this.PhramacyName.Size = new System.Drawing.Size(0, 31);
            this.PhramacyName.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 549);
            this.Controls.Add(this.Pharmacypanel);
            this.Controls.Add(this.Medpanel);
            this.Controls.Add(this.Headerpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchForm";
            this.Text = "SearchForMedicines";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Headerpanel.ResumeLayout(false);
            this.Headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Searchpb)).EndInit();
            this.Medpanel.ResumeLayout(false);
            this.Medpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Medpic)).EndInit();
            this.Pharmacypanel.ResumeLayout(false);
            this.Pharmacypanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Headerpanel;
        private System.Windows.Forms.TextBox SearchT;
        private System.Windows.Forms.PictureBox Searchpb;
        private System.Windows.Forms.Panel Medpanel;
        private System.Windows.Forms.Button MakeOrder;
        private System.Windows.Forms.Label MedPrice;
        private System.Windows.Forms.Label MedName;
        private System.Windows.Forms.Label medPrlabel;
        private System.Windows.Forms.Label MedNalabel1;
        private System.Windows.Forms.PictureBox Medpic;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Backhome;
        private System.Windows.Forms.Panel Pharmacypanel;
        private System.Windows.Forms.Label PharmacyPhone;
        private System.Windows.Forms.Label PharmacyEmail;
        private System.Windows.Forms.Label PharmacyAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plabel1;
        private System.Windows.Forms.Label PhramacyName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label medavaq;
        private System.Windows.Forms.TextBox medquantity;
        private System.Windows.Forms.Label label7;
    }
}

