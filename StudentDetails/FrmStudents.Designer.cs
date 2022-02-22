﻿namespace StudentDetails
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
            this.CLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROLLNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NATIONALITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FATHERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTHERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.vIEWToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.gridStudents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridStudents.Location = new System.Drawing.Point(0, 28);
            this.gridStudents.MultiSelect = false;
            this.gridStudents.Name = "gridStudents";
            this.gridStudents.ReadOnly = true;
            this.gridStudents.RowTemplate.Height = 25;
            this.gridStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStudents.Size = new System.Drawing.Size(800, 422);
            this.gridStudents.TabIndex = 0;
            this.gridStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NAME
            // 
            this.NAME.Frozen = true;
            this.NAME.HeaderText = "NAME";
            this.NAME.MinimumWidth = 150;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Width = 150;
            // 
            // ADDRESS
            // 
            this.ADDRESS.Frozen = true;
            this.ADDRESS.HeaderText = "ADDRESS";
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.ReadOnly = true;
            // 
            // GENDER
            // 
            this.GENDER.Frozen = true;
            this.GENDER.HeaderText = "GENDER";
            this.GENDER.Name = "GENDER";
            this.GENDER.ReadOnly = true;
            // 
            // CLASS
            // 
            this.CLASS.Frozen = true;
            this.CLASS.HeaderText = "CLASS";
            this.CLASS.Name = "CLASS";
            this.CLASS.ReadOnly = true;
            // 
            // ROLLNO
            // 
            this.ROLLNO.Frozen = true;
            this.ROLLNO.HeaderText = "ROLLNO.";
            this.ROLLNO.Name = "ROLLNO";
            this.ROLLNO.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.Frozen = true;
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // PHONE
            // 
            this.PHONE.Frozen = true;
            this.PHONE.HeaderText = "PHONE";
            this.PHONE.Name = "PHONE";
            this.PHONE.ReadOnly = true;
            // 
            // NATIONALITY
            // 
            this.NATIONALITY.Frozen = true;
            this.NATIONALITY.HeaderText = "NATIONALITY";
            this.NATIONALITY.Name = "NATIONALITY";
            this.NATIONALITY.ReadOnly = true;
            // 
            // FATHERNAME
            // 
            this.FATHERNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FATHERNAME.HeaderText = "FATHER NAME";
            this.FATHERNAME.Name = "FATHERNAME";
            this.FATHERNAME.ReadOnly = true;
            // 
            // MOTHERNAME
            // 
            this.MOTHERNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MOTHERNAME.HeaderText = "MOTHER NAME";
            this.MOTHERNAME.Name = "MOTHERNAME";
            this.MOTHERNAME.ReadOnly = true;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCRIPTION.HeaderText = "DESCRIPTION";
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.ReadOnly = true;
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
            this.vIEWToolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
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
            this.mnuNew});
            this.vIEWToolStripMenuItem2.Name = "vIEWToolStripMenuItem2";
            this.vIEWToolStripMenuItem2.Size = new System.Drawing.Size(42, 20);
            this.vIEWToolStripMenuItem2.Text = "EDIT";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(100, 22);
            this.mnuNew.Text = "NEW";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // vIEWToolStripMenuItem3
            // 
            this.vIEWToolStripMenuItem3.Name = "vIEWToolStripMenuItem3";
            this.vIEWToolStripMenuItem3.Size = new System.Drawing.Size(46, 20);
            this.vIEWToolStripMenuItem3.Text = "VIEW";
            this.vIEWToolStripMenuItem3.Click += new System.EventHandler(this.vIEWToolStripMenuItem3_Click);
            // 
            // FrmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gridStudents);
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