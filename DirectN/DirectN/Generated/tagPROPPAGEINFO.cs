// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ocidl.h(1725,9)
using System;
using System.Runtime.InteropServices;
using SIZE = DirectN.tagSIZE;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagPROPPAGEINFO
    {
        public uint cb;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pszTitle;
        public SIZE size;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pszDocString;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pszHelpFile;
        public uint dwHelpContext;
    }
}
