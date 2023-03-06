using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_Admission_System
{
    public partial class SAS : Form
    {
        List<Department> _departments = new List<Department>();
        List<Student> _students = new List<Student>();
        public SAS()
        {
            InitializeComponent();

            studentListBox.Items.Add("   Student ID \t Student Name \t Department \t Section");
        }

        private void addDeptButton_Click(object sender, EventArgs e)
        {
            Department _temp = new Department(deptNameTextBox1.Text, deptCodeTextBox1.Text);
            _departments.Add(_temp);

            studentIDTextBox1.Focus();
        }

        private void admitStudentButton_Click(object sender, EventArgs e)
        {
            Student _temp = new Student(studentIDTextBox1.Text, studentNameTextBox1.Text, deptCodeTextBox2.Text, sectionTextBox.Text);
            _students.Add(_temp);

            studentIDTextBox1.Clear();
            studentNameTextBox1.Clear();
            deptCodeTextBox2.Clear();
            sectionTextBox.Clear();

            studentIDTextBox1.Focus();

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //studentListBox.Items.Clear();
            //studentListBox.Items.Add("   Student ID \t Student Name \t Department \t Section");

            foreach (Student _temp in _students) 
            {
                if(_temp._deptCode == deptCodeTextBox3.Text)
                {
                    //_temp._deptCode = _departments.;

                    string student = $"   {_temp._id} \t {_temp._name} \t\t {_temp._deptCode} \t\t  {_temp._section}";
                    studentListBox.Items.Add(student);
                }
            }
        }
    }
}
