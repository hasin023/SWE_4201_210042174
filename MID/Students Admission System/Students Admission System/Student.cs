using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Admission_System
{
    public class Student
    {
        public string _id;
        public string _name;
        public string _deptCode;
        //public string _deptName;
        public string _section;

        public Student(string id, string name, string deptCode, string section) 
        {
            this._id = id;
            this._name = name;
            this._deptCode = deptCode;
            this._section = section;
        }

        public void set(string id, string name, string deptCode, string section)
        {
            _id = id;
            _name = name;
            _deptCode = deptCode;
            _section = section;
        }

        public string getId() 
        {
            return _id;
        }
        public string getName()
        {
            return _name;
        }
        public string getDeptCode()
        {
            return _deptCode;
        }
        public string getSection()
        {
            return _section;
        }
    }
}
