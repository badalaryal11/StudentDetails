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
                    dictionary.Add(Convert.ToInt32(reader["Id"]), (string)reader["Name"],(string)reader["Address"],
                       (string)reader["Gender"],reader["Class"],reader["Roll No."],(string)reader["Status"],reader["Phone"],
                        (string)reader["Nationality"], (string)reader["MotherName"], (string)reader["FatherName"], (string)reader["Description"]);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            var form = new FrmStudentEntry();
            form.ShowDialog();
        }

        private async void vIEWToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        
        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            var form = new FrmStudentEntry();
            form.ShowDialog();


        }
    }
}
