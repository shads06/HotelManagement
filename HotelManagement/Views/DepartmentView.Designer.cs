namespace Hotel_Manager.Views
{
    partial class DepartmentView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.departmentViewMetroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.viewDepartmentsTab = new MetroFramework.Controls.MetroTabPage();
            this.departmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.addDepartmentTab = new MetroFramework.Controls.MetroTabPage();
            this.DepartmentIDValueHtmlLabel = new MetroFramework.Drawing.Html.HtmlLabel();
            this.DepartmentIDHtmlLabel = new MetroFramework.Drawing.Html.HtmlLabel();
            this.saveMetroButton = new MetroFramework.Controls.MetroButton();
            this.extraDetailsMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.nameMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.extraDetailsMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.nameMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.departmentViewMetroTabControl.SuspendLayout();
            this.viewDepartmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataGridView)).BeginInit();
            this.addDepartmentTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // departmentViewMetroTabControl
            // 
            this.departmentViewMetroTabControl.Controls.Add(this.viewDepartmentsTab);
            this.departmentViewMetroTabControl.Controls.Add(this.addDepartmentTab);
            this.departmentViewMetroTabControl.Location = new System.Drawing.Point(23, 79);
            this.departmentViewMetroTabControl.Name = "departmentViewMetroTabControl";
            this.departmentViewMetroTabControl.SelectedIndex = 1;
            this.departmentViewMetroTabControl.Size = new System.Drawing.Size(771, 329);
            this.departmentViewMetroTabControl.TabIndex = 1;
            this.departmentViewMetroTabControl.UseSelectable = true;
            // 
            // viewDepartmentsTab
            // 
            this.viewDepartmentsTab.Controls.Add(this.departmentsDataGridView);
            this.viewDepartmentsTab.HorizontalScrollbarBarColor = true;
            this.viewDepartmentsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.viewDepartmentsTab.HorizontalScrollbarSize = 10;
            this.viewDepartmentsTab.Location = new System.Drawing.Point(4, 38);
            this.viewDepartmentsTab.Name = "viewDepartmentsTab";
            this.viewDepartmentsTab.Size = new System.Drawing.Size(763, 287);
            this.viewDepartmentsTab.TabIndex = 0;
            this.viewDepartmentsTab.Text = "Departments";
            this.viewDepartmentsTab.VerticalScrollbarBarColor = true;
            this.viewDepartmentsTab.VerticalScrollbarHighlightOnWheel = false;
            this.viewDepartmentsTab.VerticalScrollbarSize = 10;
            // 
            // departmentsDataGridView
            // 
            this.departmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentsDataGridView.Location = new System.Drawing.Point(4, 16);
            this.departmentsDataGridView.Name = "departmentsDataGridView";
            this.departmentsDataGridView.Size = new System.Drawing.Size(763, 253);
            this.departmentsDataGridView.TabIndex = 2;
            // 
            // addDepartmentTab
            // 
            this.addDepartmentTab.Controls.Add(this.DepartmentIDValueHtmlLabel);
            this.addDepartmentTab.Controls.Add(this.DepartmentIDHtmlLabel);
            this.addDepartmentTab.Controls.Add(this.saveMetroButton);
            this.addDepartmentTab.Controls.Add(this.extraDetailsMetroTextBox);
            this.addDepartmentTab.Controls.Add(this.nameMetroTextBox);
            this.addDepartmentTab.Controls.Add(this.extraDetailsMetroLabel);
            this.addDepartmentTab.Controls.Add(this.nameMetroLabel);
            this.addDepartmentTab.HorizontalScrollbarBarColor = true;
            this.addDepartmentTab.HorizontalScrollbarHighlightOnWheel = false;
            this.addDepartmentTab.HorizontalScrollbarSize = 10;
            this.addDepartmentTab.Location = new System.Drawing.Point(4, 38);
            this.addDepartmentTab.Name = "addDepartmentTab";
            this.addDepartmentTab.Size = new System.Drawing.Size(763, 287);
            this.addDepartmentTab.TabIndex = 1;
            this.addDepartmentTab.Text = "Add Department";
            this.addDepartmentTab.VerticalScrollbarBarColor = true;
            this.addDepartmentTab.VerticalScrollbarHighlightOnWheel = false;
            this.addDepartmentTab.VerticalScrollbarSize = 10;
            // 
            // DepartmentIDValueHtmlLabel
            // 
            this.DepartmentIDValueHtmlLabel.AutoScroll = true;
            this.DepartmentIDValueHtmlLabel.AutoScrollMinSize = new System.Drawing.Size(17, 23);
            this.DepartmentIDValueHtmlLabel.AutoSize = false;
            this.DepartmentIDValueHtmlLabel.BackColor = System.Drawing.SystemColors.Window;
            this.DepartmentIDValueHtmlLabel.Enabled = false;
            this.DepartmentIDValueHtmlLabel.Location = new System.Drawing.Point(281, 19);
            this.DepartmentIDValueHtmlLabel.Name = "DepartmentIDValueHtmlLabel";
            this.DepartmentIDValueHtmlLabel.Size = new System.Drawing.Size(299, 23);
            this.DepartmentIDValueHtmlLabel.TabIndex = 8;
            this.DepartmentIDValueHtmlLabel.Text = "0";
            // 
            // DepartmentIDHtmlLabel
            // 
            this.DepartmentIDHtmlLabel.AutoScroll = true;
            this.DepartmentIDHtmlLabel.AutoScrollMinSize = new System.Drawing.Size(21, 23);
            this.DepartmentIDHtmlLabel.AutoSize = false;
            this.DepartmentIDHtmlLabel.BackColor = System.Drawing.SystemColors.Window;
            this.DepartmentIDHtmlLabel.Location = new System.Drawing.Point(153, 19);
            this.DepartmentIDHtmlLabel.Name = "DepartmentIDHtmlLabel";
            this.DepartmentIDHtmlLabel.Size = new System.Drawing.Size(75, 23);
            this.DepartmentIDHtmlLabel.TabIndex = 7;
            this.DepartmentIDHtmlLabel.Text = "ID";
            // 
            // saveMetroButton
            // 
            this.saveMetroButton.Location = new System.Drawing.Point(281, 245);
            this.saveMetroButton.Name = "saveMetroButton";
            this.saveMetroButton.Size = new System.Drawing.Size(299, 27);
            this.saveMetroButton.TabIndex = 6;
            this.saveMetroButton.Text = "Save";
            this.saveMetroButton.UseSelectable = true;
            this.saveMetroButton.Click += new System.EventHandler(this.saveMetroButton_Click);
            // 
            // extraDetailsMetroTextBox
            // 
            this.extraDetailsMetroTextBox.Lines = new string[0];
            this.extraDetailsMetroTextBox.Location = new System.Drawing.Point(281, 110);
            this.extraDetailsMetroTextBox.MaxLength = 32767;
            this.extraDetailsMetroTextBox.Multiline = true;
            this.extraDetailsMetroTextBox.Name = "extraDetailsMetroTextBox";
            this.extraDetailsMetroTextBox.PasswordChar = '\0';
            this.extraDetailsMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.extraDetailsMetroTextBox.SelectedText = "";
            this.extraDetailsMetroTextBox.Size = new System.Drawing.Size(299, 118);
            this.extraDetailsMetroTextBox.TabIndex = 5;
            this.extraDetailsMetroTextBox.UseSelectable = true;
            // 
            // nameMetroTextBox
            // 
            this.nameMetroTextBox.Lines = new string[0];
            this.nameMetroTextBox.Location = new System.Drawing.Point(281, 59);
            this.nameMetroTextBox.MaxLength = 32767;
            this.nameMetroTextBox.Name = "nameMetroTextBox";
            this.nameMetroTextBox.PasswordChar = '\0';
            this.nameMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameMetroTextBox.SelectedText = "";
            this.nameMetroTextBox.Size = new System.Drawing.Size(299, 23);
            this.nameMetroTextBox.TabIndex = 4;
            this.nameMetroTextBox.UseSelectable = true;
            // 
            // extraDetailsMetroLabel
            // 
            this.extraDetailsMetroLabel.AutoSize = true;
            this.extraDetailsMetroLabel.Location = new System.Drawing.Point(153, 115);
            this.extraDetailsMetroLabel.Name = "extraDetailsMetroLabel";
            this.extraDetailsMetroLabel.Size = new System.Drawing.Size(80, 19);
            this.extraDetailsMetroLabel.TabIndex = 3;
            this.extraDetailsMetroLabel.Text = "Extra Details";
            // 
            // nameMetroLabel
            // 
            this.nameMetroLabel.AutoSize = true;
            this.nameMetroLabel.Location = new System.Drawing.Point(153, 63);
            this.nameMetroLabel.Name = "nameMetroLabel";
            this.nameMetroLabel.Size = new System.Drawing.Size(45, 19);
            this.nameMetroLabel.TabIndex = 2;
            this.nameMetroLabel.Text = "Name";
            // 
            // DepartmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 416);
            this.Controls.Add(this.departmentViewMetroTabControl);
            this.Name = "DepartmentView";
            this.Text = "Departments";
            this.Activated += new System.EventHandler(this.DepartmentView_Activated);
            this.Deactivate += new System.EventHandler(this.DepartmentView_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DepartmentView_FormClosed);
            this.Load += new System.EventHandler(this.DepartmentView_Load);
            this.Shown += new System.EventHandler(this.DepartmentView_Shown);
            this.departmentViewMetroTabControl.ResumeLayout(false);
            this.viewDepartmentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataGridView)).EndInit();
            this.addDepartmentTab.ResumeLayout(false);
            this.addDepartmentTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl departmentViewMetroTabControl;
        private MetroFramework.Controls.MetroTabPage viewDepartmentsTab;
        private System.Windows.Forms.DataGridView departmentsDataGridView;
        private MetroFramework.Controls.MetroTabPage addDepartmentTab;
        private MetroFramework.Controls.MetroButton saveMetroButton;
        private MetroFramework.Controls.MetroTextBox extraDetailsMetroTextBox;
        private MetroFramework.Controls.MetroTextBox nameMetroTextBox;
        private MetroFramework.Controls.MetroLabel extraDetailsMetroLabel;
        private MetroFramework.Controls.MetroLabel nameMetroLabel;
        private MetroFramework.Drawing.Html.HtmlLabel DepartmentIDValueHtmlLabel;
        private MetroFramework.Drawing.Html.HtmlLabel DepartmentIDHtmlLabel;


    }
}