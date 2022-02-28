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
            this.mnuRegister = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vIEWToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortDesc = new System.Windows.Forms.ToolStripMenuItem();
            this.sortAsc = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROLLNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NATIONALITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FATHERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTHERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).BeginInit();
            this.mnuRegister.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridStudents
            // 
            this.gridStudents.AllowUserToAddRows = false;
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
            this.gridStudents.RowTemplate.Height = 25;
            this.gridStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStudents.Size = new System.Drawing.Size(1029, 448);
            this.gridStudents.TabIndex = 0;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.vIEWToolStripMenuItem2,
            this.vIEWToolStripMenuItem3,
            this.toolStripMenuItem1,
            this.txtboxSearch,
            this.mnuSearch,
            this.sortToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
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
            this.txtboxSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.ReadOnly = true;
            this.txtboxSearch.Size = new System.Drawing.Size(100, 23);
            
            // 
            // mnuSearch
            // 
            this.mnuSearch.Name = "mnuSearch";
            this.mnuSearch.Size = new System.Drawing.Size(54, 23);
            this.mnuSearch.Text = "Search";
            //this.mnuSearch.Click += new System.EventHandler(this.mnuSearch_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortDesc,
            this.sortAsc});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(40, 23);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // sortDesc
            // 
            this.sortDesc.Name = "sortDesc";
            this.sortDesc.Size = new System.Drawing.Size(67, 22);
            // 
            // sortAsc
            // 
            this.sortAsc.Name = "sortAsc";
            this.sortAsc.Size = new System.Drawing.Size(67, 22);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "Name";
            this.NAME.Frozen = true;
            this.NAME.HeaderText = "NAME";
            this.NAME.MinimumWidth = 150;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Width = 150;
            // 
            // ADDRESS
            // 
            this.ADDRESS.DataPropertyName = "Address";
            this.ADDRESS.Frozen = true;
            this.ADDRESS.HeaderText = "ADDRESS";
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.ReadOnly = true;
            // 
            // GENDER
            // 
            this.GENDER.ContextMenuStrip = this.mnuRegister;
            this.GENDER.DataPropertyName = "Gender";
            this.GENDER.Frozen = true;
            this.GENDER.HeaderText = "GENDER";
            this.GENDER.Name = "GENDER";
            this.GENDER.ReadOnly = true;
            // 
            // CLASS
            // 
            this.CLASS.ContextMenuStrip = this.mnuRegister;
            this.CLASS.DataPropertyName = "Class";
            this.CLASS.Frozen = true;
            this.CLASS.HeaderText = "CLASS";
            this.CLASS.Name = "CLASS";
            this.CLASS.ReadOnly = true;
            // 
            // ROLLNO
            // 
            this.ROLLNO.DataPropertyName = "RollNo";
            this.ROLLNO.Frozen = true;
            this.ROLLNO.HeaderText = "ROLLNO.";
            this.ROLLNO.Name = "ROLLNO";
            this.ROLLNO.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "Status";
            this.STATUS.Frozen = true;
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // PHONE
            // 
            this.PHONE.DataPropertyName = "Phone";
            this.PHONE.Frozen = true;
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem vIEWToolStripMenuItem2;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem vIEWToolStripMenuItem3;
        private ToolStripMenuItem fILEToolStripMenuItem;
        private ToolStripMenuItem oPENToolStripMenuItem;
        private ToolStripMenuItem sAVEToolStripMenuItem;
        private ToolStripMenuItem sAVEASToolStripMenuItem;
        private ToolStripMenuItem mnuUpdate;
       
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripTextBox txtboxSearch;
        private ToolStripMenuItem mnuSearch;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem sortToolStripMenuItem;
        private ToolStripMenuItem sortDesc;
        private ToolStripMenuItem sortAsc;
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
    }
}