using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class ComError
    {
        public static void SetError(string description, [CallerMemberName] string source = null)
        {
            if (description == null)
                throw new ArgumentNullException(nameof(description));

            CreateErrorInfo(out var info).ThrowOnError();
            info.SetDescription(description).ThrowOnError();

            if (source != null)
            {
                info.SetSource(source).ThrowOnError();
            }

            var ei = (IErrorInfo)info;
            SetErrorInfo(0, ei).ThrowOnError();
        }

        public static Exception GetError()
        {
            GetErrorInfo(0, out var info);
            if (info == null)
                return null;

            COMException error;
            info.GetDescription(out var description);

            info.GetSource(out var source);
            if (!string.IsNullOrWhiteSpace(source))
            {
                if (description == null)
                {
                    description = source;
                }
                else
                {
                    description = source + ": " + description;
                }
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                error = new COMException();
            }
            else
            {
                error = new COMException(description);
            }

            info.GetHelpFile(out var help);
            if (!string.IsNullOrWhiteSpace(help))
            {
                error.HelpLink = help;
            }

            return error;
        }

        [ComImport, Guid("22F03340-547D-101B-8E65-08002B2BD119"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface ICreateErrorInfo
        {
            [PreserveSig]
            HRESULT SetGUID([MarshalAs(UnmanagedType.LPStruct)] Guid rguid);

            [PreserveSig]
            HRESULT SetSource([MarshalAs(UnmanagedType.LPWStr)] string szSource);

            [PreserveSig]
            HRESULT SetDescription([MarshalAs(UnmanagedType.LPWStr)] string szDescription);

            [PreserveSig]
            HRESULT SetHelpFile([MarshalAs(UnmanagedType.LPWStr)] string szHelpFile);

            [PreserveSig]
            HRESULT SetHelpContext(int dwHelpContext);
        }

        [ComImport, Guid("1CF2B120-547D-101B-8E65-08002B2BD119"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface IErrorInfo
        {
            [PreserveSig]
            HRESULT GetGUID(out Guid pguid);

            [PreserveSig]
            HRESULT GetSource([MarshalAs(UnmanagedType.BStr)] out string pBstrSource);

            [PreserveSig]
            HRESULT GetDescription([MarshalAs(UnmanagedType.BStr)] out string pBstrDescription);

            [PreserveSig]
            HRESULT GetHelpFile([MarshalAs(UnmanagedType.BStr)] out string pBstrHelpFile);

            [PreserveSig]
            HRESULT GetHelpContext(out int pdwHelpContext);
        }

        [DllImport("oleaut32")]
        private static extern HRESULT GetErrorInfo(int dwReserved, out IErrorInfo perrinfo);

        [DllImport("oleaut32")]
        private static extern HRESULT SetErrorInfo(int dwReserved, IErrorInfo perrinfo);

        [DllImport("oleaut32")]
        private static extern HRESULT CreateErrorInfo(out ICreateErrorInfo errInfo);
    }
}
