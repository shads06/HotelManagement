using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework.Drawing;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Hotel_Manager.Models;
using Hotel_Manager.Managers;
using Hotel_Manager.Exceptions;

namespace Hotel_Manager
{
    public partial class Login : MetroForm
    {

        DepartmentManager departmentManager = new DepartmentManager();

        public Login()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void signinButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (verifier("frontend".Trim(), usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim()))
                {
                    this.Hide();
                    Frontend hotel_management = new Frontend();
                    hotel_management.Show();
                }
                else if (verifier("kitchen".Trim(), usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim()))
                {
                    this.Hide();
                    Kitchen kitchen_management = new Kitchen();
                    kitchen_management.Show();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Username or Password is wrong, try again", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void usernameTextBox_Click(object sender, EventArgs e)
        {

            if (usernameTextBox.Text == string.Empty)
            {
                usernameLabel.Visible = true;
            }
            if (usernameTextBox.Text != "Username" && usernameTextBox.Text != string.Empty)
            {
                usernameLabel.Visible = false;
            }
        }
        private void passwordTextBox_Click(object sender, EventArgs e)
        {

            if (passwordTextBox.Text == string.Empty)
            {
                passwordLabel.Visible = true;
            }
            if (passwordTextBox.Text != "Password" && passwordTextBox.Text != string.Empty)
            {
                passwordLabel.Visible = false;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!usernameLabel.Bounds.Contains(e.Location) && usernameTextBox.Text == string.Empty)
            {
                usernameLabel.Visible = false;
            }
            if (!passwordLabel.Bounds.Contains(e.Location) && passwordTextBox.Text == string.Empty)
            {
                passwordLabel.Visible = false;
            }

        }

        public bool verifier(string tableName, string username, string password)
        {
            bool success = false;
            SqlConnection connection = new SqlConnection(Hotel_Manager.Properties.Settings.Default.loginConnectionString);
            string sql = "SELECT* FROM "  +tableName+ " WHERE user_name=@userName AND pass_word=@password";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.CommandText = sql;
                SqlParameter UsernameParametar = new SqlParameter("@username", SqlDbType.VarChar);
                SqlParameter PassParametar = new SqlParameter("@password", SqlDbType.VarChar);
                sqlCommand.Parameters.Add(UsernameParametar);
                sqlCommand.Parameters.Add(PassParametar);
                UsernameParametar.Value = username;
                PassParametar.Value = password;
                connection.Open();
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                if (sqlReader.HasRows)
                    success = true;
                connection.Close();
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(this, e.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            return success;
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void LicenseCallButton_Click(object sender, EventArgs e)
        {
            License open_license = new License();
            open_license.ShowDialog();
        }

        private void departmentsMetroButton_Click(object sender, EventArgs e)
        {
            Hotel_Manager.Views.DepartmentView departmentView = new Views.DepartmentView();
            departmentView.Show();
        }

        private void Login_Activated(object sender, EventArgs e)
        {

            try
            {

                if (_DepartmentFormActvationErrorCount == 0)
                {

                    var departments = new List<Department>();

                    try
                    {

                        departments = departmentManager.GetAll().ToList();

                        departmentMetroComboBoxLogin.Items.Clear();

                        foreach (var department in departments)
                        {

                            departmentMetroComboBoxLogin.Items.Add(department.Name);

                        }

                        if (departments.Count > 0)
                            departmentMetroComboBoxLogin.SelectedIndex = 0;

                        _DepartmentFormActvationErrorCount = 0;

                    }
                    catch (EntityNotFoundException ex)
                    {

                        _DepartmentFormActvationErrorCount++;

                        MetroFramework.MetroMessageBox.Show(this, ex.Message.ToString(), "Information", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

                    }

                }
                else
                {

                    if (_DepartmentFormActvationErrorCount == 3)
                        _DepartmentFormActvationErrorCount = 0;
                    else
                        _DepartmentFormActvationErrorCount++;

                }

            }
            catch (Exception ex)
            {

                _DepartmentFormActvationErrorCount++;

                MetroFramework.MetroMessageBox.Show(this, ex.Message.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }

        }


        public int _DepartmentFormActvationErrorCount = 0;

    }
}
