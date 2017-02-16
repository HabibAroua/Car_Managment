namespace Car_Managment_System.View
{
    partial class AddCar
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtReference = new MetroFramework.Controls.MetroTextBox();
            this.txtMarque = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtPrixJour = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.carburantCamboBox = new MetroFramework.Controls.MetroComboBox();
            this.btAjouter = new MetroFramework.Controls.MetroButton();
            this.btAnnuler = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Reference";
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(123, 63);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(135, 23);
            this.txtReference.TabIndex = 1;
            // 
            // txtMarque
            // 
            this.txtMarque.Location = new System.Drawing.Point(123, 108);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.Size = new System.Drawing.Size(135, 23);
            this.txtMarque.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 108);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Marque";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 152);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Carburant";
            // 
            // txtPrixJour
            // 
            this.txtPrixJour.Location = new System.Drawing.Point(123, 197);
            this.txtPrixJour.Name = "txtPrixJour";
            this.txtPrixJour.Size = new System.Drawing.Size(135, 23);
            this.txtPrixJour.TabIndex = 7;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 197);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Prix par jour";
            // 
            // carburantCamboBox
            // 
            this.carburantCamboBox.FormattingEnabled = true;
            this.carburantCamboBox.ItemHeight = 23;
            this.carburantCamboBox.Location = new System.Drawing.Point(123, 149);
            this.carburantCamboBox.Name = "carburantCamboBox";
            this.carburantCamboBox.Size = new System.Drawing.Size(135, 29);
            this.carburantCamboBox.TabIndex = 8;
            // 
            // btAjouter
            // 
            this.btAjouter.Location = new System.Drawing.Point(53, 247);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(75, 23);
            this.btAjouter.TabIndex = 9;
            this.btAjouter.Text = "Ajouter";
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(152, 247);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btAnnuler.TabIndex = 10;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 281);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btAjouter);
            this.Controls.Add(this.carburantCamboBox);
            this.Controls.Add(this.txtPrixJour);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtMarque);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddCar";
            this.Text = "AddCar";
            this.Load += new System.EventHandler(this.AddCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtReference;
        private MetroFramework.Controls.MetroTextBox txtMarque;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtPrixJour;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox carburantCamboBox;
        private MetroFramework.Controls.MetroButton btAjouter;
        private MetroFramework.Controls.MetroButton btAnnuler;
    }
}