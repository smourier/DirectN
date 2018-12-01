// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dcommon.h(344,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D_SHADER_MACRO
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Name;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Definition;
    }
}
