using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Admission_System
{
    public class Department
    {
        public string _code;
        public string _dname;

        public Department(string name, string code)
        {
            this._dname = name;
            this._code = code;
        }

        public List<Student> _studentsList = new List<Student>();

        public void set(string name, string code) 
        {
            _dname= name;
            _code= code;
        }

        public string getCode()
        {
            return _code;
        }
        public string getName() 
        {
            return _dname;
        }
    }
}
