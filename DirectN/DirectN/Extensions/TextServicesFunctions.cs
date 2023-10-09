using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace DirectN
{
    public static class TextServicesFunctions
    {
        public static ITextServices Create(this ITextHost host, TextServicesGenerator generator = TextServicesGenerator.Default) => Create<ITextServices>(host, generator);
        public static T Create<T>(this ITextHost host, TextServicesGenerator generator = TextServicesGenerator.Default) where T : ITextServices
        {
            if (host == null)
                throw new ArgumentNullException(nameof(host));

            if (generator == TextServicesGenerator.Office || generator == TextServicesGenerator.OfficeOrDefault)
            {
                var services = CreateOffice<T>(host);
                if (services != null)
                    return services;

                if (generator == TextServicesGenerator.Office)
                    throw new NotSupportedException("Microsoft Office's RichEdit cannot be found.");
            }

            return CreateTextServices<T>(host, TextServicesGenerator.Default);
        }

        public static ITextServices CreateOffice(this ITextHost host) => CreateOffice<ITextServices>(host);
        public static T CreateOffice<T>(this ITextHost host) where T : ITextServices
        {
            if (host == null)
                throw new ArgumentNullException(nameof(host));

            var rootPath = GetOfficeInstallRoot(out var version);
            if (rootPath == null)
                return default;

            string path;
            if (IntPtr.Size == 4)
            {
                path = Path.GetFullPath(Path.Combine(rootPath, @"..\vfs\ProgramFilesCommonX86\Microsoft Shared\OFFICE" + version, "RICHED20.DLL"));
            }
            else
            {
                path = Path.GetFullPath(Path.Combine(rootPath, @"..\vfs\ProgramFilesCommonX64\Microsoft Shared\OFFICE" + version, "RICHED20.DLL"));
            }

            var h = WindowsFunctions.LoadLibrary(path);
            if (h == IntPtr.Zero)
                return default;

            return CreateTextServices<T>(host, TextServicesGenerator.Office);
        }

        private static IntPtr GetPointer(ITextHost host)
        {
            try
            {
                return Marshal.GetComInterfaceForObject(host, typeof(ITextHost2));
            }
            catch (InvalidCastException)
            {
                // do nothing
            }
            return Marshal.GetComInterfaceForObject(host, typeof(ITextHost));
        }

        private static T CreateTextServices<T>(ITextHost host, TextServicesGenerator generator)
        {
            object unk;
            if (IntPtr.Size == 8)
            {
                // for some reason (internal to riched?), we can't pass the object itself, we must use a pointer
                var pp = GetPointer(host);
                if (generator == TextServicesGenerator.Office)
                {
                    // don't check error
                    CreateOfficeTextServices(null, pp, out unk);
                }
                else
                {
                    CreateTextServices(null, pp, out unk).ThrowOnError();
                }
            }
            else
            {
                if (!(host is TextHost th))
                    throw new ArgumentException(null, nameof(host));

                // note this crashes for .NET 5 and x86. I don't understand why
#if NET
                if (IntPtr.Size == 4)
                    throw new NotSupportedException("Rich Text Box is not currently supported on .NET x86 architectures.");
#endif

                if (generator == TextServicesGenerator.Office)
                {
                    // don't check error
                    CreateOfficeTextServices(null, th.HostThunk.Pointer, out unk);
                }
                else
                {
                    CreateTextServices(null, th.HostThunk.Pointer, out unk).ThrowOnError();
                }
            }
            return (T)unk;
        }

        public static TextServicesGenerator GetGenerator(object services)
        {
            if (services == null)
                return TextServicesGenerator.Default;

            if (!Marshal.IsComObject(services))
                throw new ArgumentException("Argument is not a COM object", nameof(services));

            try
            {
                var ptr = Marshal.GetIUnknownForObject(services);
                if (ptr == IntPtr.Zero)
                    return TextServicesGenerator.Default;

                try
                {
                    var firstMethodPointer = Marshal.ReadIntPtr(ptr);
                    if (firstMethodPointer == IntPtr.Zero)
                        return TextServicesGenerator.Default;

                    const int GET_MODULE_HANDLE_EX_FLAG_FROM_ADDRESS = 4;
                    GetModuleHandleEx(GET_MODULE_HANDLE_EX_FLAG_FROM_ADDRESS, firstMethodPointer, out var hmodule);
                    if (hmodule == IntPtr.Zero)
                        return TextServicesGenerator.Default;

                    var path = WindowsFunctions.GetModuleFileName(hmodule);
                    if (path == null)
                        return TextServicesGenerator.Default;

                    var fileName = Path.GetFileNameWithoutExtension(path);
                    return fileName.EqualsIgnoreCase("riched20") ? TextServicesGenerator.Office : TextServicesGenerator.Default;
                }
                finally
                {
                    Marshal.Release(ptr);
                }
            }
            catch
            {
                return TextServicesGenerator.Default;
            }
        }

        public static void Shutdown(ITextServices services)
        {
            if (services == null)
                return;

            var generator = GetGenerator(services);
            if (generator == TextServicesGenerator.Office)
            {
                ShutdownOfficeTextServices(services).ThrowOnError();
                return;
            }
            ShutdownTextServices(services).ThrowOnError();
        }

        private static string GetOfficeInstallRoot(out string version)
        {
            // we currently support only v15 & 16
            version = "16";
            var path = GetOfficeInstallRoot(version + ".0");
            if (path != null)
                return path;

            version = "15";
            return GetOfficeInstallRoot(version + ".0");
        }

        private static string GetOfficeInstallRoot(string version)
        {
            using (var key = Registry.LocalMachine.OpenSubKey(Path.Combine(@"SOFTWARE\Microsoft\Office", version, @"Access\InstallRoot")))
            {
                if (key == null)
                    return null;

                return (key.GetValue("Path", null) as string).Nullify();
            }
        }

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern bool GetModuleHandleEx(int dwFlags, IntPtr lpModuleName, out IntPtr phModule);

        [DllImport("riched20", EntryPoint = nameof(CreateTextServices))]
        private static extern HRESULT CreateOfficeTextServices([MarshalAs(UnmanagedType.IUnknown)] object punkOuter, IntPtr pITextHost, [MarshalAs(UnmanagedType.IUnknown)] out object ppUnk);

        [DllImport("riched20", EntryPoint = nameof(ShutdownTextServices))]
        private static extern HRESULT ShutdownOfficeTextServices([MarshalAs(UnmanagedType.IUnknown)] object pTextServices);

        [DllImport("msftedit")]
        private static extern HRESULT CreateTextServices([MarshalAs(UnmanagedType.IUnknown)] object punkOuter, IntPtr pITextHost, [MarshalAs(UnmanagedType.IUnknown)] out object ppUnk);

        [DllImport("msftedit")]
        private static extern HRESULT ShutdownTextServices([MarshalAs(UnmanagedType.IUnknown)] object pTextServices);
    }
}
