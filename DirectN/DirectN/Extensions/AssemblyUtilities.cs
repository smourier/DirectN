using System;
using System.IO;
using System.Reflection;

namespace DirectN
{
    public static class AssemblyUtilities
    {
        public static string GetProduct() => GetProduct(Assembly.GetEntryAssembly());
        public static string GetProduct(this Assembly assembly)
        {
            assembly = assembly ?? Assembly.GetExecutingAssembly();
            var atts = assembly.GetCustomAttributes(typeof(AssemblyProductAttribute), false);
            if (!atts.IsEmpty())
                return ((AssemblyProductAttribute)atts[0]).Product;

            return null;
        }

        public static string GetConfiguration(this Assembly assembly)
        {
            assembly = assembly ?? Assembly.GetExecutingAssembly();
            var atts = assembly.GetCustomAttributes(typeof(AssemblyConfigurationAttribute), false);
            if (!atts.IsEmpty())
                return ((AssemblyConfigurationAttribute)atts[0]).Configuration;

            return null;
        }

        public static string GetTitle(this Assembly assembly)
        {
            assembly = assembly ?? Assembly.GetExecutingAssembly();
            var atts = assembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
            if (!atts.IsEmpty())
                return ((AssemblyTitleAttribute)atts[0]).Title;

            return null;
        }

        public static string GetInformationalVersion(this Assembly assembly)
        {
            assembly = assembly ?? Assembly.GetExecutingAssembly();
            var atts = assembly.GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), false);
            if (!atts.IsEmpty())
                return ((AssemblyInformationalVersionAttribute)atts[0]).InformationalVersion;

            return null;
        }

        public static string GetCopyright(this Assembly assembly)
        {
            assembly = assembly ?? Assembly.GetExecutingAssembly();
            var atts = assembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
            if (!atts.IsEmpty())
                return ((AssemblyCopyrightAttribute)atts[0]).Copyright;

            return null;
        }

        public static DateTime? GetLinkerTimestampUtc(this Assembly assembly)
        {
            assembly = assembly ?? Assembly.GetExecutingAssembly();
            if (assembly.Location == null)
                return null;

            return GetLinkerTimestampUtc(assembly.Location);
        }

        // see https://stackoverflow.com/questions/1600962/displaying-the-build-date/1600990#1600990
        public static DateTime? GetLinkerTimestampUtc(string filePath)
        {
            if (filePath == null)
                throw new ArgumentNullException(nameof(filePath));

            try
            {
                const int peHeaderOffset = 60;
                const int linkerTimestampOffset = 8;
                var bytes = new byte[2048];

                using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    int read = file.Read(bytes, 0, bytes.Length);
                }

                var headerPos = BitConverter.ToInt32(bytes, peHeaderOffset);
                var secondsSince1970 = BitConverter.ToInt32(bytes, headerPos + linkerTimestampOffset);
                var dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                dt = dt.AddSeconds(secondsSince1970);
                dt = dt.ToUniversalTime();
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public static byte[] ExtractAssemblyResource(this Assembly assembly, string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            assembly = assembly ?? Assembly.GetCallingAssembly();
            using (var stream = assembly.GetManifestResourceStream(name))
            {
                if (stream == null)
                    throw new FileNotFoundException("Cannot find stream '" + name + "' in assembly '" + assembly.FullName + "'.");

                using (var ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    return ms.ToArray();
                }
            }
        }
    }
}
