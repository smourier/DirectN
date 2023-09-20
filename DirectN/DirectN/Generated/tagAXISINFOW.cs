// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct tagAXISINFOW
    {
        public int axMinValue;
        public int axMaxValue;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)] 
        public string axAxisName;
    }
}
