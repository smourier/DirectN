// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\shtypes.h(349,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _COMDLG_FILTERSPEC
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pszName;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pszSpec;
    }
}
