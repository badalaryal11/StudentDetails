using System.Data.SQLite;

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
           
            
          

            if(string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Enter student name");
                return;
            }
           else if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Enter student Address");
                return;
            }
           else if (string.IsNullOrWhiteSpace(txtGender.Text))
            {
                MessageBox.Show("Enter student Gender");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtclass.Text))
            {
                MessageBox.Show("Enter student class");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtRollNo.Text))
            {
                MessageBox.Show("Enter student Roll no.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtStatus.Text))
            {
                MessageBox.Show("Enter student Status");
                return;
            }
           else if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Enter student phone");
                return;
            }

           else if (string.IsNullOrWhiteSpace(txtNationality.Text))
            {
                MessageBox.Show("Enter student Nationality");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtMother.Text))
            {
                MessageBox.Show("Enter student Mother's name");
                return;
            }
           else if (string.IsNullOrWhiteSpace(txtFather.Text))
            {
                MessageBox.Show("Enter student Father's Name");
                return;
            }
           else if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Enter student Description");
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
                MotherName = txtMother.Text.Trim(),
                FatherName = txtFather.Text.Trim(),
                Description = txtDescription.Text.Trim()
            };


            using var conn = new SQLiteConnection(@"Data Source=Students.db;Version=3");
            conn.Open();

            var cmd = new SQLiteCommand($@"INSERT INTO Student (Name, Address,Gender,Class,RollNo.,Status,Phone,Nationality,MotherName,FatherName,Description) 
            VALUES ('{student.Name}','{student.Address}',{student.Gender},{student.Class},{student.RollNo},{student.Status},{student.Phone},
            {student.Nationality},{student.MotherName},{student.FatherName},{student.Description})", conn)
            {
                CommandType = System.Data.CommandType.Text
            };

            var rowsCount = cmd.ExecuteNonQuery();
            conn.Close();
        }
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