﻿namespace AscInsightsGeo
{
    public class Constants
    {
        public static string AscInsightsServiceBaseAddress = ConfigManager.Get("InsightsServiceBaseAddress");
        public static string AscInsightsServiceAadResource = ConfigManager.Get("InsightsServiceAadResource");
        public static string AllowedCertThumbprints = ConfigManager.Get("AllowedCertThumbprints");
        public static string AllowedCertSubjects = ConfigManager.Get("AllowedCertSubjects");
    }
}