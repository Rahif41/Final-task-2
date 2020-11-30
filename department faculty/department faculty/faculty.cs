using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace department_faculty
{
    class faculty
    {
        private string facultyid;

        public string Facultyid { get; set; }
        private string facultyName;

        public string FacultyName
        {
            get { return facultyname; }
            set { facultyname = value; }
        }
        public faculty()
        {

        }
        public faculty(string facultyName, string facultyId)
        {
            this.facultyName = facultyName;
            this.facultyId = facultyId;

        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + facultyname);
            Console.WriteLine("Id: " + facultyid);
        }
    }
}
