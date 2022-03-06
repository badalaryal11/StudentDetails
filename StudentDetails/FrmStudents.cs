using System.Data.SQLite;
using static StudentDetails.FrmStudentEntry;

namespace StudentDetails
{
    public partial class FrmStudents : Form
    {
        public FrmStudents()
        {
            InitializeComponent();
            gridStudents.AutoGenerateColumns = false;

            cmbSort.ComboBox.SelectionChangeCommitted += ComboBox_SelectionChangeCommitted; // selection Control API
        }

        private async void ComboBox_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            gridStudents.DataSource = null;
            var studentsList = new List<Student>();
            var keyword = cmbSort.SelectedItem.ToString().Trim();

            try
            {
                using var conn = new SQLiteConnection(@"Data Source=Students.db;Version=3");
                await conn.OpenAsync();
                var cmd = new SQLiteCommand($@"SELECT * FROM Student ORDER BY {keyword} ", conn);



                var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    //gridStudents.DataSource = null;
                    studentsList.Add(new Student
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
                    });
                }


                //code executes after loop
                gridStudents.DataSource = studentsList; // displays datas from list in a datagrid view.
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

        private async Task LoadDataAsync()
        {

            var dictionary = new Dictionary<int, string>();


            try
            {
                using var conn = new SQLiteConnection(@"Data Source=Students.db;Version=3");
                await conn.OpenAsync();

                var cmd = new SQLiteCommand(@"SELECT * FROM Student", conn)
                {
                    CommandType = System.Data.CommandType.Text
                };

                var reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    dictionary.Add(Convert.ToInt32(reader["Id"]), (string)reader["Name"]);


                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }






        }


        private void mnuNew_Click(object sender, EventArgs e)
        {
            var form = new FrmStudentEntry();
            form.ShowDialog();
        }

        private async void vIEWToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            gridStudents.DataSource = null;
            var studentsList = new List<StudentInfo>();// list is initialized

            try


            {
                using var conn = new SQLiteConnection(@"Data Source=Students.db;Version=3");
                await conn.OpenAsync();
                var cmd = new SQLiteCommand("SELECT * FROM Student", conn);
                var reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    studentsList.Add(new StudentInfo
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


                    });




                }

                gridStudents.DataSource = studentsList;


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







        private async void mnuSearch_Click(object sender, EventArgs e) // MENU TO SEARCH

        {
            gridStudents.DataSource = null;
            var studentsList = new List<Student>();
            var keyword = txtboxSearch.Text.Trim();

            try
            {
                using var conn = new SQLiteConnection(@"Data Source=Students.db;Version=3");
                await conn.OpenAsync();
                var cmd = new SQLiteCommand($@"SELECT * FROM Student WHERE Name LIKE '%{keyword}%' ", conn);



                var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {

                    studentsList.Add(new Student
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
                    });



                }
                //code executes after loop
                gridStudents.DataSource = studentsList; // displays datas from list in a datagrid view.
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

        private void cmbSort_Click(object sender, EventArgs e)
        {


        }

        //private  async void rowUpdate_Click(object sender, DataGridViewCellEventArgs e)
        //{
        //    return;
        //    var form = new FrmStudentEntry();
        //    form.ShowDialog();

        //    gridStudents.DataSource = null;
        //    var studentsList = new List<Student>();


        //    try
        //    {
        //        using var conn = new SQLiteConnection(@"Data Source=Students.db;Version=3");
        //        await conn.OpenAsync();
        //        var cmd = new SQLiteCommand($@"UPDATE Student SET  Name=?, Address= ?,Gender= ?,RollNo = ?,Class = ?, Status=  ", conn);



        //        var reader = await cmd.ExecuteReaderAsync();
        //        while (await reader.ReadAsync())
        //        {

        //            studentsList.Add(new Student
        //            {
        //                Id = Convert.ToInt32(reader["Id"]),
        //                Name = reader["Name"].ToString(),
        //                Address = reader["Address"].ToString(),
        //                Gender = reader["Gender"]?.ToString() ?? "Not Defined",
        //                Class = reader["Class"].ToString(),
        //                RollNo = Convert.ToInt32(reader["RollNo"]),
        //                Status = reader["Status"].ToString(),
        //                Phone = reader["Phone"].ToString(),
        //                Nationality = reader["Nationality"].ToString(),
        //                MotherName = reader["MotherName"].ToString(),
        //                FatherName = reader["FatherName"].ToString(),
        //                Description = reader["Description"].ToString()
        //            });



        //        }
        //        //code executes after loop
        //        gridStudents.DataSource = studentsList; // displays datas from list in a datagrid view.
        //    }


        //    catch (SQLiteException exec)
        //    {
        //        MessageBox.Show(exec.Message);
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);



        //    }

        //}

        private void gridStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridStudents.SelectedRows.Count == 0) return;

            var selectedStudent = (StudentInfo)gridStudents.SelectedRows[0].DataBoundItem;

            //MessageBox.Show(selectedStudent.Name + " - " + selectedStudent.Id);

            var form = new FrmStudentEntry(selectedStudent.Id);
            // form.selectedStudent.Id;
            form.ShowDialog();
            // if()

            if (form.DataSavedSuccess)
            {



            }

        }

        private async void mnuDelete_Click(object sender, EventArgs e)
        {
            if (gridStudents.CurrentRow == null)
            {
                MessageBox.Show("No student selected.");
                return;
            }

            var selectedStudent = (StudentInfo)gridStudents.SelectedRows[0].DataBoundItem;
            var result = MessageBox.Show(@$"Do you want to delete student '{selectedStudent.Name}' of class {selectedStudent.Class}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;
            {



                try
                {
                    using var conn = new SQLiteConnection(@"Data Source=Students.db;Version=3");
                    await conn.OpenAsync();
                    var cmd = new SQLiteCommand("Delete from student where id =@prId ", conn);
                    cmd.Parameters.Add(new SQLiteParameter("@prId", selectedStudent.Id));


                    var rowCount = await cmd.ExecuteNonQueryAsync();
                    MessageBox.Show("delete success");



                        
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
        }



        public abstract class StudentBase
        {
        }

        public class Student
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

            public Student(int id, string name, string address, string gender, string @class, int rollno,// intializing an object
                string status, string phone, string nation, string mother, string father, string describe)
            {
                Id = id;
                Name = name;
                Address = address;
                Gender = gender;
                Class = @class;
                RollNo = rollno;
                Status = status;
                Phone = phone;
                Nationality = nation;
                MotherName = mother;
                FatherName = father;
                Description = describe;
            }

            public Student()
            {

            }
            public Student(string name, string address)
            {
                Name = name;
                Address = address;



            }

        }
    }
}













