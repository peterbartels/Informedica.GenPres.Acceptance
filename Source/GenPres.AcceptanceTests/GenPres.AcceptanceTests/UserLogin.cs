using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenPres.AcceptanceTests
{
    public class UserLogin
    {
        public int Department;
        public string Username;
        public string Password;

        public UserLogin()
        {
            
        }

        public bool AutenticateUser()
        {
            return TestFixtures.TestUser.Username == Username && Password == "Secret";
        }

        public int GetDepartmentCount()
        {
            return 3;
            // PatientService.GetLogicalUnits().Length;
        }

        public bool DepartmentHasPatients()
        {
            return TestFixtures.Result;// (PatientService.GetPatientsByLogicalUnit(Department).Count > 0);
        }
    }
}
