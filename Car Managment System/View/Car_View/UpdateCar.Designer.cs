namespace Car_Managment_System.View
{
    partial class UpdateCar
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
            this.btAnnuler = new MetroFramework.Controls.MetroButton();
            this.btModifier = new MetroFramework.Controls.MetroButton();
            this.carburantCamboBox = new MetroFramework.Controls.MetroComboBox();
            this.txtPrixJour = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMarque = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtReference = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(173, 258);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btAnnuler.TabIndex = 20;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // btModifier
            // 
            this.btModifier.Location = new System.Drawing.Point(74, 258);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(75, 23);
            this.btModifier.TabIndex = 19;
            this.btModifier.Text = "Modifier";
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // carburantCamboBox
            // 
            this.carburantCamboBox.FormattingEnabled = true;
            this.carburantCamboBox.ItemHeight = 23;
            this.carburantCamboBox.Location = new System.Drawing.Point(144, 160);
            this.carburantCamboBox.Name = "carburantCamboBox";
            this.carburantCamboBox.Size = new System.Drawing.Size(135, 29);
            this.carburantCamboBox.TabIndex = 18;
            // 
            // txtPrixJour
            // 
            this.txtPrixJour.Location = new System.Drawing.Point(144, 208);
            this.txtPrixJour.Name = "txtPrixJour";
            this.txtPrixJour.Size = new System.Drawing.Size(135, 23);
            this.txtPrixJour.TabIndex = 17;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(27, 208);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 19);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Prix par jour";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(27, 163);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Carburant";
            // 
            // txtMarque
            // 
            this.txtMarque.Location = new System.Drawing.Point(144, 119);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.Size = new System.Drawing.Size(135, 23);
            this.txtMarque.TabIndex = 14;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Marque";
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(144, 74);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(135, 23);
            this.txtReference.TabIndex = 12;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Reference";
            // 
            // UpdateCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 301);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btModifier);
            this.Controls.Add(this.carburantCamboBox);
            this.Controls.Add(this.txtPrixJour);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtMarque);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UpdateCar";
            this.Text = "Update Car";
            this.Load += new System.EventHandler(this.UpdateCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btAnnuler;
        private MetroFramework.Controls.MetroButton btModifier;
        private MetroFramework.Controls.MetroComboBox carburantCamboBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroTextBox txtPrixJour;
        public MetroFramework.Controls.MetroTextBox txtMarque;
        public MetroFramework.Controls.MetroTextBox txtReference;
    }
}