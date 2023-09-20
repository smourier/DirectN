// generated from <Windows SDK Path>\um\d3dcommon.h
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
