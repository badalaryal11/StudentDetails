﻿using System;
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
        }

        private async Task LoadDataAsync()
        {

            /*  var dictionary = new Dictionary<int, string>();

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
                        dictionary.Add(Convert.ToInt32(reader["Id"]), (string)reader["Name"],(string)reader["Address"],
                           (string)reader["Gender"],reader["Class"],reader["Roll No."],(string)reader["Status"],reader["Phone"],
                            (string)reader["Nationality"], (string)reader["MotherName"], (string)reader["FatherName"], (string)reader["Description"]);
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            */
        }


        private void mnuNew_Click(object sender, EventArgs e)
        {
            var form = new FrmStudentEntry();
            form.ShowDialog();
        }
        private async void vIEWToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            gridStudents.AutoGenerateColumns = false;
            var studentList = new List<Student>();

            studentList.Add(new Student
            {
                Id = 1,
                Name = "Rabi",
                Address = "Jnk",
                Gender = "Male",
                Class = "12",
                RollNo = 124,
                Status = "Passed out",
                Phone = "1234567890",
                Nationality = "Nepali",
                MotherName = "Sita",
                FatherName = "Ram",
                Description = " He is a good boy "
            });


            studentList.Add(new Student
            {
                Id = 2,
                Name = "Badal",
                Address = "Ktm",
                Gender = "Male",
                Class = "10",
                RollNo = 125,
                Status = "Passed out",
                Phone = "09876",
                Nationality = "Nepali",
                MotherName = "Sita",
                FatherName = "Ram",
                Description = " He is a good boy "
            });

            studentList.AddRange(new List<Student>
            {
                new Student
                {
                    Id = 3,
                    Name = "Ram",
                    Address = "Ktm",
                    Gender = "Male",
                    Class = "11",
                    RollNo = 125,
                    Status = "Passed out",
                    Phone = "0987698578",
                    Nationality = "Foreign",
                    MotherName = "Sita",
                    FatherName = "Hari",
                    Description = " He is a good boy "
                },
                new Student{
                     Id = 4,
                    Name = "Hari",
                    Address = "Pkr",
                    Gender = "Male",
                    Class = "13",
                    RollNo = 125,
                    Status = "Passed out",
                    Phone = "09876246809",
                    Nationality = "Nepali",
                    MotherName = "Sita",
                    FatherName = "Ram",
                    Description = " He is a good boy "
                },
                new Student
                {
                     Id = 5,
                Name = "Deku",
                Address = "Ktm",
                Gender = "Male",
                Class = "10",
                RollNo = 125,
                Status = "Current",
                Phone = "0987624367887",
                Nationality = "Nepali",
                MotherName = "anita",
                FatherName = "hum",
                Description = " He is a good boy "
                },
                new Student
                {
                      Id = 6,
                    Name = "Sita",
                    Address = "Ktm",
                    Gender = "Female",
                    Class = "10",
                    RollNo = 135,
                    Status = "Current",
                    Phone = "0987634567787",
                    Nationality = "Nepali",
                    MotherName = "Janaki",
                    FatherName = "Janak",
                    Description = " She is a good girl "
                },
                new Student
                {
                       Id = 7,
                    Name = "Sia",
                    Address = "Ktm",
                    Gender = "Male",
                    Class = "10",
                    RollNo = 125,
                    Status = "Passed out",
                    Phone = "09876",
                    Nationality = "Nepali",
                    MotherName = "Katy",
                    FatherName = "keta",
                    Description = " She is a good girl "
                }

            });

            gridStudents.DataSource = studentList;
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
            RollNo = RollNo;
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

        public Student(string name, string className)
        {
            Name = name;
            Class = className;
        }

        public Student(string name, int className)
        {
            Name = name;
            Class = className.ToString();
        }

    }

}
