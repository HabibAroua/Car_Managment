namespace Car_Managment_System.View
{
    partial class Clients_Managment
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
            this.btBack = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btOrganizationManagment = new MetroFramework.Controls.MetroButton();
            this.btClientManagment = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(8, 75);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 38);
            this.btBack.TabIndex = 17;
            this.btBack.Text = "Back";
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Aqua;
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btOrganizationManagment);
            this.metroPanel1.Controls.Add(this.btClientManagment);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(13, 119);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(350, 176);
            this.metroPanel1.TabIndex = 18;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btOrganizationManagment
            // 
            this.btOrganizationManagment.Location = new System.Drawing.Point(27, 110);
            this.btOrganizationManagment.Name = "btOrganizationManagment";
            this.btOrganizationManagment.Size = new System.Drawing.Size(297, 37);
            this.btOrganizationManagment.TabIndex = 3;
            this.btOrganizationManagment.Text = "Organization Managment";
            this.btOrganizationManagment.Click += new System.EventHandler(this.btOrganizationManagment_Click);
            // 
            // btClientManagment
            // 
            this.btClientManagment.Location = new System.Drawing.Point(27, 47);
            this.btClientManagment.Name = "btClientManagment";
            this.btClientManagment.Size = new System.Drawing.Size(297, 37);
            this.btClientManagment.TabIndex = 2;
            this.btClientManagment.Text = "Client Managment";
            this.btClientManagment.Click += new System.EventHandler(this.btClientManagment_Click);
            // 
            // Clients_Managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 319);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btBack);
            this.Name = "Clients_Managment";
            this.Text = "Client Managment";
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btBack;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btOrganizationManagment;
        private MetroFramework.Controls.MetroButton btClientManagment;
    }
}