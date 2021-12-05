using System;

using R5T.T0021;

using R5T.A0003;


namespace System
{
    public static class IFileNameExtensions
    {
        public static string ConfigurationText(this IFileName _)
        {
            return FileNames.ConfigurationText;
        }

        public static string HumanOutputText(this IFileName _)
        {
            return FileNames.HumanOutputText;
        }

        public static string LogText(this IFileName _)
        {
            return FileNames.LogText;
        }

        public static string MachineOutputJson(this IFileName _)
        {
            return FileNames.MachineOutputJson;
        }

        public static string ServicesText(this IFileName _)
        {
            return FileNames.ServicesText;
        }
    }
}
