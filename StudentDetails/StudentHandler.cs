using System.Data.SQLite;

namespace StudentDetails
{
    // Service class
    public class StudentHandler
    {
        private const string CONNECTION_STRING = @"Data Source=Students.db;Version=3";

        // insert
        public async Task<CommandResult> InsertAsync(StudentDto dto)
        {
            var result = new CommandResult();

            try
            {
                using var conn = new SQLiteConnection(CONNECTION_STRING);
                await conn.OpenAsync(); 


                var cmd = new SQLiteCommand($@"INSERT INTO Student (Name, Address,Gender,Class,RollNo,Status,Phone,Nationality,MotherName,FatherName,Description) 
                   VALUES (@prName, @prAddress, @prGender, @prClass, @prRoll, @prStatus, @prPhone, @prNationality,
                            @prMother, @prFather, @prDescription )", conn)
                {
                    CommandType = System.Data.CommandType.Text
                };


                cmd.Parameters.Add(new SQLiteParameter("@prName", dto.Name));
                cmd.Parameters.Add(new SQLiteParameter("@prAddress", dto.Address));
                cmd.Parameters.Add(new SQLiteParameter("@prGender", dto.Gender));
                cmd.Parameters.Add(new SQLiteParameter("@prClass", dto.Class));
                cmd.Parameters.Add(new SQLiteParameter("@prRoll", dto.RollNo));
                cmd.Parameters.Add(new SQLiteParameter("@prStatus", dto.Status));
                cmd.Parameters.Add(new SQLiteParameter("@prPhone", dto.Phone));
                cmd.Parameters.Add(new SQLiteParameter("@prNationality", dto.Nationality));
                cmd.Parameters.Add(new SQLiteParameter("@prMother", dto.MotherName));
                cmd.Parameters.Add(new SQLiteParameter("@prFather", dto.FatherName));
                cmd.Parameters.Add(new SQLiteParameter("@prDescription", dto.Description));

                result.RowsAffected = await cmd.ExecuteNonQueryAsync();
                conn.Close();

                result.Success = result.RowsAffected > 0;
            }
            catch (SQLiteException exec)
            {
                result.ErrorMessage = exec.Message;
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        // update
        public async Task<CommandResult> UpdateAsync(StudentDto dto)
        {
            var result = new CommandResult();

            try
            {
                using var conn = new SQLiteConnection(CONNECTION_STRING);
                await conn.OpenAsync();


                var cmd = new SQLiteCommand($@"UPDATE Student  SET Name = @prName, Address = @prAddress, Gender = @prGender, Class = @prClass,RollNo=@RollNo,Status=@Status,Phone=@Phone,Nationality=@Nationality,MotherName = @MotherName,FatherName= @FatherName,Description = @Description 
                  ", conn)
                {
                    CommandType = System.Data.CommandType.Text
                };


                cmd.Parameters.Add(new SQLiteParameter("@prName", dto.Name));
                cmd.Parameters.Add(new SQLiteParameter("@prAddress", dto.Address));
                cmd.Parameters.Add(new SQLiteParameter("@prGender", dto.Gender));
                cmd.Parameters.Add(new SQLiteParameter("@prClass", dto.Class));
                cmd.Parameters.Add(new SQLiteParameter("@prRoll", dto.RollNo));
                cmd.Parameters.Add(new SQLiteParameter("@prStatus", dto.Status));
                cmd.Parameters.Add(new SQLiteParameter("@prPhone", dto.Phone));
                cmd.Parameters.Add(new SQLiteParameter("@prNationality", dto.Nationality));
                cmd.Parameters.Add(new SQLiteParameter("@prMother", dto.MotherName));
                cmd.Parameters.Add(new SQLiteParameter("@prFather", dto.FatherName));
                cmd.Parameters.Add(new SQLiteParameter("@prDescription", dto.Description));

                result.RowsAffected = await cmd.ExecuteNonQueryAsync();
                conn.Close();

                result.Success = result.RowsAffected > 0;
            }
            catch (SQLiteException exec)
            {
                result.ErrorMessage = exec.Message;
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
            }
            return result;
        }


        // delete
        public async Task<CommandResult> DeleteAsync(int id)
        {
            var result = new CommandResult();

            try
            {
                using var conn = new SQLiteConnection(CONNECTION_STRING);
                await conn.OpenAsync();


                var cmd = new SQLiteCommand($@"DELETE FROM Student WHERE Id = @prId ", conn)
                {
                    CommandType = System.Data.CommandType.Text
                };

                cmd.Parameters.Add(new SQLiteParameter("@prId", id));

                result.RowsAffected = await cmd.ExecuteNonQueryAsync();
                conn.Close();

                result.Success = result.RowsAffected > 0;
            }
            catch (SQLiteException exec)
            {
                result.ErrorMessage = exec.Message;
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        // retrieve 
        public async Task<(bool Success, StudentDto Dto)> GetStudentAsync(int id)
        {
            try
            {
                using var conn = new SQLiteConnection(CONNECTION_STRING);
                await conn.OpenAsync();

                var cmd = new SQLiteCommand("SELECT * FROM Student WHERE Id = @prId ", conn);
                cmd.Parameters.Add(new SQLiteParameter("@prId", id));

                StudentDto dto = null;

                var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    dto = new StudentDto
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

                return (true, dto);
            }
            catch (Exception)
            {
                return (false, null);
            }
        }

        public async Task<QueryResult<StudentDto>> GetStudentsListAsync()
        {
            var result = new QueryResult<StudentDto>();

            try
            {
                using var conn = new SQLiteConnection(CONNECTION_STRING);
                await conn.OpenAsync();

                var cmd = new SQLiteCommand("SELECT * FROM Student ", conn);

                var studentsList = new List<StudentDto>();

                var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    studentsList.Add(new StudentDto
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

                result.List = studentsList;
                result.Success = true;
            }
            catch (Exception e)
            {
                result.ErrorMessage = e.Message;
            }

            return result;
        }
    }


    // insert, update, delete
    public struct CommandResult
    {
        public string ErrorMessage { get; set; }
        public bool Success { get; set; }
        public int RowsAffected { get; set; }
    }

    // select
    public struct QueryResult<T>
    {
        public string ErrorMessage { get; set; }
        public bool Success { get; set; }
        public IList<T> List { get; set; }
    }

    // DTO: data transfer object; used to transfer data/values between layers/units
    public class StudentDto
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

    // poco: The exact representation of database object in .net class; used only in data access layer
    public class StudentPoco
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
