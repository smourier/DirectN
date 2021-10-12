// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxcapi.h(596,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DxcArgPair
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pName;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pValue;
    }
}
