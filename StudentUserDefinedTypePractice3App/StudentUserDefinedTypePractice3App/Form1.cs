using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentUserDefinedTypePractice3App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student> studentList = new List<Student>(3);
        private int i = 0;
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (i < 3)
            {
                Student aStudent = new Student();
                aStudent.regNo = regNoTextBox.Text;
                aStudent.firstName = firstNameTextBox.Text;
                aStudent.lastName = lastNameTextBox.Text;

                studentList.Add(aStudent);
                MessageBox.Show("Student Saved");
                i++;
            }
            else
            {
                MessageBox.Show("Already 3 Student Saved");
            }
           
            ClearTextBox();

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string message = "Registration Number\tFull Name\n";
            foreach (Student aStudent in studentList)
            {
                message = message + aStudent.regNo + "\t\t" + aStudent.GetFullName() + "\n";
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
