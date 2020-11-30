using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace department_faculty
{
    class department
    {
        public string departmentName { get; set; }
        public string departmentNumber { get; set; }

        public Faculty[] listOfFaculty;
        private int facultyCount;
        public int FacultyCount
        {
            get { return facultyCount; }
            set { facultyCount = value; }
        }

        public department()
        {
            listOfFaculty = new Faculty[100];
            facultyCount = 0;
        }
        public department(string name, string number)
        {
            departmentName = name;
            departmentNumber = number;
            listOfFaculty = new Faculty[100];
            facultyCount = 0;

        }
        public void Show()
        {
            Console.WriteLine("Name Of The department: " + departmentName);
            Console.WriteLine("ID Number Of The department: " + departmentNumber);

        }
        public void AddFaculty(params Faculty[] faculties)
        {
            foreach (var faculty in faculties)
            {
                if (facultyCount < 500)
                    listOfFaculty[facultyCount++] = faculty;

            }
        }
        public Faculty SearchFaculty(string fid)
        {
            Faculty f = null;
            for (int i = 0; i < facultyCount; i++)
            {
                if (listOfFaculty[i].FacultyId.Equals(fid))
                {
                    f = listOfFaculty[i];
                    break;
                }
            }
            return f;
        }
        public void RemoveFaculty(Faculty faculty)
        {
            for (int i = 0; i < facultyCount; i++)
            {
                if (faculty.FacultyId.Equals(listOfFaculty[i].FacultyId))
                {
                    for (int j = i; j < facultyCount - 1; j++)
                    {
                        listOfFaculty[j] = listOfFaculty[j + 1];
                    }
                    facultyCount--;
                    break;
                }

            }
        }
        public void ShowAllFaculty()
        {
            for (int i = 0; i < facultyCount; i++)
            {
                listOfFaculty[i].ShowInfo();

            }
        }


    }
}