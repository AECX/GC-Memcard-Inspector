namespace GC_MemCard_Reader
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.btnLoad = new System.Windows.Forms.Button();
            this.labelDateCreated = new System.Windows.Forms.Label();
            this.labelCardSize = new System.Windows.Forms.Label();
            this.labelEncoding = new System.Windows.Forms.Label();
            this.labelChecksum1 = new System.Windows.Forms.Label();
            this.labelChecksum2 = new System.Windows.Forms.Label();
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.txtCardSize = new System.Windows.Forms.TextBox();
            this.txtEncoding = new System.Windows.Forms.TextBox();
            this.txtChecksum1 = new System.Windows.Forms.TextBox();
            this.txtChecksum2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCopyRight = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.DereferenceLinks = false;
            this.openFile.Filter = "Memory Card| *.raw";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Card";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // labelDateCreated
            // 
            this.labelDateCreated.AutoSize = true;
            this.labelDateCreated.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateCreated.Location = new System.Drawing.Point(12, 38);
            this.labelDateCreated.Name = "labelDateCreated";
            this.labelDateCreated.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelDateCreated.Size = new System.Drawing.Size(130, 32);
            this.labelDateCreated.TabIndex = 1;
            this.labelDateCreated.Text = "Date Created";
            // 
            // labelCardSize
            // 
            this.labelCardSize.AutoSize = true;
            this.labelCardSize.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardSize.Location = new System.Drawing.Point(12, 70);
            this.labelCardSize.Name = "labelCardSize";
            this.labelCardSize.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelCardSize.Size = new System.Drawing.Size(150, 32);
            this.labelCardSize.TabIndex = 2;
            this.labelCardSize.Text = "Card Size (MB)";
            // 
            // labelEncoding
            // 
            this.labelEncoding.AutoSize = true;
            this.labelEncoding.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncoding.Location = new System.Drawing.Point(12, 102);
            this.labelEncoding.Name = "labelEncoding";
            this.labelEncoding.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelEncoding.Size = new System.Drawing.Size(90, 32);
            this.labelEncoding.TabIndex = 3;
            this.labelEncoding.Text = "Encoding";
            // 
            // labelChecksum1
            // 
            this.labelChecksum1.AutoSize = true;
            this.labelChecksum1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChecksum1.Location = new System.Drawing.Point(12, 134);
            this.labelChecksum1.Name = "labelChecksum1";
            this.labelChecksum1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelChecksum1.Size = new System.Drawing.Size(110, 32);
            this.labelChecksum1.TabIndex = 4;
            this.labelChecksum1.Text = "Checksum 1";
            // 
            // labelChecksum2
            // 
            this.labelChecksum2.AutoSize = true;
            this.labelChecksum2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChecksum2.Location = new System.Drawing.Point(12, 166);
            this.labelChecksum2.Name = "labelChecksum2";
            this.labelChecksum2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelChecksum2.Size = new System.Drawing.Size(110, 32);
            this.labelChecksum2.TabIndex = 5;
            this.labelChecksum2.Text = "Checksum 2";
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateCreated.Location = new System.Drawing.Point(3, 10);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.ReadOnly = true;
            this.txtDateCreated.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateCreated.Size = new System.Drawing.Size(179, 22);
            this.txtDateCreated.TabIndex = 0;
            // 
            // txtCardSize
            // 
            this.txtCardSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardSize.Location = new System.Drawing.Point(3, 42);
            this.txtCardSize.Name = "txtCardSize";
            this.txtCardSize.ReadOnly = true;
            this.txtCardSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCardSize.Size = new System.Drawing.Size(179, 22);
            this.txtCardSize.TabIndex = 1;
            // 
            // txtEncoding
            // 
            this.txtEncoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncoding.Location = new System.Drawing.Point(3, 74);
            this.txtEncoding.Name = "txtEncoding";
            this.txtEncoding.ReadOnly = true;
            this.txtEncoding.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEncoding.Size = new System.Drawing.Size(179, 22);
            this.txtEncoding.TabIndex = 2;
            // 
            // txtChecksum1
            // 
            this.txtChecksum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChecksum1.Location = new System.Drawing.Point(3, 106);
            this.txtChecksum1.Name = "txtChecksum1";
            this.txtChecksum1.ReadOnly = true;
            this.txtChecksum1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtChecksum1.Size = new System.Drawing.Size(179, 22);
            this.txtChecksum1.TabIndex = 3;
            // 
            // txtChecksum2
            // 
            this.txtChecksum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChecksum2.Location = new System.Drawing.Point(3, 136);
            this.txtChecksum2.Name = "txtChecksum2";
            this.txtChecksum2.ReadOnly = true;
            this.txtChecksum2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtChecksum2.Size = new System.Drawing.Size(179, 22);
            this.txtChecksum2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtChecksum2);
            this.panel1.Controls.Add(this.txtChecksum1);
            this.panel1.Controls.Add(this.txtEncoding);
            this.panel1.Controls.Add(this.txtCardSize);
            this.panel1.Controls.Add(this.txtDateCreated);
            this.panel1.Location = new System.Drawing.Point(168, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 161);
            this.panel1.TabIndex = 6;
            // 
            // labelCopyRight
            // 
            this.labelCopyRight.AutoSize = true;
            this.labelCopyRight.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyRight.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.labelCopyRight.Location = new System.Drawing.Point(294, 12);
            this.labelCopyRight.Name = "labelCopyRight";
            this.labelCopyRight.Size = new System.Drawing.Size(47, 15);
            this.labelCopyRight.TabIndex = 7;
            this.labelCopyRight.TabStop = true;
            this.labelCopyRight.Text = "© AECX";
            this.labelCopyRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCopyRight.Click += labelLink_Copyright_Clicked;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 211);
            this.Controls.Add(this.labelCopyRight);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelChecksum2);
            this.Controls.Add(this.labelChecksum1);
            this.Controls.Add(this.labelEncoding);
            this.Controls.Add(this.labelCardSize);
            this.Controls.Add(this.labelDateCreated);
            this.Controls.Add(this.btnLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "GC Memory Card Inspector";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label labelDateCreated;
        private System.Windows.Forms.Label labelCardSize;
        private System.Windows.Forms.Label labelEncoding;
        private System.Windows.Forms.Label labelChecksum1;
        private System.Windows.Forms.Label labelChecksum2;
        private MemCard memCard;
        private System.Windows.Forms.TextBox txtDateCreated;
        private System.Windows.Forms.TextBox txtCardSize;
        private System.Windows.Forms.TextBox txtEncoding;
        private System.Windows.Forms.TextBox txtChecksum1;
        private System.Windows.Forms.TextBox txtChecksum2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel labelCopyRight;
    }
}

