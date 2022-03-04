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


        private void btnRegister_Click(object sender, EventArgs e)
        {


            //FrmStudentEntry frm2 = new FrmStudentEntry();
            //gridStudents.Rows.Add()(txtName.Text,txtAddress.Text,txtGender.Text,txtclass.Text,txtRollNo.Text,)


            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Enter student name");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Enter student Address");
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbGender.Text))
            {
                MessageBox.Show("Enter student Gender");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtclass.Text))
            {
                MessageBox.Show("Enter student class");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtRollNo.Text))
            {
                MessageBox.Show("Enter student Roll no.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtStatus.Text))
            {
                MessageBox.Show("Enter student Status");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Enter student phone");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNationality.Text))
            {
                MessageBox.Show("Enter student Nationality");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMother.Text))
            {
                MessageBox.Show("Enter student Mother's name");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFather.Text))
            {
                MessageBox.Show("Enter student Father's Name");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Enter student Description");
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
            MessageBox.Show("You have sucessfully entered the information of a student.");






            var student = new StudentInfo// passing values to the object
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
                Description = txtDescription.Text.Trim()
            };



            try
            {
                using var conn = new SQLiteConnection(@"Data Source=Students.db;Version=3");
                conn.Open();


                var cmd = new SQLiteCommand(
                    $@"INSERT INTO Student (Name, Address,Gender,Class,RollNo,Status,Phone,Nationality,MotherName,FatherName,Description) 
                   VALUES (@prName, @prAddress, @prGender, @prClass, @prRoll, @prStatus, @prPhone, @prNationality,
                            @prMother, @prFather, @prDescription )", conn)
                {
                    CommandType = System.Data.CommandType.Text
                };


                cmd.Parameters.Add(new SQLiteParameter("@prName", student.Name));
                cmd.Parameters.Add(new SQLiteParameter("@prAddress", student.Address));
                cmd.Parameters.Add(new SQLiteParameter("@prGender", student.Gender));
                cmd.Parameters.Add(new SQLiteParameter("@prClass", student.Class));
                cmd.Parameters.Add(new SQLiteParameter("@prRoll", student.RollNo));
                cmd.Parameters.Add(new SQLiteParameter("@prStatus", student.Status));
                cmd.Parameters.Add(new SQLiteParameter("@prPhone", student.Phone));
                cmd.Parameters.Add(new SQLiteParameter("@prNationality", student.Nationality));
                cmd.Parameters.Add(new SQLiteParameter("@prMother", student.MotherName));
                cmd.Parameters.Add(new SQLiteParameter("@prFather", student.FatherName));
                cmd.Parameters.Add(new SQLiteParameter("@prDescription", student.Description));

                var rowsCount = cmd.ExecuteNonQuery();
                conn.Close();
                DataSavedSuccess = true;
            }
            catch (SQLiteException exec)
            {
                MessageBox.Show(exec.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private async void FrmStudentEntry_Load(object sender, EventArgs e)
        {
            if (_idToUpdate == 0) return;

            // form has been displayed in update mode


            Student student = null;


            try
            {
                using var conn = new SQLiteConnection(@"Data Source=Students.db;Version=3");
                await conn.OpenAsync();


                var cmd = new SQLiteCommand("SELECT * FROM  Student WHERE Id = @prId ", conn)
                {
                    CommandType = System.Data.CommandType.Text
                };


                cmd.Parameters.Add(new SQLiteParameter("@prId", _idToUpdate));


                var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    student = new Student
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Address = reader["Address"].ToString(),
                        Gender = reader["Gender"]?.ToString() ?? "Not Defined",
                        Class = reader["Class"].ToString(),
                        RollNo = Convert.ToInt32(reader["RollNo"]),
                        Status = reader["Status"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Nationality = reader["Nationality"].ToString(),
                        MotherName = reader["MotherName"].ToString(),
                        FatherName = reader["FatherName"].ToString(),
                        Description = reader["Description"].ToString()
                    };
                }

                if (student == null)
                {
                    MessageBox.Show("Unble to load selected student detail.");
                    Close();
                    return;
                }
            }
            catch (SQLiteException exec)
            {
                MessageBox.Show(exec.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            // populate student detail here
            txtName.Text = student.Name;
            txtAddress.Text = student.Address;
            cmbGender.SelectedItem = student.Gender;
            txtclass.Text = student.Class;
            txtRollNo.Text = student.RollNo.ToString();
            txtStatus.SelectedItem = student.Status;
            txtPhone.Text = student.Phone;
            txtNationality.SelectedItem = student.Nationality;
            txtMother.Text = student.MotherName;
            txtFather.Text = student.FatherName;
            txtDescription.Text = student.Description;

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

