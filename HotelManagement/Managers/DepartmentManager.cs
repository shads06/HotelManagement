using Hotel_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Hotel_Manager.Exceptions;

namespace Hotel_Manager.Managers
{
    public class DepartmentManager
    {

        public void AddDepartment(Department department)
        {

            try
            {

                using (var connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.loginConnectionString))
                {

                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;

                        command.CommandTimeout = 400;

                        command.CommandText = "insert into Department (Name, Details) values (@Name, @Details)";

                        command.Parameters.AddWithValue("@Name", department.Name);
                        command.Parameters.AddWithValue("@Details", department.Details);

                        connection.Open();

                        command.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public IEnumerable<Department> GetAll()
        {

            List<Department> departments = new List<Department>();

            try
            {

                using (var connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.loginConnectionString))
                {

                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;

                        command.CommandTimeout = 400;

                        command.CommandText = "Select * from Department";

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {

                            while (reader.Read())
                            {

                                Department department = new Department();
                                department.ID = Convert.ToInt32(reader["ID"]);
                                department.Name = reader["Name"].ToString();
                                department.Details = reader["Details"].ToString();

                                departments.Add(department);

                            }

                        }
                        else
                        {
                            throw new EntityNotFoundException("No Departments are found to retrieve.");
                        }

                    }

                }

                return departments;

            }
            catch (EntityNotFoundException ex)
            {
                
                throw new EntityNotFoundException("No Departments are found to retrieve.");

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void UpdateDepartment(Department department)
        {

            try
            {

                using (var connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.loginConnectionString))
                {

                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;

                        command.CommandTimeout = 400;

                        command.CommandText = "update Department set Name = @Name, Details = @Details where ID = @ID";

                        command.Parameters.AddWithValue("@ID", department.ID);
                        command.Parameters.AddWithValue("@Name", department.Name);
                        command.Parameters.AddWithValue("@Details", department.Details);

                        connection.Open();

                        command.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception ex)
            {
                throw;
            }

        }

    }

}
