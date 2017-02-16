namespace Car_Managment_System.View
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.ClientTitle = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btExist = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(42, 94);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(115, 89);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Car Managment";
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // ClientTitle
            // 
            this.ClientTitle.Location = new System.Drawing.Point(224, 94);
            this.ClientTitle.Name = "ClientTitle";
            this.ClientTitle.Size = new System.Drawing.Size(124, 89);
            this.ClientTitle.TabIndex = 1;
            this.ClientTitle.Text = "Client Mangment";
            this.ClientTitle.Click += new System.EventHandler(this.ClientTitle_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(42, 234);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(115, 89);
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "Rental Management";
            // 
            // metroTile4
            // 
            this.metroTile4.Location = new System.Drawing.Point(224, 234);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(124, 89);
            this.metroTile4.TabIndex = 3;
            this.metroTile4.Text = "Control Car";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(422, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 229);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btExist
            // 
            this.btExist.Location = new System.Drawing.Point(728, 41);
            this.btExist.Name = "btExist";
            this.btExist.Size = new System.Drawing.Size(86, 31);
            this.btExist.TabIndex = 5;
            this.btExist.Text = "Exist";
            this.btExist.Click += new System.EventHandler(this.btExist_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(875, 374);
            this.Controls.Add(this.btExist);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.ClientTitle);
            this.Controls.Add(this.metroTile1);
            this.Name = "Index";
            this.Text = "Welcome";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile ClientTitle;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btExist;
    }
}