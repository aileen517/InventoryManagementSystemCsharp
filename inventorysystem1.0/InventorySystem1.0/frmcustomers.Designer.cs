
namespace InventorySystem1._0
{
    partial class frmcustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcustomers));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_listcustomer = new System.Windows.Forms.DataGridView();
            this.Button1 = new System.Windows.Forms.Button();
            this.btn_saveuser = new System.Windows.Forms.Button();
            this.btn_delete1 = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.lbl_id1 = new System.Windows.Forms.Label();
            this.btn_update1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listcustomer)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox1.Controls.Add(this.dtg_listcustomer);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupBox1.Location = new System.Drawing.Point(0, 303);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(800, 310);
            this.GroupBox1.TabIndex = 33;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "List Of Customers";
            // 
            // dtg_listcustomer
            // 
            this.dtg_listcustomer.AllowUserToAddRows = false;
            this.dtg_listcustomer.AllowUserToDeleteRows = false;
            this.dtg_listcustomer.AllowUserToResizeColumns = false;
            this.dtg_listcustomer.AllowUserToResizeRows = false;
            this.dtg_listcustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_listcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listcustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_listcustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_listcustomer.Location = new System.Drawing.Point(3, 16);
            this.dtg_listcustomer.Name = "dtg_listcustomer";
            this.dtg_listcustomer.RowHeadersVisible = false;
            this.dtg_listcustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_listcustomer.Size = new System.Drawing.Size(794, 291);
            this.dtg_listcustomer.TabIndex = 0;
            this.dtg_listcustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_listcustomer_CellContentClick);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button1.Location = new System.Drawing.Point(599, 250);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(132, 26);
            this.Button1.TabIndex = 34;
            this.Button1.Text = "Close";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_saveuser
            // 
            this.btn_saveuser.BackColor = System.Drawing.Color.Transparent;
            this.btn_saveuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_saveuser.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveuser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_saveuser.Location = new System.Drawing.Point(42, 251);
            this.btn_saveuser.Name = "btn_saveuser";
            this.btn_saveuser.Size = new System.Drawing.Size(138, 26);
            this.btn_saveuser.TabIndex = 29;
            this.btn_saveuser.Text = "Save";
            this.btn_saveuser.UseVisualStyleBackColor = false;
            this.btn_saveuser.Click += new System.EventHandler(this.btn_saveuser_Click);
            // 
            // btn_delete1
            // 
            this.btn_delete1.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete1.Enabled = false;
            this.btn_delete1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delete1.Location = new System.Drawing.Point(330, 249);
            this.btn_delete1.Name = "btn_delete1";
            this.btn_delete1.Size = new System.Drawing.Size(125, 26);
            this.btn_delete1.TabIndex = 32;
            this.btn_delete1.Text = "Delete";
            this.btn_delete1.UseVisualStyleBackColor = false;
            this.btn_delete1.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.Color.Transparent;
            this.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_New.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_New.Location = new System.Drawing.Point(461, 249);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(132, 26);
            this.btn_New.TabIndex = 31;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click_1);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.txt_mobile);
            this.Panel1.Controls.Add(this.txt_address);
            this.Panel1.Controls.Add(this.txt_lastname);
            this.Panel1.Controls.Add(this.txt_firstname);
            this.Panel1.Controls.Add(this.label5);
            this.Panel1.Controls.Add(this.lbl_id1);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(800, 160);
            this.Panel1.TabIndex = 40;
            // 
            // txt_mobile
            // 
            this.txt_mobile.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobile.Location = new System.Drawing.Point(282, 113);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(280, 22);
            this.txt_mobile.TabIndex = 56;
            this.txt_mobile.TextChanged += new System.EventHandler(this.txt_mobile_TextChanged);
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(282, 85);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(280, 22);
            this.txt_address.TabIndex = 55;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lastname.Location = new System.Drawing.Point(282, 56);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(280, 22);
            this.txt_lastname.TabIndex = 54;
            // 
            // txt_firstname
            // 
            this.txt_firstname.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_firstname.Location = new System.Drawing.Point(282, 26);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(280, 22);
            this.txt_firstname.TabIndex = 53;
            this.txt_firstname.TextChanged += new System.EventHandler(this.txt_firstname_TextChanged);
            // 
            // lbl_id1
            // 
            this.lbl_id1.AutoSize = true;
            this.lbl_id1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id1.Location = new System.Drawing.Point(305, 23);
            this.lbl_id1.Name = "lbl_id1";
            this.lbl_id1.Size = new System.Drawing.Size(18, 16);
            this.lbl_id1.TabIndex = 47;
            this.lbl_id1.Text = "id";
            this.lbl_id1.Visible = false;
            this.lbl_id1.Click += new System.EventHandler(this.lbl_id1_Click);
            // 
            // btn_update1
            // 
            this.btn_update1.BackColor = System.Drawing.Color.Transparent;
            this.btn_update1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_update1.Location = new System.Drawing.Point(186, 249);
            this.btn_update1.Name = "btn_update1";
            this.btn_update1.Size = new System.Drawing.Size(138, 26);
            this.btn_update1.TabIndex = 41;
            this.btn_update1.Text = "Update";
            this.btn_update1.UseVisualStyleBackColor = false;
            this.btn_update1.Click += new System.EventHandler(this.btn_update1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(207, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Mobile :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Image = ((System.Drawing.Image)(resources.GetObject("Label2.Image")));
            this.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label2.Location = new System.Drawing.Point(199, 26);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(71, 16);
            this.Label2.TabIndex = 44;
            this.Label2.Text = "First Name :";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Image = ((System.Drawing.Image)(resources.GetObject("Label4.Image")));
            this.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label4.Location = new System.Drawing.Point(207, 88);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(58, 16);
            this.Label4.TabIndex = 46;
            this.Label4.Text = "Address :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Image = ((System.Drawing.Image)(resources.GetObject("Label3.Image")));
            this.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label3.Location = new System.Drawing.Point(202, 56);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(70, 16);
            this.Label3.TabIndex = 45;
            this.Label3.Text = "Last Name :";
            // 
            // frmcustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.btn_update1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.btn_saveuser);
            this.Controls.Add(this.btn_delete1);
            this.Controls.Add(this.btn_New);
            this.Name = "frmcustomers";
            this.Text = "Manage Customers";
            this.Load += new System.EventHandler(this.frmcustomers_Load);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listcustomer)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DataGridView dtg_listcustomer;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button btn_saveuser;
        internal System.Windows.Forms.Button btn_delete1;
        internal System.Windows.Forms.Button btn_New;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label lbl_id1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txt_firstname;
        internal System.Windows.Forms.TextBox txt_mobile;
        internal System.Windows.Forms.TextBox txt_address;
        internal System.Windows.Forms.TextBox txt_lastname;
        internal System.Windows.Forms.Button btn_update1;
    }
}