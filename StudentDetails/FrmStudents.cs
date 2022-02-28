using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDetails
{
    public partial class FrmStudents : Form
    {
        public FrmStudents()
        {
            InitializeComponent();
            gridStudents.AutoGenerateColumns = false;
        }


        //private async Task LoadDataAsync()
        //{

        //    var dictionary = new Dictionary<int, string>();


        //    try
        //    {
        //        using var conn = new SQLiteConnection(@"Data Source=Students.db;Version=3");
        //        await conn.OpenAsync();

        //        var cmd = new SQLiteCommand(@"SELECT * FROM Student", conn)
        //        {
        //            CommandType = System.Data.CommandType.Text
        //        };

        //        var reader = await cmd.ExecuteReaderAsync();

        //        while (await reader.ReadAsync())
        //        {
        //            dictionary.Add(Convert.ToInt32(reader["Id"]), (string)reader["Name"]);


        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        





        //}


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
                        
                       Id = Convert.ToInt32(reader["Id"].ToString()),
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
                    }) ;

                    gridStudents.DataSource = studentsList;


                }

            }
        



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);



            }
        }






        //private async void mnuSearch_Click(object sender, EventArgs e) // MENU TO SEARCH

        //{
        //    gridStudents.DataSource = null;
        //    var studentsList = new List<Student>();

        //    try
        //    {
        //        using var conn = new SQLiteConnection(@"Data Source=Students.db;Version=3");
        //        await conn.OpenAsync();
        //        var cmd = new SQLiteCommand("SELECT * FROM Student WHERE Name LIKE '%txtboxSearch.Text%' ", conn);



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

        //            gridStudents.DataSource = studentsList;
                   
        //        }

               
        //    }




        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);



        //   }

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

            public Student(int id, string name, string address, string gender, string @class, int rollno,
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

       
    



    



