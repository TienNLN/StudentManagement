using Lab_Group.tiennln.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Group
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadDataGridView();
            loadComboboxSex(true, null);
        }

        private void loadDataGridView()
        {
            dataGridView.Rows.Clear();
            StudentDAO studentDAO = new StudentDAO();
            List<StudentDTO> listStudents = studentDAO.getStudentList();

            foreach (StudentDTO temp in listStudents)
            {
                string[] dobArr = temp.DoB.Split(' ');
                string dob = dobArr[0];

                dataGridView.Rows.Add(temp.ID, temp.Surname, temp.Name, dob, temp.Sex, temp.MajorID);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool errorFound = false;

            if(string.IsNullOrEmpty(txt_boxName.Text) 
                || string.IsNullOrEmpty(txt_boxStudentID.Text) 
                || string.IsNullOrEmpty(txt_boxSurname.Text) 
                || string.IsNullOrEmpty(txt_boxMajorID.Text))
            {
                errorFound = true;

                MessageBox.Show("Please fill in all the fields");
            }

            if (!errorFound)
            {
                string studentID = txt_boxStudentID.Text;
                string surname = txt_boxSurname.Text;
                string name = txt_boxName.Text;
                string dob = datePickerDOB.Value.ToString();
                string sex = comboboxSex.Text;
                string majorID = txt_boxMajorID.Text;

                StudentDAO studentDAO = new StudentDAO();
                bool isCreated = studentDAO.AddNewStudent(studentID, surname, name, dob, sex, majorID);

                if (isCreated)
                {
                    MessageBox.Show("Student Added", "Succeed");
                    loadDataGridView();
                }
                else
                {
                    MessageBox.Show("Student Adding Failed", "Error");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txt_boxStudentID.Text = "";
            txt_boxSurname.Text = "";
            txt_boxName.Text = "";
            datePickerDOB.Value = DateTime.Today;
            comboboxSex.Text = "";
            txt_boxMajorID.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txt_boxStudentID.Enabled = true;
            txt_boxSurname.Enabled = true;
            txt_boxName.Enabled = true;
            txt_boxName.Enabled = true;
            datePickerDOB.Enabled = true;
            comboboxSex.Enabled = true;
            txt_boxMajorID.Enabled = true;

            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                int selectedRow = -1;

                for (int i = 0; i < selectedRowCount; i++)
                {
                    selectedRow = dataGridView.SelectedRows[i].Index;
                }

                if(selectedRow < dataGridView.Rows.Count - 1)
                {
                    Console.WriteLine(selectedRow);
                    Console.WriteLine(dataGridView.Rows.Count);
                    txt_boxStudentID.Text = dataGridView.Rows[selectedRow].Cells[0].Value.ToString().Trim();
                    txt_boxSurname.Text = dataGridView.Rows[selectedRow].Cells[1].Value.ToString().Trim();
                    txt_boxName.Text = dataGridView.Rows[selectedRow].Cells[2].Value.ToString().Trim();
                    datePickerDOB.Value = Convert.ToDateTime(dataGridView.Rows[selectedRow].Cells[3].Value.ToString().Trim());
                    txt_boxMajorID.Text = dataGridView.Rows[selectedRow].Cells[5].Value.ToString().Trim();
                    loadComboboxSex(false, dataGridView.Rows[selectedRow].Cells[4].Value.ToString().Trim());
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string studentID = txt_boxStudentID.Text;

            StudentDAO studentDAO = new StudentDAO();

            bool isDeleted = studentDAO.DeleteStudent(studentID);

            if (isDeleted)
            {
                MessageBox.Show("Deleted", "Succeed");
                loadDataGridView();
            }
            else
            {
                MessageBox.Show("Delete Failed", "Error");
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string studentID = txt_boxStudentID.Text;
            string surname = txt_boxSurname.Text;
            string name = txt_boxName.Text;
            string dob = datePickerDOB.Value.ToString();
            string sex = comboboxSex.Text;
            string majorID = txt_boxMajorID.Text;

            StudentDAO studentDAO = new StudentDAO();
            bool isUpdated = studentDAO.UpdateStudent(studentID, surname, name, dob, sex, majorID);

            if (isUpdated)
            {
                MessageBox.Show("Updated", "Succeed");
                loadDataGridView();
            } else
            {
                MessageBox.Show("Update Fail", "Error");
            }
        }

        private void loadComboboxSex(bool initialTime, string sexToShowFirst)
        {
            List<String> dataSource = new List<string>();
            dataSource.Add("Male");
            dataSource.Add("Female");
            dataSource.Add("Other");

            if (initialTime)
            {
                comboboxSex.DataSource = new BindingSource(dataSource, null);
            } 
            else
            {
                int indexOfShowingSex = dataSource.IndexOf(sexToShowFirst);
                Console.WriteLine(indexOfShowingSex);

                string showingSex = dataSource[indexOfShowingSex];
                string replaceSex = dataSource[0];

                dataSource[indexOfShowingSex] = replaceSex;
                dataSource[0] = showingSex;

                comboboxSex.DataSource = new BindingSource(dataSource, null);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
