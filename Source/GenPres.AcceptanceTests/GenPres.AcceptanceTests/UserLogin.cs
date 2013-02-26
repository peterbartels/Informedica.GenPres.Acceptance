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
            //var loginService = new Presentation.LoginService();
            return true;
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
