namespace Car_Managment_System.View
{
    partial class Organization_Managment
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btRefrersh = new MetroFramework.Controls.MetroTile();
            this.btUpdate = new MetroFramework.Controls.MetroTile();
            this.btDelete = new MetroFramework.Controls.MetroTile();
            this.btAdd = new MetroFramework.Controls.MetroTile();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(27, 88);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 38);
            this.btBack.TabIndex = 25;
            this.btBack.Text = "Back";
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(163, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(603, 150);
            this.dataGridView1.TabIndex = 24;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(163, 170);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Search";
            // 
            // btRefrersh
            // 
            this.btRefrersh.Location = new System.Drawing.Point(494, 79);
            this.btRefrersh.Name = "btRefrersh";
            this.btRefrersh.Size = new System.Drawing.Size(75, 66);
            this.btRefrersh.TabIndex = 22;
            this.btRefrersh.Text = "Refresh";
            this.btRefrersh.Click += new System.EventHandler(this.btRefrersh_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(377, 79);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 66);
            this.btUpdate.TabIndex = 21;
            this.btUpdate.Text = "Update";
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(263, 79);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 66);
            this.btDelete.TabIndex = 20;
            this.btDelete.Text = "Delete";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(163, 79);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 66);
            this.btAdd.TabIndex = 19;
            this.btAdd.Text = "Add";
            this.btAdd.UseTileImage = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(217, 170);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(159, 23);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Organization_Managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btRefrersh);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtSearch);
            this.Name = "Organization_Managment";
            this.Text = "Organization Managment";
            this.Load += new System.EventHandler(this.Organization_Managment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile btRefrersh;
        private MetroFramework.Controls.MetroTile btUpdate;
        private MetroFramework.Controls.MetroTile btDelete;
        private MetroFramework.Controls.MetroTile btAdd;
        private MetroFramework.Controls.MetroTextBox txtSearch;
    }
}