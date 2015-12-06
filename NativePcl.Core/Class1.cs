using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NativePcl.Core
{
    public class OsVersionService : IOsVersionService
    {
        public string GetVersion()
        {
            throw new NotImplementedException();
            //return SystemInformationHandler.OSVersion;
        }
    }
}
