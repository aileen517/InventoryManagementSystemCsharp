namespace InventorySystem1._0
{
    partial class frmSettings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgtypelist = new System.Windows.Forms.DataGridView();
            this.btncdel = new System.Windows.Forms.Button();
            this.btntypeupdate = new System.Windows.Forms.Button();
            this.btntypeLoad = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnTypesave = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtypelist)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgtypelist
            // 
            this.dtgtypelist.AllowUserToAddRows = false;
            this.dtgtypelist.AllowUserToDeleteRows = false;
            this.dtgtypelist.AllowUserToResizeColumns = false;
            this.dtgtypelist.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgtypelist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgtypelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgtypelist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgtypelist.Location = new System.Drawing.Point(6, 54);
            this.dtgtypelist.Name = "dtgtypelist";
            this.dtgtypelist.RowHeadersVisible = false;
            this.dtgtypelist.Size = new System.Drawing.Size(278, 312);
            this.dtgtypelist.TabIndex = 3;
            this.dtgtypelist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgtypelist_CellContentClick);
            this.dtgtypelist.Click += new System.EventHandler(this.dtgtypelist_Click);
            // 
            // btncdel
            // 
            this.btncdel.BackColor = System.Drawing.Color.White;
            this.btncdel.ForeColor = System.Drawing.Color.Black;
            this.btncdel.Location = new System.Drawing.Point(290, 89);
            this.btncdel.Name = "btncdel";
            this.btncdel.Size = new System.Drawing.Size(75, 23);
            this.btncdel.TabIndex = 6;
            this.btncdel.Text = "Delete";
            this.btncdel.UseVisualStyleBackColor = false;
            this.btncdel.Click += new System.EventHandler(this.btncdel_Click);
            // 
            // btntypeupdate
            // 
            this.btntypeupdate.BackColor = System.Drawing.Color.White;
            this.btntypeupdate.ForeColor = System.Drawing.Color.Black;
            this.btntypeupdate.Location = new System.Drawing.Point(290, 60);
            this.btntypeupdate.Name = "btntypeupdate";
            this.btntypeupdate.Size = new System.Drawing.Size(75, 23);
            this.btntypeupdate.TabIndex = 5;
            this.btntypeupdate.Text = "Update";
            this.btntypeupdate.UseVisualStyleBackColor = false;
            this.btntypeupdate.Click += new System.EventHandler(this.btntypeupdate_Click);
            // 
            // btntypeLoad
            // 
            this.btntypeLoad.BackColor = System.Drawing.Color.White;
            this.btntypeLoad.ForeColor = System.Drawing.Color.Black;
            this.btntypeLoad.Location = new System.Drawing.Point(290, 121);
            this.btntypeLoad.Name = "btntypeLoad";
            this.btntypeLoad.Size = new System.Drawing.Size(75, 23);
            this.btntypeLoad.TabIndex = 4;
            this.btntypeLoad.Text = "Load";
            this.btntypeLoad.UseVisualStyleBackColor = false;
            this.btntypeLoad.Click += new System.EventHandler(this.btntypeLoad_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(72, 28);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(212, 20);
            this.txtCategory.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(6, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Category :";
            // 
            // btnTypesave
            // 
            this.btnTypesave.BackColor = System.Drawing.Color.White;
            this.btnTypesave.ForeColor = System.Drawing.Color.Black;
            this.btnTypesave.Location = new System.Drawing.Point(290, 31);
            this.btnTypesave.Name = "btnTypesave";
            this.btnTypesave.Size = new System.Drawing.Size(75, 23);
            this.btnTypesave.TabIndex = 0;
            this.btnTypesave.Text = "Save";
            this.btnTypesave.UseVisualStyleBackColor = false;
            this.btnTypesave.Click += new System.EventHandler(this.btnTypesave_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btncdel);
            this.GroupBox1.Controls.Add(this.btntypeupdate);
            this.GroupBox1.Controls.Add(this.btntypeLoad);
            this.GroupBox1.Controls.Add(this.dtgtypelist);
            this.GroupBox1.Controls.Add(this.txtCategory);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.btnTypesave);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.GroupBox1.Location = new System.Drawing.Point(12, 9);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(374, 372);
            this.GroupBox1.TabIndex = 13;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Add new Category";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 395);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmSettings";
            this.Text = "Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.dtgtypelist)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dtgtypelist;
        internal System.Windows.Forms.Button btncdel;
        internal System.Windows.Forms.Button btntypeupdate;
        internal System.Windows.Forms.Button btntypeLoad;
        internal System.Windows.Forms.TextBox txtCategory;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnTypesave;
        internal System.Windows.Forms.GroupBox GroupBox1;
    }
}