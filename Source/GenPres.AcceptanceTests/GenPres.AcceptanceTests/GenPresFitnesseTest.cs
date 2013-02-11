using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenPres.AcceptanceTests
{   
    public class GenPresFitnesseTest
    {
        public string result { private set; get; }

        public GenPresFitnesseTest()
        {
            
        }

        public string TestGenPresFitnesse()
        {
            result = "Fitnesse is working!";
            return result;
        }

        public string getResult()
        {
            return result;
        }

    }    
}
