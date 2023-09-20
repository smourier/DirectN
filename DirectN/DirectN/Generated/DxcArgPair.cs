// generated from <Windows SDK Path>\um\dxcapi.h
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
