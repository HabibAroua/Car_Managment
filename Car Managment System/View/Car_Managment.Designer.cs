namespace Car_Managment_System.View
{
    partial class Car_Managment
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
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.btAdd = new MetroFramework.Controls.MetroTile();
            this.btDelete = new MetroFramework.Controls.MetroTile();
            this.btUpdate = new MetroFramework.Controls.MetroTile();
            this.btRefrersh = new MetroFramework.Controls.MetroTile();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carburant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixParJour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(93, 154);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(159, 23);
            this.metroTextBox1.TabIndex = 0;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(39, 63);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 66);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Add";
            this.btAdd.UseTileImage = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(139, 63);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 66);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Delete";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(253, 63);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 66);
            this.btUpdate.TabIndex = 3;
            this.btUpdate.Text = "Update";
            // 
            // btRefrersh
            // 
            this.btRefrersh.Location = new System.Drawing.Point(370, 63);
            this.btRefrersh.Name = "btRefrersh";
            this.btRefrersh.Size = new System.Drawing.Size(75, 66);
            this.btRefrersh.TabIndex = 4;
            this.btRefrersh.Text = "Refresh";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reference,
            this.Marque,
            this.Carburant,
            this.prixParJour});
            this.dataGridView1.Location = new System.Drawing.Point(39, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 166);
            this.dataGridView1.TabIndex = 5;
            // 
            // Reference
            // 
            this.Reference.HeaderText = "Reference";
            this.Reference.Name = "Reference";
            // 
            // Marque
            // 
            this.Marque.HeaderText = "marque";
            this.Marque.Name = "Marque";
            // 
            // Carburant
            // 
            this.Carburant.HeaderText = "Carburant";
            this.Carburant.Name = "Carburant";
            // 
            // prixParJour
            // 
            this.prixParJour.HeaderText = "Prix par jour";
            this.prixParJour.Name = "prixParJour";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 154);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Search";
            // 
            // Car_Managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 409);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btRefrersh);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.metroTextBox1);
            this.Name = "Car_Managment";
            this.Text = "Car Managment";
            this.Load += new System.EventHandler(this.Car_Managment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTile btAdd;
        private MetroFramework.Controls.MetroTile btDelete;
        private MetroFramework.Controls.MetroTile btUpdate;
        private MetroFramework.Controls.MetroTile btRefrersh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carburant;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixParJour;
    }
}