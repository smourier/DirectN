// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DxcDefine
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Name;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Value;
    }
}
