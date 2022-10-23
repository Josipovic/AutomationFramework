using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Configuration
    {
        private static TestContext TestContext { get; set; }

        public static string GetSettingsParameter(string ParameterName)
        {
    
            string Parameter = TestContext.Parameters.Get(ParameterName);

            if (!string.IsNullOrEmpty(Parameter))
            {
                Console.WriteLine("Found {0} parameter", ParameterName);
                return Parameter;
            }

            else
            {
                Console.WriteLine("Parameter {0} could not be found", ParameterName);
                return null;
            }

        }


    }
}
