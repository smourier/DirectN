// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ocidl.h(1725,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagPROPPAGEINFO
    {
        public uint cb;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pszTitle;
        public tagSIZE size;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pszDocString;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pszHelpFile;
        public uint dwHelpContext;
    }
}
