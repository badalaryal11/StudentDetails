namespace StudentDetails
{
    partial class FrmStudentEntry
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtNationality = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.txtFather = new System.Windows.Forms.TextBox();
            this.txtMother = new System.Windows.Forms.TextBox();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.txtNationality);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtclass);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.txtGender);
            this.groupBox1.Controls.Add(this.txtFather);
            this.groupBox1.Controls.Add(this.txtMother);
            this.groupBox1.Controls.Add(this.txtRollNo);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(104, 342);
            this.txtDescription.MaxLength = 250;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(535, 96);
            this.txtDescription.TabIndex = 21;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(684, 415);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 22;
            this.btnRegister.Text = "SUBMIT";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            this.btnRegister.MouseCaptureChanged += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtNationality
            // 
            this.txtNationality.FormattingEnabled = true;
            this.txtNationality.Items.AddRange(new object[] {
            "NEPALI",
            "FOREIGN"});
            this.txtNationality.Location = new System.Drawing.Point(496, 213);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(143, 23);
            this.txtNationality.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(412, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "NATIONALITY";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(104, 213);
            this.txtPhone.MaxLength = 16;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(185, 23);
            this.txtPhone.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "PHONE";
            // 
            // txtclass
            // 
            this.txtclass.Location = new System.Drawing.Point(496, 134);
            this.txtclass.MaxLength = 10;
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(143, 23);
            this.txtclass.TabIndex = 14;
            // 
            // txtStatus
            // 
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "CURRENT",
            "PASSED OUT"});
            this.txtStatus.Location = new System.Drawing.Point(496, 175);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(143, 23);
            this.txtStatus.TabIndex = 16;
            // 
            // txtGender
            // 
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "OTHERS"});
            this.txtGender.Location = new System.Drawing.Point(104, 131);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(185, 23);
            this.txtGender.TabIndex = 13;
            // 
            // txtFather
            // 
            this.txtFather.Location = new System.Drawing.Point(104, 297);
            this.txtFather.MaxLength = 250;
            this.txtFather.Name = "txtFather";
            this.txtFather.Size = new System.Drawing.Size(535, 23);
            this.txtFather.TabIndex = 20;
            // 
            // txtMother
            // 
            this.txtMother.Location = new System.Drawing.Point(104, 253);
            this.txtMother.MaxLength = 250;
            this.txtMother.Name = "txtMother";
            this.txtMother.Size = new System.Drawing.Size(535, 23);
            this.txtMother.TabIndex = 19;
            // 
            // txtRollNo
            // 
            this.txtRollNo.Location = new System.Drawing.Point(104, 170);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(185, 23);
            this.txtRollNo.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(104, 85);
            this.txtAddress.MaxLength = 250;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(535, 23);
            this.txtAddress.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.AcceptsTab = true;
            this.txtName.Location = new System.Drawing.Point(104, 36);
            this.txtName.MaxLength = 250;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(535, 23);
            this.txtName.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "STATUS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "DESCRIPTION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(670, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 104);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "MOTHER NAME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "CLASS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "ROLL NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "GENDER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "ADDRESS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "FATHER NAME";
            // 
            // FrmStudentEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmStudentEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STUDENT DETAILS";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox txtclass;
        private ComboBox txtStatus;
        private ComboBox txtGender;
        private TextBox txtFather;
        private TextBox txtMother;
        private TextBox txtRollNo;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label label9;
        private ComboBox txtNationality;
        private Label label11;
        private TextBox txtPhone;
        private Label label10;
        private Button btnRegister;
        private TextBox txtDescription;
    }
}