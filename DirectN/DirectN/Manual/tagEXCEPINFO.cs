using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public class tagEXCEPINFO
    {
        public short wCode;
        public short wReserved;
        [MarshalAs(UnmanagedType.BStr)]
        public string bstrSource;
        [MarshalAs(UnmanagedType.BStr)]
        public string bstrDescription;
        [MarshalAs(UnmanagedType.BStr)]
        public string bstrHelpFile;
        public int dwHelpContext;
        public IntPtr pvReserved;
        public IntPtr pfnDeferredFillIn;
        public int scode;
    }
}
