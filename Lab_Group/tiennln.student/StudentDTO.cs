using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Group.tiennln.Student
{
    class StudentDTO
    {
        private string studentID;
        private string surname;
        private string name;
        private string dob;
        private string sex;
        private string majorID;

        public StudentDTO(string studentID, string surname, string name, string dob, string sex, string majorID)
        {
            this.studentID = studentID;
            this.surname = surname;
            this.name = name;
            this.dob = dob;
            this.sex = sex;
            this.majorID = majorID;
        }

        public string ID
        {
            get
            {
                return studentID;
            }
            set
            {
                studentID = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string DoB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }

        public string Sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            }
        }

        public string MajorID
        {
            get
            {
                return majorID;
            }
            set
            {
                majorID = value;
            }
        }
    }
}
