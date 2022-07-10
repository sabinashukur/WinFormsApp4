namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.lbl_Vendor = new System.Windows.Forms.Label();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_Engine = new System.Windows.Forms.Label();
            this.lbl_Vendorr = new System.Windows.Forms.Label();
            this.lbl_Modell = new System.Windows.Forms.Label();
            this.lbl_Yearr = new System.Windows.Forms.Label();
            this.lbl_Enginee = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Previous
            // 
            this.btn_Previous.Location = new System.Drawing.Point(20, 462);
            this.btn_Previous.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(164, 41);
            this.btn_Previous.TabIndex = 0;
            this.btn_Previous.Text = "previous";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(1139, 462);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(164, 41);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.Text = "next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // lbl_Vendor
            // 
            this.lbl_Vendor.AutoSize = true;
            this.lbl_Vendor.Location = new System.Drawing.Point(20, 541);
            this.lbl_Vendor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Vendor.Name = "lbl_Vendor";
            this.lbl_Vendor.Size = new System.Drawing.Size(104, 28);
            this.lbl_Vendor.TabIndex = 2;
            this.lbl_Vendor.Text = "Vendor:";
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Location = new System.Drawing.Point(336, 541);
            this.lbl_Model.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(89, 28);
            this.lbl_Model.TabIndex = 3;
            this.lbl_Model.Text = "Model:";
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Location = new System.Drawing.Point(680, 541);
            this.lbl_Year.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(73, 28);
            this.lbl_Year.TabIndex = 4;
            this.lbl_Year.Text = "Year:";
            // 
            // lbl_Engine
            // 
            this.lbl_Engine.AutoSize = true;
            this.lbl_Engine.Location = new System.Drawing.Point(939, 541);
            this.lbl_Engine.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Engine.Name = "lbl_Engine";
            this.lbl_Engine.Size = new System.Drawing.Size(101, 28);
            this.lbl_Engine.TabIndex = 5;
            this.lbl_Engine.Text = "Engine:";
            // 
            // lbl_Vendorr
            // 
            this.lbl_Vendorr.AutoSize = true;
            this.lbl_Vendorr.Location = new System.Drawing.Point(186, 541);
            this.lbl_Vendorr.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Vendorr.Name = "lbl_Vendorr";
            this.lbl_Vendorr.Size = new System.Drawing.Size(0, 28);
            this.lbl_Vendorr.TabIndex = 6;
            // 
            // lbl_Modell
            // 
            this.lbl_Modell.AutoSize = true;
            this.lbl_Modell.Location = new System.Drawing.Point(485, 541);
            this.lbl_Modell.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Modell.Name = "lbl_Modell";
            this.lbl_Modell.Size = new System.Drawing.Size(0, 28);
            this.lbl_Modell.TabIndex = 7;
            // 
            // lbl_Yearr
            // 
            this.lbl_Yearr.AutoSize = true;
            this.lbl_Yearr.Location = new System.Drawing.Point(816, 541);
            this.lbl_Yearr.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Yearr.Name = "lbl_Yearr";
            this.lbl_Yearr.Size = new System.Drawing.Size(0, 28);
            this.lbl_Yearr.TabIndex = 8;
            // 
            // lbl_Enginee
            // 
            this.lbl_Enginee.AutoSize = true;
            this.lbl_Enginee.Location = new System.Drawing.Point(1105, 541);
            this.lbl_Enginee.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Enginee.Name = "lbl_Enginee";
            this.lbl_Enginee.Size = new System.Drawing.Size(0, 28);
            this.lbl_Enginee.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp4.Properties.Resources.lamborghini;
            this.pictureBox1.Location = new System.Drawing.Point(126, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1032, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1322, 641);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Enginee);
            this.Controls.Add(this.lbl_Yearr);
            this.Controls.Add(this.lbl_Modell);
            this.Controls.Add(this.lbl_Vendorr);
            this.Controls.Add(this.lbl_Engine);
            this.Controls.Add(this.lbl_Year);
            this.Controls.Add(this.lbl_Model);
            this.Controls.Add(this.lbl_Vendor);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Previous);
            this.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Car Gallery";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Previous;
        private Button btn_Next;
        private Label lbl_Vendor;
        private Label lbl_Model;
        private Label lbl_Year;
        private Label lbl_Engine;
        private Label lbl_Vendorr;
        private Label lbl_Modell;
        private Label lbl_Yearr;
        private Label lbl_Enginee;
        private PictureBox pictureBox1;
    }
}