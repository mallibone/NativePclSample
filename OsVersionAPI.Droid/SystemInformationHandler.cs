namespace OsVersionAPI.Core
{
    public class SystemInformationHandler
    {
        #region Implementation of ISystemInformationHandler

        public static string OSVersion => $"Android {Android.OS.Build.VERSION.SdkInt} {Android.OS.Build.VERSION.Release}";

        #endregion
    }
}
