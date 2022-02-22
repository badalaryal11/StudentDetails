namespace StudentDetails
{
    public partial class FrmStudentEntry : Form
    {
        public FrmStudentEntry()
        {
            InitializeComponent();
        }

        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //FrmStudents f2 = new FrmStudents();
            //f2.ShowDialog();

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Enter student details");
                return;
            }

            var student = new Student
            {
                Name = txtName.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Gender = txtGender.Text.Trim(),
                Class = txtclass.Text.Trim(),
                RollNo = txtRollNo.Text.Trim(),
                Status = txtStatus.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Nationality = txtNationality.Text.Trim(),
               MotherName =txtMother.Text.Trim(),
                FatherName=txtFather.Text.Trim(),
                Description=txtDescription.Text.Trim()
                
            };


            
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string Gender { get; set; }
        public string Class { get; set; }
        public string RollNo { get; set; }
        public string Status { get; set; }

        public string Phone { get; set; }
        public string Nationality { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public string Description { get; set; }

    }
}