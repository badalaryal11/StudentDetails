using System.Data.SQLite;

namespace StudentDetails
{
    public partial class FrmStudentEntry : Form
    {
        private readonly int _idToUpdate;
        public bool DataSavedSuccess { get; private set; }

        public FrmStudentEntry(int idToUpdate = 0)
        {
            InitializeComponent();
            _idToUpdate = idToUpdate;
        }


        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                //               MessageBox.Show("Enter student name");
                errorProvider1.SetError(txtName, "Enter student name");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                //MessageBox.Show("Enter student Address");
                errorProvider1.SetError(txtAddress, "Enter student Address");
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbGender.Text))
            {
                //MessageBox.Show("Enter student Gender");
                errorProvider1.SetError(cmbGender, "Enter student Gender");

                return;
            }
              if (string.IsNullOrWhiteSpace(txtclass.Text))
            {
                //MessageBox.Show("Enter student class");
                errorProvider1.SetError(txtclass, "Enter student Class");
                return;
            }
              if (string.IsNullOrWhiteSpace(txtRollNo.Text))
            {
                //MessageBox.Show("Enter student Roll no.");
                errorProvider1.SetError(txtRollNo, "Enter student RollNo");
                return;
            }
             if (string.IsNullOrWhiteSpace(txtStatus.Text))
            {
                //MessageBox.Show("Enter student Status");
                errorProvider1.SetError(txtStatus, "Enter student status");
                return;
            }
             if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                //MessageBox.Show("Enter student phone");
                errorProvider1.SetError(txtPhone, "Enter student Phone");
                return;
            }

             if (string.IsNullOrWhiteSpace(txtNationality.Text))
            {
                //MessageBox.Show("Enter student Nationality");
                errorProvider1.SetError(txtNationality, "Enter student Phone");
                return;
            }
             if (string.IsNullOrWhiteSpace(txtMother.Text))
            {
                // MessageBox.Show("Enter student Mother's name");
                errorProvider1.SetError(txtMother, "Enter student's MotherName");
                return;
            }
             if (string.IsNullOrWhiteSpace(txtFather.Text))
            {
                // MessageBox.Show("Enter student Father's Name");
                errorProvider1.SetError(txtFather, "Enter student's FatherName");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                //MessageBox.Show("Enter student Description");
                errorProvider1.SetError(txtDescription, "Enter student's Description");
                return;
            }

            var isInteger = int.TryParse(txtRollNo.Text.Trim(), out var intValue);
            if (isInteger == false)
            {
                MessageBox.Show("Invalid roll number");
                return;
            }
            else
            {
                // true
                var rollNo = intValue;
            }
            
            var student = new StudentDto
            {
                Name = txtName.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Gender = cmbGender.Text.Trim(),
                Class = txtclass.Text.Trim(),
                RollNo = intValue,
                Status = txtStatus.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Nationality = txtNationality.Text.Trim(),
                MotherName = txtMother.Text.Trim(),
                FatherName = txtFather.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Id = _idToUpdate
            };


            var handler = new StudentHandler();
            var result = _idToUpdate <= 0 ? await handler.InsertAsync(student) : await handler.UpdateAsync(student); 

            if (!result.Success)
            {
                MessageBox.Show(result.ErrorMessage);
                return;
            }

            DataSavedSuccess = true;
            MessageBox.Show("Saved Successfully");
        }


        private async void FrmStudentEntry_Load(object sender, EventArgs e)
        {
            if (_idToUpdate == 0) return;



            var handler = new StudentHandler();
            var result = await handler.GetStudentAsync(_idToUpdate);
            if (!result.Success)
            {
                MessageBox.Show("Unable to load selected student detail.");
                Close();
                return;
            }

            // populate student detail here
            txtName.Text = result.Dto.Name;
            txtAddress.Text = result.Dto.Address;
            cmbGender.SelectedItem = result.Dto.Gender;
            txtclass.Text = result.Dto.Class;
            txtRollNo.Text = result.Dto.RollNo.ToString();
            txtStatus.SelectedItem = result.Dto.Status;
            txtPhone.Text = result.Dto.Phone;
            txtNationality.SelectedItem = result.Dto.Nationality;
            txtMother.Text = result.Dto.MotherName;
            txtFather.Text = result.Dto.FatherName;
            txtDescription.Text = result.Dto.Description;
        }




        public class StudentInfo
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }

            public string Gender { get; set; }
            public string Class { get; set; }
            public int RollNo { get; set; }
            public string Status { get; set; }

            public string Phone { get; set; }
            public string Nationality { get; set; }
            public string MotherName { get; set; }
            public string FatherName { get; set; }
            public string Description { get; set; }

        }
    }
}

