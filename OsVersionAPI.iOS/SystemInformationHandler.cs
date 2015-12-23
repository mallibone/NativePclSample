namespace OsVersionAPI.Core
{
    public class SystemInformationHandler
    {
        /// <summary>
        /// Returns String "iOS [VersionNumber]"
        /// </summary>
        public static string OSVersion => $"iOS {ObjCRuntime.Constants.Version}";
    }
}
