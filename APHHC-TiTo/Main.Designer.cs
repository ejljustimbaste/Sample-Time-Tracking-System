namespace APHHC_TiTo
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnBreakIn = new System.Windows.Forms.Button();
            this.btnBreakOut = new System.Windows.Forms.Button();
            this.btnTimeOut = new System.Windows.Forms.Button();
            this.btnLunchOut = new System.Windows.Forms.Button();
            this.btnLunchIn = new System.Windows.Forms.Button();
            this.btnTimeIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.tblEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPHHCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPHHCDataSet = new APHHC_TiTo.APHHCDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tblEmployeesTableAdapter = new APHHC_TiTo.APHHCDataSetTableAdapters.tblEmployeesTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPHHCDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPHHCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.btnNewUser);
            this.groupBox1.Controls.Add(this.btnBreakIn);
            this.groupBox1.Controls.Add(this.btnBreakOut);
            this.groupBox1.Controls.Add(this.btnTimeOut);
            this.groupBox1.Controls.Add(this.btnLunchOut);
            this.groupBox1.Controls.Add(this.btnLunchIn);
            this.groupBox1.Controls.Add(this.btnTimeIn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbEmployees);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Location = new System.Drawing.Point(3, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 264);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnNewUser
            // 
            this.btnNewUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewUser.Location = new System.Drawing.Point(9, 16);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(83, 23);
            this.btnNewUser.TabIndex = 15;
            this.btnNewUser.Text = "REGISTER";
            this.btnNewUser.UseVisualStyleBackColor = false;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnBreakIn
            // 
            this.btnBreakIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBreakIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBreakIn.Enabled = false;
            this.btnBreakIn.Location = new System.Drawing.Point(513, 104);
            this.btnBreakIn.Name = "btnBreakIn";
            this.btnBreakIn.Size = new System.Drawing.Size(83, 23);
            this.btnBreakIn.TabIndex = 13;
            this.btnBreakIn.Text = "BREAK IN";
            this.btnBreakIn.UseVisualStyleBackColor = false;
            this.btnBreakIn.Click += new System.EventHandler(this.btnBreakIn_Click);
            // 
            // btnBreakOut
            // 
            this.btnBreakOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBreakOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBreakOut.Enabled = false;
            this.btnBreakOut.Location = new System.Drawing.Point(423, 104);
            this.btnBreakOut.Name = "btnBreakOut";
            this.btnBreakOut.Size = new System.Drawing.Size(84, 23);
            this.btnBreakOut.TabIndex = 12;
            this.btnBreakOut.Text = "BREAK OUT";
            this.btnBreakOut.UseVisualStyleBackColor = false;
            this.btnBreakOut.Click += new System.EventHandler(this.btnBreakOut_Click);
            // 
            // btnTimeOut
            // 
            this.btnTimeOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTimeOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeOut.Enabled = false;
            this.btnTimeOut.Location = new System.Drawing.Point(513, 45);
            this.btnTimeOut.Name = "btnTimeOut";
            this.btnTimeOut.Size = new System.Drawing.Size(81, 23);
            this.btnTimeOut.TabIndex = 11;
            this.btnTimeOut.Text = "TIME OUT";
            this.btnTimeOut.UseVisualStyleBackColor = false;
            this.btnTimeOut.Click += new System.EventHandler(this.btnTimeOut_Click);
            // 
            // btnLunchOut
            // 
            this.btnLunchOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLunchOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLunchOut.Enabled = false;
            this.btnLunchOut.Location = new System.Drawing.Point(423, 75);
            this.btnLunchOut.Name = "btnLunchOut";
            this.btnLunchOut.Size = new System.Drawing.Size(83, 23);
            this.btnLunchOut.TabIndex = 10;
            this.btnLunchOut.Text = "LUNCH OUT";
            this.btnLunchOut.UseVisualStyleBackColor = false;
            this.btnLunchOut.Click += new System.EventHandler(this.btnLunchOut_Click);
            // 
            // btnLunchIn
            // 
            this.btnLunchIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLunchIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLunchIn.Enabled = false;
            this.btnLunchIn.Location = new System.Drawing.Point(513, 75);
            this.btnLunchIn.Name = "btnLunchIn";
            this.btnLunchIn.Size = new System.Drawing.Size(83, 23);
            this.btnLunchIn.TabIndex = 9;
            this.btnLunchIn.Text = "LUNCH IN";
            this.btnLunchIn.UseVisualStyleBackColor = false;
            this.btnLunchIn.Click += new System.EventHandler(this.btnLunchIn_Click);
            // 
            // btnTimeIn
            // 
            this.btnTimeIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTimeIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeIn.Enabled = false;
            this.btnTimeIn.Location = new System.Drawing.Point(423, 45);
            this.btnTimeIn.Name = "btnTimeIn";
            this.btnTimeIn.Size = new System.Drawing.Size(84, 23);
            this.btnTimeIn.TabIndex = 8;
            this.btnTimeIn.Text = "TIME IN";
            this.btnTimeIn.UseVisualStyleBackColor = false;
            this.btnTimeIn.Click += new System.EventHandler(this.btnTimeIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employee";
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEmployees.DataSource = this.tblEmployeesBindingSource;
            this.cmbEmployees.DisplayMember = "EmployeeName";
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(423, 19);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(172, 21);
            this.cmbEmployees.TabIndex = 6;
            this.cmbEmployees.ValueMember = "EmployeeName";
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.cmbEmployees_SelectedIndexChanged);
            // 
            // tblEmployeesBindingSource
            // 
            this.tblEmployeesBindingSource.DataMember = "tblEmployees";
            this.tblEmployeesBindingSource.DataSource = this.aPHHCDataSetBindingSource;
            // 
            // aPHHCDataSetBindingSource
            // 
            this.aPHHCDataSetBindingSource.DataSource = this.aPHHCDataSet;
            this.aPHHCDataSetBindingSource.Position = 0;
            // 
            // aPHHCDataSet
            // 
            this.aPHHCDataSet.DataSetName = "APHHCDataSet";
            this.aPHHCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::APHHC_TiTo.Properties.Resources.AmericanPremier;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(9, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 299);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // tblEmployeesTableAdapter
            // 
            this.tblEmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(627, 261);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPHHCDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPHHCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimeOut;
        private System.Windows.Forms.Button btnLunchIn;
        private System.Windows.Forms.Button btnTimeIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.Button btnLunchOut;
        private System.Windows.Forms.Button btnBreakIn;
        private System.Windows.Forms.Button btnBreakOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.BindingSource aPHHCDataSetBindingSource;
        private APHHCDataSet aPHHCDataSet;
        private System.Windows.Forms.BindingSource tblEmployeesBindingSource;
        private APHHCDataSetTableAdapters.tblEmployeesTableAdapter tblEmployeesTableAdapter;
    }
}

