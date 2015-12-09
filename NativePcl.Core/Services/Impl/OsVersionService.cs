using OsVersionAPI.Core;

namespace NativePcl.Core.Services.Impl
{
    public class OsVersionService : IOsVersionService
    {
        public string GetVersion()
        {
            return SystemInformationHandler.OSVersion;
        }
    }
}
