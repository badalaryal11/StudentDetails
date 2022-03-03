namespace StudentDetails
{
    partial class FrmStudents
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
            this.gridStudents = new System.Windows.Forms.DataGridView();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuRegister = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vIEWToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROLLNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NATIONALITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FATHERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTHERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtboxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.mnuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbSort = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).BeginInit();
            this.mnuRegister.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridStudents
            // 
            this.gridStudents.AllowDrop = true;
            this.gridStudents.AllowUserToDeleteRows = false;
            this.gridStudents.AllowUserToResizeRows = false;
            this.gridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAME,
            this.ADDRESS,
            this.GENDER,
            this.CLASS,
            this.ROLLNO,
            this.STATUS,
            this.PHONE,
            this.NATIONALITY,
            this.FATHERNAME,
            this.MOTHERNAME,
            this.DESCRIPTION});
            this.gridStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStudents.Location = new System.Drawing.Point(0, 27);
            this.gridStudents.MultiSelect = false;
            this.gridStudents.Name = "gridStudents";
            this.gridStudents.ReadOnly = true;
            this.gridStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridStudents.RowTemplate.Height = 25;
            this.gridStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStudents.Size = new System.Drawing.Size(1029, 448);
            this.gridStudents.TabIndex = 1;
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "Name";
            this.NAME.HeaderText = "NAME";
            this.NAME.MinimumWidth = 150;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Width = 150;
            // 
            // ADDRESS
            // 
            this.ADDRESS.DataPropertyName = "Address";
            this.ADDRESS.HeaderText = "ADDRESS";
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.ReadOnly = true;
            // 
            // GENDER
            // 
            this.GENDER.ContextMenuStrip = this.mnuRegister;
            this.GENDER.DataPropertyName = "Gender";
            this.GENDER.HeaderText = "GENDER";
            this.GENDER.Name = "GENDER";
            this.GENDER.ReadOnly = true;
            // 
            // mnuRegister
            // 
            this.mnuRegister.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vIEWToolStripMenuItem1});
            this.mnuRegister.Name = "contextMenuStrip1";
            this.mnuRegister.Size = new System.Drawing.Size(102, 26);
            // 
            // vIEWToolStripMenuItem1
            // 
            this.vIEWToolStripMenuItem1.Name = "vIEWToolStripMenuItem1";
            this.vIEWToolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.vIEWToolStripMenuItem1.Text = "VIEW";
            // 
            // CLASS
            // 
            this.CLASS.ContextMenuStrip = this.mnuRegister;
            this.CLASS.DataPropertyName = "Class";
            this.CLASS.HeaderText = "CLASS";
            this.CLASS.Name = "CLASS";
            this.CLASS.ReadOnly = true;
            // 
            // ROLLNO
            // 
            this.ROLLNO.DataPropertyName = "RollNo";
            this.ROLLNO.HeaderText = "ROLL NO.";
            this.ROLLNO.Name = "ROLLNO";
            this.ROLLNO.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "Status";
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // PHONE
            // 
            this.PHONE.DataPropertyName = "Phone";
            this.PHONE.HeaderText = "PHONE";
            this.PHONE.Name = "PHONE";
            this.PHONE.ReadOnly = true;
            // 
            // NATIONALITY
            // 
            this.NATIONALITY.DataPropertyName = "Nationality";
            this.NATIONALITY.HeaderText = "NATIONALITY";
            this.NATIONALITY.Name = "NATIONALITY";
            this.NATIONALITY.ReadOnly = true;
            // 
            // FATHERNAME
            // 
            this.FATHERNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FATHERNAME.DataPropertyName = "FatherName";
            this.FATHERNAME.HeaderText = "FATHER NAME";
            this.FATHERNAME.Name = "FATHERNAME";
            this.FATHERNAME.ReadOnly = true;
            // 
            // MOTHERNAME
            // 
            this.MOTHERNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MOTHERNAME.DataPropertyName = "MotherName";
            this.MOTHERNAME.HeaderText = "MOTHER NAME";
            this.MOTHERNAME.Name = "MOTHERNAME";
            this.MOTHERNAME.ReadOnly = true;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCRIPTION.DataPropertyName = "Description";
            this.DESCRIPTION.HeaderText = "DESCRIPTION";
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.ReadOnly = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vIEWToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(102, 26);
            // 
            // vIEWToolStripMenuItem
            // 
            this.vIEWToolStripMenuItem.Name = "vIEWToolStripMenuItem";
            this.vIEWToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.vIEWToolStripMenuItem.Text = "VIEW";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPENToolStripMenuItem,
            this.sAVEToolStripMenuItem,
            this.sAVEASToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 23);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // oPENToolStripMenuItem
            // 
            this.oPENToolStripMenuItem.Name = "oPENToolStripMenuItem";
            this.oPENToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.oPENToolStripMenuItem.Text = "OPEN";
            // 
            // sAVEToolStripMenuItem
            // 
            this.sAVEToolStripMenuItem.Name = "sAVEToolStripMenuItem";
            this.sAVEToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.sAVEToolStripMenuItem.Text = "SAVE";
            // 
            // sAVEASToolStripMenuItem
            // 
            this.sAVEASToolStripMenuItem.Name = "sAVEASToolStripMenuItem";
            this.sAVEASToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.sAVEASToolStripMenuItem.Text = "SAVE AS";
            // 
            // vIEWToolStripMenuItem2
            // 
            this.vIEWToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuUpdate});
            this.vIEWToolStripMenuItem2.Name = "vIEWToolStripMenuItem2";
            this.vIEWToolStripMenuItem2.Size = new System.Drawing.Size(42, 23);
            this.vIEWToolStripMenuItem2.Text = "EDIT";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(116, 22);
            this.mnuNew.Text = "NEW";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.Size = new System.Drawing.Size(116, 22);
            this.mnuUpdate.Text = "UPDATE";
            this.mnuUpdate.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // vIEWToolStripMenuItem3
            // 
            this.vIEWToolStripMenuItem3.Name = "vIEWToolStripMenuItem3";
            this.vIEWToolStripMenuItem3.Size = new System.Drawing.Size(46, 23);
            this.vIEWToolStripMenuItem3.Text = "VIEW";
            this.vIEWToolStripMenuItem3.Click += new System.EventHandler(this.vIEWToolStripMenuItem3_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 23);
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.AcceptsReturn = true;
            this.txtboxSearch.AcceptsTab = true;
            this.txtboxSearch.AutoToolTip = true;
            this.txtboxSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(100, 23);
            // 
            // mnuSearch
            // 
            this.mnuSearch.Name = "mnuSearch";
            this.mnuSearch.Size = new System.Drawing.Size(54, 23);
            this.mnuSearch.Text = "Search";
            this.mnuSearch.Click += new System.EventHandler(this.mnuSearch_Click);
            // 
            // cmbSort
            // 
            this.cmbSort.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbSort.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbSort.Items.AddRange(new object[] {
            "NAME",
            "ADDRESS",
            "CLASS",
            "ROLLNO",
            "NATIONALITY"});
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(121, 23);
            this.cmbSort.Text = "Sort by";
            this.cmbSort.Click += new System.EventHandler(this.cmbSort_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.vIEWToolStripMenuItem2,
            this.vIEWToolStripMenuItem3,
            this.toolStripMenuItem1,
            this.txtboxSearch,
            this.mnuSearch,
            this.cmbSort});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 475);
            this.Controls.Add(this.gridStudents);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).EndInit();
            this.mnuRegister.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gridStudents;
        private ContextMenuStrip mnuRegister;
        private ToolStripMenuItem vIEWToolStripMenuItem1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem vIEWToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip3;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn ADDRESS;
        private DataGridViewTextBoxColumn GENDER;
        private DataGridViewTextBoxColumn CLASS;
        private DataGridViewTextBoxColumn ROLLNO;
        private DataGridViewTextBoxColumn STATUS;
        private DataGridViewTextBoxColumn PHONE;
        private DataGridViewTextBoxColumn NATIONALITY;
        private DataGridViewTextBoxColumn FATHERNAME;
        private DataGridViewTextBoxColumn MOTHERNAME;
        private DataGridViewTextBoxColumn DESCRIPTION;
        private ToolStripMenuItem fILEToolStripMenuItem;
        private ToolStripMenuItem oPENToolStripMenuItem;
        private ToolStripMenuItem sAVEToolStripMenuItem;
        private ToolStripMenuItem sAVEASToolStripMenuItem;
        private ToolStripMenuItem vIEWToolStripMenuItem2;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem mnuUpdate;
        private ToolStripMenuItem vIEWToolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripTextBox txtboxSearch;
        private ToolStripMenuItem mnuSearch;
        private ToolStripComboBox cmbSort;
        private MenuStrip menuStrip1;
    }
}