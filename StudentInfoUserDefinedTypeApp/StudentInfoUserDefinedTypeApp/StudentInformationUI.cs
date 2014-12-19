using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoUserDefinedTypeApp
{
    public partial class StudentInformationUI : Form
    {
        List<Student> studentList = new List<Student>(); 
        public StudentInformationUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.regNo = regNoTextBox.Text;
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;

            studentList.Add(aStudent);
            MessageBox.Show("Student Saved");
            ClearTextBox();


        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            
            string message = "Registration Number\t\tFull Name\n";
            foreach (Student aStudent in studentList)
            {
                message = message + aStudent.regNo + "\t\t" + aStudent.GetFullName() +"\n";
            }
            
            MessageBox.Show(message);
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            studentList.Clear();
            
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            regNoTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
        }
    }
}
