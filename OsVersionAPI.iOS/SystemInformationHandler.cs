namespace OsVersionAPI.Core
{
    public class SystemInformationHandler
    {
        #region Implementation of ISystemInformationHandler

        public static string OSVersion => $"iOS {ObjCRuntime.Constants.Version}";

        #endregion
    }
}
