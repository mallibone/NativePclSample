namespace OsVersionAPI.Core
{
    public class SystemInformationHandler
    {
        /// <summary>
        /// Returns String "Android [SDK] [Release]"
        /// </summary>
        public static string OSVersion => $"Android {Android.OS.Build.VERSION.SdkInt} {Android.OS.Build.VERSION.Release}";
    }
}
