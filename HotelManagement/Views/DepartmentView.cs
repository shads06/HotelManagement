using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Manager.Managers;
using Hotel_Manager.Exceptions;
using Hotel_Manager.Models;

namespace Hotel_Manager.Views
{
    public partial class DepartmentView : MetroForm
    {

        DepartmentManager departmentManager = new DepartmentManager();
        short _DepartmentFormActvationErrorCount = 0;

        public DepartmentView()
        {
            InitializeComponent();
        }

        private void DepartmentView_Load(object sender, EventArgs e)
        {
        }

        private void saveMetroButton_Click(object sender, EventArgs e)
        {

            try
            {

                Department department = new Department();

                department.Name = nameMetroTextBox.Text;
                department.Details = extraDetailsMetroTextBox.Text;

                departmentManager.AddDepartment(department);

                MetroFramework.MetroMessageBox.Show(this, "Department Added Sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);

                this.nameMetroTextBox.Text = string.Empty;
                this.extraDetailsMetroTextBox.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void DepartmentView_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void DepartmentView_Activated(object sender, EventArgs e)
        {

            try
            {

                if (_DepartmentFormActvationErrorCount == 0)
                {

                    var departments = new List<Department>();

                    try
                    {

                        departments = departmentManager.GetAll().ToList();

                        departmentsDataGridView.DataSource = departments;
                        departmentsDataGridView.AutoGenerateColumns = true;
                        departmentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        
                        _DepartmentFormActvationErrorCount = 0;

                    }
                    catch (EntityNotFoundException ex)
                    {

                        departmentsDataGridView.DataSource = departments;
                        departmentsDataGridView.AutoGenerateColumns = true;
                        departmentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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

        private void DepartmentView_Shown(object sender, EventArgs e)
        {
        }

        private void DepartmentView_Deactivate(object sender, EventArgs e)
        {
        }
    }
}
