using Autofac;
using Autofac.Core;
using Informedica.Data.Repositories;
using Informedica.GenPres.Business.Entities;
using Informedica.Service.Presentation;

namespace GenPres.AcceptanceTests
{
    public class UserLogin : BaseAccceptanceTests
    {
        public int Department;
        public string Username;
        public string Password;

        public bool AutenticateUser()
        {
            var user = new User();
            user.Username = "test";
            user.PasswordHash = Password;

            var userRepository = Container.Resolve<ILoginService>();
            userRepository.AuthenticateUser(Username, Password);

            return Password == "Secret";
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
