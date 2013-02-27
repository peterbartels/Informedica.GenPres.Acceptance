using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenPres.AcceptanceTests
{
    public class User : Informedica.GenPres.Business.Entities.User
    {
        public User() : base()
        {
            TestFixtures.TestUser = this;
        }
    }
}
